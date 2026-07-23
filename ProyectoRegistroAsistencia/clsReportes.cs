using MySqlConnector;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
                    string sql = "SELECT id_departamento, nombre_departamento FROM tbldepartamento;";
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

        public DataTable ConsultarAsistenciaSemanal(DateTime desde, DateTime hasta, int idDepartamento)
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
                                 "COUNT(DISTINCT a.fecha) AS 'Días Asistidos', " +
                                 "(DATEDIFF(@desde, @hasta) + 1) - COUNT(DISTINCT a.fecha) AS 'Faltas' " +
                                 "FROM tbltrabajador t " +
                                 "INNER JOIN tbldepartamento d ON t.id_departamento = d.id_departamento " +
                                 "INNER JOIN tblasistencia a ON a.id_trabajador = t.id_trabajador " +
                                 "AND a.fecha BETWEEN @desde AND @hasta " +
                                 "WHERE t.estatus = 'activo' " +
                                 (idDepartamento != 0 ? "AND t.id_departamento = @idDepartamento " : "") +
                                 "GROUP BY t.id_trabajador " +
                                 "ORDER BY d.nombre_departamento, t.nombre;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@desde", desde.ToString("yyyy-MM-dd"));
                        comando.Parameters.AddWithValue("@hasta", hasta.ToString("yyyy-MM-dd"));
                        comando.Parameters.AddWithValue("@idDepartamento", idDepartamento);

                        using (consulta = new MySqlDataAdapter(comando))
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




        public void ExportarPDF(DataTable tabla, string tituloReporte, string nombreArchivoSugerido)
        {
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para convertir a PDF", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document.Create(container =>
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
                                row.AutoItem().AlignMiddle().Column(col =>
                                {
                                    col.Item().Text("STAFF ASISTENCE")
                                        .FontSize(18)
                                        .Bold()
                                        .FontColor("#10407A");
                                    col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                                });

                                row.ConstantItem(15); // espacio entre el texto y el logo

                                if (Properties.Resources.LOGO != null)
                                {
                                    byte[] bytesLogo = Properties.Resources.LOGO;
                                    row.ConstantItem(90).AlignMiddle().Image(bytesLogo);
                                }


                                /*if (Properties.Resources.logo_uthh_completo_small != null)
                                {
                                    row.ConstantItem(540).AlignLeft().AlignMiddle().Image(Properties.Resources.logo_uthh_completo_small).FitArea();
                                }
                                row.RelativeItem(); // espacio flexible en medio, empuja los logos a los extremos
                                */

                            });
                            // --- PARTE 2: CONTENIDO CENTRAL ---
                            page.Content().Padding(20).Column(column =>
                            {
                                //Se imprime el titulo que le pases por par�metro
                                column.Item().PaddingBottom(15).Text(tituloReporte)
                                .FontSize(12).Bold().FontColor(Colors.Black);

                                //la tabla se construye sola seg�n las columnas que traigan el DataTable
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
                                x.Span("P�gina ").FontSize(9).FontColor(Colors.Grey.Darken1);
                                x.CurrentPageNumber().FontSize(9).Bold();
                                x.Span(" de ").FontSize(9).FontColor(Colors.Grey.Darken1);
                                x.TotalPages().FontSize(9).Bold();
                            });
                        });
                    }).GeneratePdf(guardarArchivo.FileName);

                    MessageBox.Show("Reporte institucional generado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }//Finaliza el metodo de conversion

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
