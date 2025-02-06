using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AGN_predits.Conexiones.BD.Modelo;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Globalization;
using System.Media;
using System.Data.Common;

namespace AGN_predits.Conexiones.BD.Logica {
    internal class LogicaDetalleVenta {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static LogicaDetalleVenta _LogicaDetalleVenta;

        public static LogicaDetalleVenta Instancia {
            get {
                if (_LogicaDetalleVenta == null) {
                    _LogicaDetalleVenta = new LogicaDetalleVenta();
                }
                return _LogicaDetalleVenta;
            }
        }

        private MySqlConnection conn;

        public void Connect() {
            try {
                conn = new MySqlConnection(cadena);
                conn.Open();
                MessageBox.Show("Conexión exitosa.");
            } catch (Exception ex) {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        public async Task<bool> CargarDetalleVenta(DetalleVenta detalle) {
            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync(); // Abre la conexión de manera asíncrona

                    string query = "INSERT INTO Detallesventa (Fecha, ClienteID, ProductoID, MedioPagoID, Cuotas, Detalles, PlanCanje, Cantidad) " +
                                   "VALUES (@Fecha, @ClienteID, @ProductoID, @MedioPagoID, @Cuotas, @Detalles, @PlanCanje, @Cantidad)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {
                        cmd.Parameters.AddWithValue("@Fecha", detalle.Fecha);
                        cmd.Parameters.AddWithValue("@ClienteID", detalle.ClienteID);
                        cmd.Parameters.AddWithValue("@ProductoID", detalle.ProductoID);
                        cmd.Parameters.AddWithValue("@MedioPagoID", detalle.MedioPagoID);
                        cmd.Parameters.AddWithValue("@Cuotas", detalle.Cuotas);
                        cmd.Parameters.AddWithValue("@Detalles", detalle.Detalles);
                        cmd.Parameters.AddWithValue("@PlanCanje", detalle.PlanCanje);
                        cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync(); // Ejecuta de forma asíncrona
                        return filasAfectadas > 0;  // Devuelve verdadero si se insertó correctamente
                    }
                }
            } catch (Exception ex) {
                throw new Exception($"Error al cargar el detalle de la venta: {ex.Message}");
            }
        }
        public async Task<List<DetalleVenta>> ListarDetallesVentaAsync() {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync();

                    string query = "SELECT * FROM Detallesventa";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {

                        using (var reader = await cmd.ExecuteReaderAsync()) { // Ejecuta la consulta de forma asíncrona
                            while (await reader.ReadAsync()) { // Itera de forma asíncrona
                                var detalleVenta = new DetalleVenta {
                                    DetalleVentaID = Convert.ToInt32(reader["DetalleVentaID"]),
                                    Fecha = Convert.ToDateTime(reader["Fecha"]),
                                    ClienteID = Convert.ToInt32(reader["ClienteID"]),
                                    ProductoID = Convert.ToInt32(reader["ProductoID"]),
                                    MedioPagoID = Convert.ToInt32(reader["MedioPagoID"]),
                                    Cuotas = Convert.ToInt32(reader["Cuotas"]),
                                    Detalles = reader["Detalles"].ToString(),
                                    PlanCanje = reader["PlanCanje"].ToString(),
                                    Cantidad = Convert.ToInt32(reader["Cantidad"])
                                };
                                lista.Add(detalleVenta);
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }

            return lista;
        }

        public async Task<bool> EliminarDetalleVenta(int id) {
            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync();

                    string query = "DELETE FROM Detallesventa WHERE DetalleVentaID = @DetalleVentaID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {
                        cmd.Parameters.AddWithValue("@DetalleVentaID", id);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error al eliminar el detalle de la venta: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> GenerarPDFDetalleVentaAsync(DetalleVenta venta) {
            try {
                SaveFileDialog saveFileDialog = new SaveFileDialog {
                    Filter = "PDF Files|*.pdf",
                    Title = "Guardar PDF",
                    FileName = "Venta_" + venta.DetalleVentaID + ".pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    string filePath = saveFileDialog.FileName;

                    using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                        await conexion.OpenAsync();

                        string query = @"SELECT
                    Detallesventa.DetalleVentaID,
                    Detallesventa.Fecha,
                    clientes.Nombre AS NombreCliente, 
                    clientes.Apellido AS ApellidoCliente, 
                    clientes.Gmail, 
                    producto.Marca AS Marca, 
                    producto.Modelo AS Modelo,
                    producto.PrecioVenta, 
                    mediospago.Mediopago AS FormaPago, 
                    Detallesventa.Cantidad,
                    Detallesventa.Cuotas,
                    Detallesventa.Detalles,
                    Detallesventa.PlanCanje
                FROM
                    Detallesventa
                LEFT JOIN
                    clientes ON Detallesventa.ClienteID = clientes.ClienteID
                LEFT JOIN
                    producto ON Detallesventa.ProductoID = producto.ProductoID
                LEFT JOIN
                    mediospago ON Detallesventa.MedioPagoID = mediospago.MediosPagoID
                WHERE
                    Detallesventa.DetalleVentaID = @DetalleVentaID;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {
                            cmd.Parameters.AddWithValue("@DetalleVentaID", venta.DetalleVentaID);

                            using (DbDataReader reader = await cmd.ExecuteReaderAsync()) {
                                if (await reader.ReadAsync()) {
                                    DateTime fecha = Convert.ToDateTime(reader["Fecha"]);

                                    string nombreCliente = reader["NombreCliente"].ToString(); 
                                    string apellidoCliente = reader["ApellidoCliente"].ToString();
                                    string email = reader["Gmail"].ToString();
                                    string marca = reader["Marca"].ToString();
                                    string precioventa = reader["PrecioVenta"].ToString();
                                    string formaPago = reader["FormaPago"].ToString();
                                    string modelo = reader["Modelo"].ToString();
                                    int cantidad = Convert.ToInt32(reader["Cantidad"].ToString());
                                    int cuotas = Convert.ToInt32(reader["Cuotas"].ToString());
                                    string detalles = reader["Detalles"].ToString();
                                    string planCanje = reader["PlanCanje"].ToString();

                                    Document documento = new Document(PageSize.A4, 50, 50, 50, 50);
                                    PdfWriter.GetInstance(documento, new FileStream(filePath, FileMode.Create));
                                    documento.Open();

                                    documento.AddCreator("AGN Predits");
                                    documento.AddTitle("Recibo de Venta - AGN Predits");

                                    string imgPath = Path.Combine(Application.StartupPath, "Img", "logo.png");
                                    if (File.Exists(imgPath)) {
                                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imgPath);
                                        logo.Alignment = Element.ALIGN_CENTER;
                                        logo.ScaleToFit(150f, 150f);
                                        documento.Add(logo);
                                    }
                                    documento.Add(new Paragraph("\n"));

                                    iTextSharp.text.Font fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                                    Paragraph titulo = new Paragraph("Gracias por tu compra", fontTitulo) { Alignment = Element.ALIGN_CENTER };
                                    documento.Add(titulo);
                                    documento.Add(new Paragraph("\n"));

                                    iTextSharp.text.Font fontCliente = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                                    Paragraph datosCliente = new Paragraph(
                                        $"Cliente: {nombreCliente} {apellidoCliente}\nEmail: {email}", fontCliente) {
                                        Alignment = Element.ALIGN_CENTER
                                    };
                                    documento.Add(datosCliente);
                                    documento.Add(new Paragraph("\n"));

                                    iTextSharp.text.Font fontDetalle = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14f);
                                    documento.Add(new Paragraph("Detalles de la Venta:", fontDetalle));

                                    iTextSharp.text.Font fontTexto = FontFactory.GetFont(FontFactory.HELVETICA, 12f);
                                    Paragraph detallesVenta = new Paragraph(
                                        $"Fecha: {fecha.ToShortDateString()}\n" +
                                        $"Marca: {marca}\n" +
                                        $"Modelo: {modelo}\n" +
                                        $"Forma de Pago: {formaPago}\n" +
                                        $"Cuotas: {cuotas}\n" +
                                        $"Cantidad: {cantidad}\n" +
                                        $"Plan de Canje: {planCanje}\n" +
                                        $"Precio: {precioventa} USD \n " +
                                        
                                        $"Detalles: {detalles}", fontTexto) {
                                        Alignment = Element.ALIGN_LEFT
                                    };
                                    documento.Add(detallesVenta);
                                    documento.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------------------"));

                                    iTextSharp.text.Font fontFinal = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 12f);
                                    Paragraph mensajeFinal = new Paragraph(
                                        "Esperamos que disfrutes tu compra. ¡Gracias por elegir AGN Predits!", fontFinal) {
                                        Alignment = Element.ALIGN_CENTER
                                    };
                                    documento.Add(mensajeFinal);
                                    documento.Add(new Paragraph("\n"));

                                    Paragraph comprobante = new Paragraph("Comprobante no válido como factura", fontFinal) {
                                        Alignment = Element.ALIGN_CENTER
                                    };
                                    documento.Add(comprobante);
                                    documento.Add(new Paragraph("\n"));
                                    // Calcular fecha de garantía (30 días después)
                                    DateTime fechaGarantia = fecha.AddDays(30);
                                    Paragraph garantia = new Paragraph($"Garantía válida hasta: {fechaGarantia.ToShortDateString()}", fontFinal) {
                                        Alignment = Element.ALIGN_CENTER
                                    };
                                    documento.Add(garantia);
                                    documento.Add(new Paragraph("\n"));
                                    documento.Close();
                                } else {
                                    Console.WriteLine("No se encontró una venta con el ID proporcionado.");
                                }
                            }
                        }
                    }
                    return true;
                } else {
                    return false;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


    }

}

