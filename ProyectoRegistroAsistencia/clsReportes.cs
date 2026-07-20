using MySqlConnector;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
                                 "(DATEDIFF(@hasta, @desde) + 1) - COUNT(DISTINCT a.fecha) AS 'Faltas' " +
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
                        if (idDepartamento != 0)
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
            //Abre la ventana para guardar el archivo pdf
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.FileName = nombreArchivoSugerido;
            guardarArchivo.Filter = "Archivos PDF (*.pdf)|*.pdf";

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
                                row.RelativeItem().AlignLeft().AlignMiddle().Column(col =>
                                {
                                    col.Item().Text("UNIVERSIDAD TECNOLOGICA DE LA HUASTECA HIDALGUENSE")
                                    .FontSize(18)
                                    .Bold()
                                    .FontColor("#10407A");
                                    col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                                });

                          
                                //if (Properties.Resources.images != null)
                                //{
                                //    byte[] bytesLogo = Properties.Resources.images;
                                //    row.ConstantItem(90).AlignRight().AlignMiddle().Image(bytesLogo);
                                //}

                             
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

                    MessageBox.Show("Reporte institucional generado con �xito.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }//Finaliza el metodo de conversion

    }

}
