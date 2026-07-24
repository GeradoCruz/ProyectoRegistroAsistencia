using MySqlConnector;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace ProyectoRegistroAsistencia
{
    internal class clsReportes
    {
        private DataTable tabla;
        private MySqlDataAdapter consulta;
        private MySqlCommand comando;

        public DataTable obtenerDepartamentos()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_departamento, nombre_departamento FROM tbldepartamento WHERE estatus = 'activo';";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catalogo de Departamentos: " + ex.Message);
            }
            return tabla;
        }

        // Cuenta los días hábiles (lunes a viernes) entre dos fechas, incluyendo ambos extremos.
        // Sábado y domingo no se trabajan, así que no cuentan como días que se puedan faltar.
        private int ContarDiasHabiles(DateTime desde, DateTime hasta)
        {
            int diasHabiles = 0;
            for (DateTime fecha = desde.Date; fecha <= hasta.Date; fecha = fecha.AddDays(1))
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasHabiles++;
                }
            }
            return diasHabiles;
        }

        // Reporte 1: cuántos días asistió y cuántos faltó cada trabajador en el rango de fechas,
        // contando solo días hábiles (lunes a viernes) como días que se debían trabajar.
        public DataTable ConsultarAsistenciaSemanal(DateTime desde, DateTime hasta, int idDepartamento)
        {
            tabla = new DataTable();
            try
            {
                int totalDiasHabiles = ContarDiasHabiles(desde, hasta);

                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT t.clave_trabajador AS Clave, " +
                                 "CONCAT(t.nombre, ' ', t.a_paterno, ' ', IFNULL(t.a_materno,'')) AS Trabajador, " +
                                 "d.nombre_departamento AS Departamento, " +
                                 "COUNT(DISTINCT a.fecha) AS 'Días Asistidos', " +
                                 "@totalDiasHabiles - COUNT(DISTINCT a.fecha) AS 'Faltas' " +
                                 "FROM tbltrabajador t " +
                                 "INNER JOIN tbldepartamento d ON t.id_departamento = d.id_departamento " +
                                 "LEFT JOIN tblasistencia a ON a.id_trabajador = t.id_trabajador " +
                                 "AND a.fecha BETWEEN @desde AND @hasta " +
                                 "AND WEEKDAY(a.fecha) < 5 " +
                                 "WHERE t.estatus = 'activo' " +
                                 (idDepartamento != 0 ? "AND t.id_departamento = @idDepartamento " : "") +
                                 "GROUP BY t.id_trabajador " +
                                 "ORDER BY d.nombre_departamento, t.nombre;";

                    using (var cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@desde", desde.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@hasta", hasta.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                        cmd.Parameters.AddWithValue("@totalDiasHabiles", totalDiasHabiles);

                        using (consulta = new MySqlDataAdapter(cmd))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar asistencia semanal: " + ex.Message);
            }
            return tabla;
        }

        // Reporte 2: por cada trabajador, cuántos días llegó puntual, con retardo o con falta.
        public DataTable ConsultarTardanzasFaltas(DateTime desde, DateTime hasta, int idDepartamento)
        {
            tabla = new DataTable();
            try
            {
                // Días hábiles (lunes a viernes) del rango: se calculan aquí, en C#.
                int totalDiasHabiles = ContarDiasHabiles(desde, hasta);

                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql =
                        "SELECT t.clave_trabajador AS Clave, " +
                        "CONCAT(t.nombre, ' ', t.a_paterno, ' ', IFNULL(t.a_materno,'')) AS Trabajador, " +
                        "d.nombre_departamento AS Departamento, " +
                        "(SELECT COUNT(*) FROM tblasistencia a " +
                        " WHERE a.id_trabajador = t.id_trabajador AND a.estatus_registro = 'Puntual' " +
                        " AND a.fecha BETWEEN @desde AND @hasta) AS Puntual, " +
                        "(SELECT COUNT(*) FROM tblasistencia a " +
                        " WHERE a.id_trabajador = t.id_trabajador AND a.estatus_registro = 'Retardo' " +
                        " AND a.fecha BETWEEN @desde AND @hasta) AS Retardo, " +
                        "@totalDiasHabiles - (SELECT COUNT(*) FROM tblasistencia a " +
                        " WHERE a.id_trabajador = t.id_trabajador AND a.estatus_registro IN ('Puntual','Retardo') " +
                        " AND a.fecha BETWEEN @desde AND @hasta) AS Falta " +
                        "FROM tbltrabajador t " +
                        "INNER JOIN tbldepartamento d ON d.id_departamento = t.id_departamento " +
                        "WHERE t.estatus = 'activo' " +
                        (idDepartamento != 0 ? "AND t.id_departamento = @idDepartamento " : "") +
                        "ORDER BY d.nombre_departamento, t.nombre;";

                    using (var cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@desde", desde.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@hasta", hasta.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                        cmd.Parameters.AddWithValue("@totalDiasHabiles", totalDiasHabiles);

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

        // Reporte 3: por cada trabajador, cuántas incidencias tiene registradas en el rango de fechas,
        // separadas por tipo (faltas/retardos) y por si están justificadas o no.
        public DataTable ConsultarIncidenciasPorEmpleado(DateTime desde, DateTime hasta, int idDepartamento)
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT t.clave_trabajador AS Clave, " +
                                 "CONCAT(t.nombre, ' ', t.a_paterno, ' ', IFNULL(t.a_materno,'')) AS Trabajador, " +
                                 "d.nombre_departamento AS Departamento, " +
                                 "SUM(CASE WHEN ti.nombre_tipo = 'Falta' THEN 1 ELSE 0 END) AS Faltas, " +
                                 "SUM(CASE WHEN ti.nombre_tipo = 'Retardo' THEN 1 ELSE 0 END) AS Retardos, " +
                                 "SUM(CASE WHEN i.justificacion IS NOT NULL THEN 1 ELSE 0 END) AS Justificadas, " +
                                 "SUM(CASE WHEN i.justificacion IS NULL THEN 1 ELSE 0 END) AS 'Sin Justificar' " +
                                 "FROM tblincidencias i " +
                                 "INNER JOIN tbltrabajador t ON t.id_trabajador = i.id_trabajador AND t.estatus = 'activo' " +
                                 "INNER JOIN tbldepartamento d ON d.id_departamento = t.id_departamento " +
                                 "INNER JOIN tbltipoincidencias ti ON ti.id_tipo_incidencia = i.id_tipo_incidencia " +
                                 "WHERE i.fecha BETWEEN @desde AND @hasta " +
                                 (idDepartamento != 0 ? "AND t.id_departamento = @idDepartamento " : "") +
                                 "GROUP BY t.id_trabajador " +
                                 "ORDER BY d.nombre_departamento, t.nombre;";

                    using (var cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@desde", desde.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@hasta", hasta.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);

                        using (consulta = new MySqlDataAdapter(cmd))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar las incidencias por empleado: " + ex.Message);
            }
            return tabla;
        }

        // Arma el documento PDF a partir del DataTable; lo usan tanto ExportarPDF (guardar)
        // como Imprimir (enviar directo a la impresora), para no duplicar el diseño del reporte.
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

                    //Agregar Titulo al reporte
                    page.Header().Row(row =>
                    {
                        row.RelativeItem().AlignLeft().AlignMiddle().Column(col =>
                        {
                            col.Item().Text("SYSTEM STAFF ASISTENCE ")
                            .FontSize(18)
                            .Bold()
                            .FontColor("#10407A");
                            col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                        });

                        if (Properties.Resources.LOGO != null)
                        {
                            byte[] bytesLogo = Properties.Resources.LOGO;
                            row.ConstantItem(90).AlignRight().AlignMiddle().Image(bytesLogo);
                        }
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

        public void ExportarPDF(DataTable tabla, string tituloReporte, string nombreArchivoSugerido)
        {
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
                    CrearDocumentoPdf(tabla, tituloReporte).GeneratePdf(guardarArchivo.FileName);

                    MessageBox.Show("Reporte institucional generado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }//Finaliza el metodo de conversion

        // Genera el PDF en una carpeta temporal y lo manda directo al diálogo de impresión
        // del programa que el usuario tenga configurado para abrir PDFs (Adobe, Edge, etc.).
        public void Imprimir(DataTable tabla, string tituloReporte)
        {
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rutaTemporal = Path.Combine(Path.GetTempPath(), $"Reporte_{Guid.NewGuid():N}.pdf");

            try
            {
                CrearDocumentoPdf(tabla, tituloReporte).GeneratePdf(rutaTemporal);

                var psi = new ProcessStartInfo(rutaTemporal)
                {
                    UseShellExecute = true,
                    Verb = "print"
                };
                Process.Start(psi);
            }
            catch (Exception)
            {
                // Si el programa predeterminado para PDFs no soporta el comando de imprimir directo,
                // al menos lo abrimos para que el usuario pueda imprimirlo manualmente.
                try
                {
                    Process.Start(new ProcessStartInfo(rutaTemporal) { UseShellExecute = true });
                    MessageBox.Show("No se pudo enviar directo a la impresora. Se abrió el PDF para que lo imprimas manualmente (Ctrl+P).",
                        "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exAbrir)
                {
                    throw new Exception("No se pudo abrir el reporte para imprimir: " + exAbrir.Message);
                }
            }
        }

        public void ExportarExcel(DataTable tabla, string tituloReporte, string nombreArchivoSugerido)
        {
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para convertir a Excel", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
