using AGN_predits.Conexiones.BD.Modelo;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Lam7ara.Conexiones.BD;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGN_predits.Conexiones.BD.Logica
{
    internal class LogicaDetalleVenta
    {

        private static LogicaDetalleVenta _LogicaDetalleVenta;

        public static LogicaDetalleVenta Instancia
        {
            get
            {
                if (_LogicaDetalleVenta == null)
                {
                    _LogicaDetalleVenta = new LogicaDetalleVenta();
                }
                return _LogicaDetalleVenta;
            }
        }

        private SQLiteConnection conn;

        public void Connect()
        {
            try
            {
                conn = Conectar.ObtenerConexion();
                conn.Open();
                MessageBox.Show("Conexión exitosa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        public async Task<bool> CargarDetalleVenta(DetalleVenta detalle)
        {
            try
            {
                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {
                     // Abre la conexión de manera asíncrona

                    string query = "INSERT INTO DetalleVenta (Fecha, ClienteID, ProductoID, MedioPagoID, Cuotas, Detalles, PlanCanje, Cantidad) " +
                                   "VALUES (@Fecha, @ClienteID, @ProductoID, @MedioPagoID, @Cuotas, @Detalles, @PlanCanje, @Cantidad)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
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
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar el detalle de la venta: {ex.Message}");
            }
        }



        public async Task<List<DetalleVenta>> ListarDetallesVentaAsync()
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            try
            {
                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {
                    

                    string query = "SELECT * FROM DetalleVenta";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {

                        using (var reader = await cmd.ExecuteReaderAsync())
                        { // Ejecuta la consulta de forma asíncrona
                            while (await reader.ReadAsync())
                            { // Itera de forma asíncrona
                                var detalleVenta = new DetalleVenta
                                {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }

            return lista;
        }


        public async Task<bool> EliminarDetalleVenta(int id)
        {
            try
            {
                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {
                    

                    string query = "DELETE FROM DetalleVenta WHERE DetalleVentaID = @DetalleVentaID";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@DetalleVentaID", id);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el detalle de la venta: {ex.Message}");
                return false;
            }
        }
        public bool GenerarPDFDetalleVenta(DetalleVenta venta)
        {
            try
            {
                // Crear el diálogo para guardar el archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Guardar PDF";
                saveFileDialog.FileName = "Venta_" + venta.DetalleVentaID + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ubicación donde el usuario desea guardar el archivo
                    string filePath = saveFileDialog.FileName;

                    // Obtener datos de la base de datos
                    using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                    {
                        string query = @"
                    SELECT
                        DetalleVenta.DetalleVentaID,
                        DetalleVenta.Fecha,
                        Cliente.Nombre AS NombreCliente, 
                        Cliente.Apellido AS ApellidoCliente, 
                        Cliente.Direccion,
                        Cliente.Email, 
                        Productos.Nombre AS Producto, 
                        Productos.PrecioVenta, 
                        FormaPago.MetodoPago AS FormaPago, 
                        Monedas.Moneda AS Moneda,  
                        DetalleVenta.Cantidad,
                        DetalleVenta.Cuotas,
                        DetalleVenta.Detalles,
                        DetalleVenta.PlanCanje
                    FROM
                        DetalleVenta
                    LEFT JOIN
                        Cliente ON DetalleVenta.ClienteID = Cliente.ClienteID
                    LEFT JOIN
                        Productos ON DetalleVenta.ProductoID = Productos.ProductoID
                    LEFT JOIN
                        FormaPago ON DetalleVenta.MedioPagoID = FormaPago.MedioPagoID
                    LEFT JOIN
                        Monedas ON DetalleVenta.MonedaID = Monedas.MonedaID
                    WHERE
                        DetalleVenta.DetalleVentaID = @DetalleVentaID";

                        SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@DetalleVentaID", venta.DetalleVentaID);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Obtener los datos necesarios
                                DateTime fecha = DateTime.Parse(reader["Fecha"].ToString());
                                string nombreCliente = reader["NombreCliente"].ToString();
                                string apellidoCliente = reader["ApellidoCliente"].ToString();
                                string direccion = reader["Direccion"].ToString();
                                string email = reader["Email"].ToString();
                                string producto = reader["Producto"].ToString();
                                string formaPago = reader["FormaPago"].ToString();
                                string moneda = reader["Moneda"].ToString();
                                int cantidad = int.Parse(reader["Cantidad"].ToString());
                                int cuotas = int.Parse(reader["Cuotas"].ToString());
                                string detalles = reader["Detalles"].ToString();
                                string planCanje = reader["PlanCanje"].ToString();
                                Document documento = new Document(PageSize.A4, 50, 50, 50, 50);

                                PdfWriter.GetInstance(documento, new FileStream(filePath, FileMode.Create));
                                documento.Open();

                                documento.AddCreator("AGN Predits");

                                documento.AddTitle("Recibo de Venta - AGN Predits");

                                string imgPath = Path.Combine(Application.StartupPath, "Img", "logo.png");

                                if (File.Exists(imgPath))
                                {
                                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imgPath);  // Especificar el espacio de nombres completo
                                    logo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                                    logo.ScaleToFit(150f, 150f);
                                    documento.Add(logo);
                                }


                                documento.Add(new Paragraph("\n"));

                                // Título de la venta centrado
                                iTextSharp.text.Font fontTitulo = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 18);
                                Paragraph titulo = new Paragraph("Gracias por tu compra", fontTitulo);
                                titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                                documento.Add(titulo);

                                documento.Add(new Paragraph("\n"));

                                // Información del cliente centrada y estilizada
                                iTextSharp.text.Font fontCliente = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 12);
                                Paragraph datosCliente = new Paragraph(
                                    $"Cliente: {nombreCliente} {apellidoCliente}\nDirección: {direccion}\nEmail: {email}",
                                    fontCliente);
                                datosCliente.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                                documento.Add(datosCliente);


                                documento.Add(new Paragraph("\n"));

                                // Muestra info de la venta
                                iTextSharp.text.Font fontDetalle = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 14f); // Asegúrate de usar "14f" como un float
                                documento.Add(new Paragraph("Detalles de la Venta:", fontDetalle));

                                iTextSharp.text.Font fontTexto = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 12f); // Asegúrate de usar "12f" como un float


                                Paragraph detallesVenta = new Paragraph(
                                    $@"Fecha: {fecha.ToShortDateString()}
                            Producto: {producto}
                            Forma de Pago: {formaPago}
                            Cuotas: {cuotas}
                            Cantidad: {cantidad} 
                            Plan de Canje: {planCanje}
                            Detalles: 
                                {detalles}",
                                    fontTexto);
                                detallesVenta.Alignment = Element.ALIGN_LEFT;
                                documento.Add(detallesVenta);

                                documento.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------------------"));

                                // Mensaje final de agradecimiento
                                iTextSharp.text.Font fontFinal = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_OBLIQUE, 12f); // Asegúrate de usar "12f" como un float
                                Paragraph mensajeFinal = new Paragraph(
                                    "Esperamos que disfrutes tu compra. ¡Gracias por elegir AGN Predits!",
                                    fontFinal);
                                mensajeFinal.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                                documento.Add(mensajeFinal);

                                // Corregir la creación del segundo párrafo y alineación
                                Paragraph comprobante = new Paragraph("Comprobante no valido como factura", fontFinal);
                                comprobante.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                                documento.Add(comprobante);

                                documento.Add(new Paragraph("\n"));


                                documento.Close();
                            }
                            else
                            {
                                Console.WriteLine("No se encontró una venta con el ID proporcionado.");
                            }
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

    }
}
