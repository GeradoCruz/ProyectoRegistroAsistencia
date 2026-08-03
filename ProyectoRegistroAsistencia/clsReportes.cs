using MySqlConnector;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace ProyectoRegistroAsistencia
{
    // Consultas SQL de los reportes + generación de PDF/Excel/impresión.
    internal class clsReportes
    {
        private DataTable tabla;
        private MySqlDataAdapter consulta;
        private MySqlCommand comando;

        // Catálogo de departamentos activos (para el combo del formulario).
        public DataTable obtenerDepartamentos()
        {
            tabla = new DataTable();
            try
            {
                // Abrir conexión
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Consultar y llenar la tabla
                    string sql = "SELECT id_departamento, nombre_departamento FROM tbldepartamento WHERE estatus = 'activo';";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                // Error de conexión o de consulta
                throw new Exception("Error al obtener el catalogo de Departamentos: " + ex.Message);
            }
            return tabla;
        }

        // Cuenta días de lunes a viernes entre dos fechas (sábado/domingo no cuentan).
        private int ContarDiasHabiles(DateTime desde, DateTime hasta)
        {
            int diasHabiles = 0;
            // Recorrer día por día del rango y sumar solo lunes a viernes
            for (DateTime fecha = desde.Date; fecha <= hasta.Date; fecha = fecha.AddDays(1))
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasHabiles++;
                }
            }
            return diasHabiles;
        }

        // Reporte de Asistencia y Puntualidad: puntual/retardo/falta por trabajador en el rango.
        public DataTable ConsultarTardanzasFaltas(DateTime desde, DateTime hasta, int idDepartamento, string apellidos = "")
        {
            tabla = new DataTable();
            try
            {
                // Calcular datos base antes de armar la consulta
                int totalDiasHabiles = ContarDiasHabiles(desde, hasta);
                bool filtrarApellidos = !string.IsNullOrWhiteSpace(apellidos);

                // Abrir conexión
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Armar el SQL (WEEKDAY < 5 en cada subconsulta = ignora sábado/domingo)
                    string sql =
                        "SELECT t.clave_trabajador AS Clave, " +
                        "CONCAT(t.nombre, ' ', t.a_paterno, ' ', IFNULL(t.a_materno,'')) AS Trabajador, " +
                        "d.nombre_departamento AS Departamento, " +
                        "p.nombre_puesto AS Puesto, " +
                        "(SELECT COUNT(*) FROM tblasistencia a " +
                        " WHERE a.id_trabajador = t.id_trabajador AND a.estatus_registro = 'Puntual' " +
                        " AND a.fecha BETWEEN @desde AND @hasta AND WEEKDAY(a.fecha) < 5) AS Puntual, " +
                        "(SELECT COUNT(*) FROM tblasistencia a " +
                        " WHERE a.id_trabajador = t.id_trabajador AND a.estatus_registro = 'Retardo' " +
                        " AND a.fecha BETWEEN @desde AND @hasta AND WEEKDAY(a.fecha) < 5) AS Retardo, " +
                        "@totalDiasHabiles - (SELECT COUNT(*) FROM tblasistencia a " +
                        " WHERE a.id_trabajador = t.id_trabajador AND a.estatus_registro IN ('Puntual','Retardo') " +
                        " AND a.fecha BETWEEN @desde AND @hasta AND WEEKDAY(a.fecha) < 5) AS Falta " +
                        "FROM tbltrabajador t " +
                        "INNER JOIN tbldepartamento d ON d.id_departamento = t.id_departamento " +
                        "INNER JOIN tblpuestos p ON p.id_puesto = t.id_puesto " +
                        "WHERE t.estatus = 'activo' " +
                        (idDepartamento != 0 ? "AND t.id_departamento = @idDepartamento " : "") +
                        (filtrarApellidos ? "AND (t.a_paterno LIKE @apellidos OR t.a_materno LIKE @apellidos) " : "") +
                        "ORDER BY d.nombre_departamento, t.nombre;";

                    // Ejecutar la consulta con sus parámetros
                    using (var cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@desde", desde.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@hasta", hasta.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                        cmd.Parameters.AddWithValue("@totalDiasHabiles", totalDiasHabiles);
                        if (filtrarApellidos)
                        {
                            cmd.Parameters.AddWithValue("@apellidos", "%" + apellidos.Trim() + "%");
                        }

                        // Llenar la tabla de resultados
                        using (consulta = new MySqlDataAdapter(cmd))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar tardanzas y faltas: " + ex.Message);
            }
            return tabla;
        }

        // Reporte de Antigüedad: fecha de ingreso y tiempo trabajado (años/meses) por empleado activo.
        // No usa rango de fechas, la antigüedad siempre se calcula contra la fecha de hoy (CURDATE()).
        public DataTable ConsultarAntiguedad(int idDepartamento, string apellidos = "")
        {
            tabla = new DataTable();
            try
            {
                // Filtro opcional de apellidos
                bool filtrarApellidos = !string.IsNullOrWhiteSpace(apellidos);

                // Abrir conexión
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // TIMESTAMPDIFF calcula años completos y, con el módulo 12, los meses restantes
                    string sql = "SELECT t.clave_trabajador AS Clave, " +
                                 "CONCAT(t.nombre, ' ', t.a_paterno, ' ', IFNULL(t.a_materno,'')) AS Trabajador, " +
                                 "d.nombre_departamento AS Departamento, " +
                                 "p.nombre_puesto AS Puesto, " +
                                 "t.fecha_ingreso AS 'Fecha de Ingreso', " +
                                 "CONCAT(TIMESTAMPDIFF(YEAR, t.fecha_ingreso, CURDATE()), ' años, ', " +
                                 "TIMESTAMPDIFF(MONTH, t.fecha_ingreso, CURDATE()) % 12, ' meses') AS Antigüedad " +
                                 "FROM tbltrabajador t " +
                                 "INNER JOIN tbldepartamento d ON d.id_departamento = t.id_departamento " +
                                 "INNER JOIN tblpuestos p ON p.id_puesto = t.id_puesto " +
                                 "WHERE t.estatus = 'activo' " +
                                 (idDepartamento != 0 ? "AND t.id_departamento = @idDepartamento " : "") +
                                 (filtrarApellidos ? "AND (t.a_paterno LIKE @apellidos OR t.a_materno LIKE @apellidos) " : "") +
                                 "ORDER BY t.fecha_ingreso ASC;";

                    // Ejecutar la consulta con sus parámetros
                    using (var cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                        if (filtrarApellidos)
                        {
                            cmd.Parameters.AddWithValue("@apellidos", "%" + apellidos.Trim() + "%");
                        }

                        // Llenar la tabla de resultados
                        using (consulta = new MySqlDataAdapter(cmd))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar la antigüedad: " + ex.Message);
            }
            return tabla;
        }

        // Reporte de Empleados sin Horario Asignado: detecta activos sin registro en tblhorario_trabajo.
        // Sirve para corregir casos que afectarían otros reportes (Puntualidad, Horas Trabajadas).
        public DataTable ConsultarEmpleadosSinHorario(int idDepartamento, string apellidos = "")
        {
            tabla = new DataTable();
            try
            {
                // Filtro opcional de apellidos
                bool filtrarApellidos = !string.IsNullOrWhiteSpace(apellidos);

                // Abrir conexión
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // LEFT JOIN + IS NULL: trae solo a quienes no tienen ninguna fila en tblhorario_trabajo
                    string sql = "SELECT t.clave_trabajador AS Clave, " +
                                 "CONCAT(t.nombre, ' ', t.a_paterno, ' ', IFNULL(t.a_materno,'')) AS Trabajador, " +
                                 "d.nombre_departamento AS Departamento, " +
                                 "p.nombre_puesto AS Puesto " +
                                 "FROM tbltrabajador t " +
                                 "INNER JOIN tbldepartamento d ON d.id_departamento = t.id_departamento " +
                                 "INNER JOIN tblpuestos p ON p.id_puesto = t.id_puesto " +
                                 "LEFT JOIN tblhorario_trabajo h ON h.id_trabajador = t.id_trabajador " +
                                 "WHERE t.estatus = 'activo' AND h.id_trabajador IS NULL " +
                                 (idDepartamento != 0 ? "AND t.id_departamento = @idDepartamento " : "") +
                                 (filtrarApellidos ? "AND (t.a_paterno LIKE @apellidos OR t.a_materno LIKE @apellidos) " : "") +
                                 "ORDER BY Trabajador;";

                    // Ejecutar la consulta con sus parámetros
                    using (var cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                        if (filtrarApellidos)
                        {
                            cmd.Parameters.AddWithValue("@apellidos", "%" + apellidos.Trim() + "%");
                        }

                        // Llenar la tabla de resultados
                        using (consulta = new MySqlDataAdapter(cmd))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar empleados sin horario: " + ex.Message);
            }
            return tabla;
        }

        // Arma el PDF del reporte (usado por ExportarPDF para no repetir el diseño).
        private IDocument CrearDocumentoPdf(DataTable tabla, string tituloReporte)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.Letter.Landscape());
                    page.Margin(1.5f, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontFamily(Fonts.TimesNewRoman));

                    // Encabezado: título + logo arriba, y debajo la fecha de generación y quién lo generó
                    page.Header().Column(encabezado =>
                    {
                        // Título a la izquierda y logo a la derecha, alineados en la misma fila
                        encabezado.Item().Row(row =>
                        {
                            row.RelativeItem().AlignLeft().AlignMiddle().Text("SYSTEM STAFF ASISTENCE")
                                .FontSize(18).Bold().FontColor("#10407A");

                            if (Properties.Resources.LOGO != null)
                            {
                                byte[] bytesLogo = Properties.Resources.LOGO;
                                row.ConstantItem(90).AlignRight().AlignMiddle().Image(bytesLogo);
                            }
                        });

                        // Línea separadora debajo del título y el logo
                        encabezado.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                        // Fecha/hora de generación (izquierda) y usuario que lo generó (derecha)
                        encabezado.Item().PaddingTop(4).Row(row =>
                        {
                            row.RelativeItem().AlignLeft().Text($"Generado el: {DateTime.Now:dd/MM/yyyy HH:mm}")
                                .FontSize(8).FontColor(Colors.Grey.Darken1);

                            row.RelativeItem().AlignRight().Text($"Generado por: {clsLogin.usuarioActual}")
                                .FontSize(8).FontColor(Colors.Grey.Darken1);
                        });
                    });

                    // --- PARTE 2: CONTENIDO CENTRAL ---
                    page.Content().Padding(20).Column(column =>
                    {
                        //Se imprime el titulo que le pases por parámetro
                        column.Item().PaddingBottom(15).Text(tituloReporte)
                        .FontSize(12).Bold().FontColor(Colors.Black);

                        //la tabla se construye sola según las columnas que traigan el DataTable
                        column.Item().Table(table =>
                        {
                            int totalColumnas = tabla.Columns.Count;

                            table.ColumnsDefinition(columns =>
                            {
                                for (int i = 0; i < totalColumnas; i++)
                                {
                                    if (i > 0 && i < totalColumnas - 1)
                                    {
                                        columns.RelativeColumn(2f);
                                    }
                                    else
                                    {
                                        columns.RelativeColumn(1.2f);
                                    }
                                }
                            });

                            //Nombres de las columnas en automatico de acuerdo a la tabla
                            foreach (DataColumn columnaObj in tabla.Columns)
                            {
                                table.Cell().Background("#4272CB").Padding(8).AlignLeft().AlignMiddle()
                                                                    .Text(columnaObj.ColumnName)
                                                                    .FontSize(10)
                                                                    .Bold()
                                                                    .FontColor(Colors.White);
                            }

                            //Filas automaticas
                            bool alternarFila = true;
                            foreach (DataRow fila in tabla.Rows)
                            {
                                string colorFondo = alternarFila ? "#E6E8F5" : "#FFFFFF";
                                for (int i = 0; i < totalColumnas; i++)
                                {
                                    var celda = table.Cell().Background(colorFondo)
                                                            .BorderBottom(1).BorderColor(Colors.Grey.Lighten3)
                                                            .Padding(7).AlignMiddle();
                                    if (i == 0 || i == (totalColumnas - 1))
                                        celda.AlignCenter();
                                    else
                                        celda.AlignLeft();

                                    celda.Text(fila[i].ToString()).FontSize(9).FontColor(Colors.Black);
                                }
                                alternarFila = !alternarFila;
                            }
                        });
                    });
                    //Este es el pie de pagina
                    page.Footer().AlignRight().Text(x =>
                    {
                        x.Span("Página ").FontSize(9).FontColor(Colors.Grey.Darken1);
                        x.CurrentPageNumber().FontSize(9).Bold();
                        x.Span(" de ").FontSize(9).FontColor(Colors.Grey.Darken1);
                        x.TotalPages().FontSize(9).Bold();
                    });
                });
            });
        }

        // Exporta el reporte a PDF (pide dónde guardarlo).
        public void ExportarPDF(DataTable tabla, string tituloReporte, string nombreArchivoSugerido)
        {
            // Validar que haya datos
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para convertir a PDF", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Abre la ventana para guardar el archivo pdf
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.FileName = nombreArchivoSugerido;
            guardarArchivo.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Generar y guardar el PDF
                    CrearDocumentoPdf(tabla, tituloReporte).GeneratePdf(guardarArchivo.FileName);

                    MessageBox.Show("Reporte institucional generado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }//Finaliza el metodo de conversion

        // Exporta el reporte a Excel (pide dónde guardarlo).
        public void ExportarExcel(DataTable tabla, string tituloReporte, string nombreArchivoSugerido)
        {
            // Validar que haya datos
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para convertir a Excel", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Diálogo para elegir dónde guardar
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.FileName = nombreArchivoSugerido;
            guardarArchivo.Filter = "Archivos Excel (*.xlsx)|*.xlsx";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var hoja = workbook.Worksheets.Add("Reporte");
                        int totalColumnas = tabla.Columns.Count;

                        // Título del reporte (fila 1, combinada)
                        hoja.Range(1, 1, 1, totalColumnas).Merge();
                        hoja.Cell(1, 1).Value = tituloReporte;
                        hoja.Cell(1, 1).Style.Font.Bold = true;
                        hoja.Cell(1, 1).Style.Font.FontSize = 14;
                        hoja.Cell(1, 1).Style.Font.FontColor = XLColor.FromHtml("#10407A");
                        hoja.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // Encabezados de columna (fila 3)
                        int filaEncabezado = 3;
                        for (int col = 0; col < totalColumnas; col++)
                        {
                            var celda = hoja.Cell(filaEncabezado, col + 1);
                            celda.Value = tabla.Columns[col].ColumnName;
                            celda.Style.Font.Bold = true;
                            celda.Style.Font.FontColor = XLColor.White;
                            celda.Style.Fill.BackgroundColor = XLColor.FromHtml("#4272CB");
                            celda.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        }

                        // Filas de datos, con bandas alternadas igual que en el PDF
                        int filaActual = filaEncabezado + 1;
                        bool alternarFila = true;
                        foreach (DataRow fila in tabla.Rows)
                        {
                            for (int col = 0; col < totalColumnas; col++)
                            {
                                var celda = hoja.Cell(filaActual, col + 1);
                                celda.Value = fila[col].ToString();
                                celda.Style.Fill.BackgroundColor = alternarFila
                                    ? XLColor.FromHtml("#E6E8F5")
                                    : XLColor.White;
                                celda.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                                celda.Style.Border.BottomBorderColor = XLColor.LightGray;
                            }
                            alternarFila = !alternarFila;
                            filaActual++;
                        }

                        // Ajusta el ancho de columnas automáticamente al contenido
                        hoja.Columns().AdjustToContents();

                        workbook.SaveAs(guardarArchivo.FileName);
                    }

                    MessageBox.Show("Reporte institucional generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }

}
