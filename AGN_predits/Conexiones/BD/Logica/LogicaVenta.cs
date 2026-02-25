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
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Guardar PDF";
                saveFileDialog.FileName = "Venta_" + venta.DetalleVentaID + ".pdf";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return false;

                string filePath = saveFileDialog.FileName;

                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {
                    string query = @"
                SELECT
                    DetalleVenta.DetalleVentaID,
                    DetalleVenta.Fecha,
                    Cliente.Nombre AS NombreCliente, 
                    Cliente.Apellido AS ApellidoCliente, 
                    Cliente.Gmail, 
                    Producto.Marca, 
                    Producto.Modelo AS Producto, 
                    Producto.PrecioVenta, 
                    MedioPago.Mediopago AS FormaPago, 
                    DetalleVenta.Cantidad,
                    DetalleVenta.Cuotas,
                    DetalleVenta.Detalles,
                    DetalleVenta.PlanCanje
                FROM DetalleVenta
                LEFT JOIN Cliente ON DetalleVenta.ClienteID = Cliente.ClienteID
                LEFT JOIN Producto ON DetalleVenta.ProductoID = Producto.ProductoID
                LEFT JOIN Mediopago ON DetalleVenta.MedioPagoID = MedioPago.MediosPagoID
                WHERE DetalleVenta.DetalleVentaID = @DetalleVentaID";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@DetalleVentaID", venta.DetalleVentaID);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("No se encontró la venta con el ID proporcionado.");
                                return false;
                            }

                            // Leer datos
                            DateTime fecha = DateTime.Parse(reader["Fecha"].ToString());
                            string nombreCliente = reader["NombreCliente"].ToString();
                            string apellidoCliente = reader["ApellidoCliente"].ToString();
                            string email = reader["Gmail"].ToString();
                            string marca = reader["Marca"].ToString();
                            string producto = reader["Producto"].ToString();
                            string formaPago = reader["FormaPago"].ToString();
                            decimal precioVenta = Convert.ToDecimal(reader["PrecioVenta"]);
                            int cantidad = Convert.ToInt32(reader["Cantidad"]);
                            int cuotas = Convert.ToInt32(reader["Cuotas"]);
                            string detalles = reader["Detalles"].ToString();
                            string planCanje = reader["PlanCanje"].ToString();

                            decimal total = precioVenta * cantidad;
                            decimal valorCuota = cuotas > 0 ? total / cuotas : total;

                            // === CREAR PDF ===
                            Document documento = new Document(PageSize.A4, 40, 40, 40, 40);
                            PdfWriter.GetInstance(documento, new FileStream(filePath, FileMode.Create));
                            documento.Open();
                            documento.AddCreator("AGN Predits");
                            documento.AddTitle("Recibo de Venta - AGN Predits");

                            // Colores
                            BaseColor colorPrimario = new BaseColor(33, 37, 41);
                            BaseColor colorGrisClaro = new BaseColor(245, 245, 245);
                            BaseColor colorBorde = new BaseColor(200, 200, 200);
                            BaseColor colorAcento = new BaseColor(0, 123, 255);

                            // Fuentes
                            Font fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20f, colorPrimario);
                            Font fontSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12f, colorPrimario);
                            Font fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10f, colorPrimario);
                            Font fontNormalBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f, colorPrimario);
                            Font fontPeque = FontFactory.GetFont(FontFactory.HELVETICA, 8f, BaseColor.GRAY);
                            Font fontTotal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14f, colorAcento);
                            Font fontItalic = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10f, BaseColor.GRAY);

                            // --- Logo ---
                            string imgPath = Path.Combine(Application.StartupPath, "Img", "logo.png");
                            if (File.Exists(imgPath))
                            {
                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imgPath);
                                logo.Alignment = Element.ALIGN_CENTER;
                                logo.ScaleToFit(120f, 120f);
                                documento.Add(logo);
                            }

                            // --- Encabezado ---
                            Paragraph pTitulo = new Paragraph("COMPROBANTE DE VENTA", fontTitulo);
                            pTitulo.Alignment = Element.ALIGN_CENTER;
                            pTitulo.SpacingBefore = 10f;
                            documento.Add(pTitulo);

                            Paragraph pNumero = new Paragraph($"N° {venta.DetalleVentaID:D6}  |  Fecha: {fecha:dd/MM/yyyy}", fontNormal);
                            pNumero.Alignment = Element.ALIGN_CENTER;
                            pNumero.SpacingAfter = 15f;
                            documento.Add(pNumero);

                            // --- Línea separadora ---
                            PdfPTable lineaSep = new PdfPTable(1);
                            lineaSep.WidthPercentage = 100;
                            PdfPCell celdaLinea = new PdfPCell();
                            celdaLinea.BorderWidthBottom = 1.5f;
                            celdaLinea.BorderColorBottom = colorAcento;
                            celdaLinea.BorderWidthTop = 0;
                            celdaLinea.BorderWidthLeft = 0;
                            celdaLinea.BorderWidthRight = 0;
                            celdaLinea.FixedHeight = 5f;
                            lineaSep.AddCell(celdaLinea);
                            documento.Add(lineaSep);

                            documento.Add(new Paragraph("\n"));

                            // --- Datos del cliente ---
                            PdfPTable tablaCliente = new PdfPTable(2);
                            tablaCliente.WidthPercentage = 100;
                            tablaCliente.SetWidths(new float[] { 30f, 70f });

                            Action<string, string> agregarFila = (etiqueta, valor) =>
                            {
                                PdfPCell cLabel = new PdfPCell(new Phrase(etiqueta, fontNormalBold));
                                cLabel.Border = Rectangle.NO_BORDER;
                                cLabel.PaddingBottom = 5f;
                                tablaCliente.AddCell(cLabel);

                                PdfPCell cValor = new PdfPCell(new Phrase(valor, fontNormal));
                                cValor.Border = Rectangle.NO_BORDER;
                                cValor.PaddingBottom = 5f;
                                tablaCliente.AddCell(cValor);
                            };

                            agregarFila("Cliente:", $"{nombreCliente} {apellidoCliente}");
                            agregarFila("Email:", email);
                            agregarFila("Forma de Pago:", formaPago);
                            if (cuotas > 1)
                                agregarFila("Cuotas:", $"{cuotas}x de ${valorCuota:N2}");

                            if (!string.IsNullOrWhiteSpace(planCanje))
                                agregarFila("Plan Canje:", planCanje);

                            documento.Add(tablaCliente);
                            documento.Add(new Paragraph("\n"));

                            // --- Tabla de producto ---
                            Paragraph pDetalle = new Paragraph("DETALLE DE PRODUCTOS", fontSubtitulo);
                            pDetalle.SpacingAfter = 8f;
                            documento.Add(pDetalle);

                            PdfPTable tablaProducto = new PdfPTable(4);
                            tablaProducto.WidthPercentage = 100;
                            tablaProducto.SetWidths(new float[] { 40f, 20f, 20f, 20f });

                            // Encabezados
                            string[] headers = { "Producto", "Cantidad", "Precio Unit.", "Subtotal" };
                            foreach (string header in headers)
                            {
                                PdfPCell cHeader = new PdfPCell(new Phrase(header, fontNormalBold));
                                cHeader.BackgroundColor = colorGrisClaro;
                                cHeader.BorderColor = colorBorde;
                                cHeader.Padding = 8f;
                                cHeader.HorizontalAlignment = Element.ALIGN_CENTER;
                                tablaProducto.AddCell(cHeader);
                            }

                            // Fila del producto
                            PdfPCell cProducto = new PdfPCell(new Phrase($"{marca} {producto}", fontNormal));
                            cProducto.BorderColor = colorBorde;
                            cProducto.Padding = 8f;
                            tablaProducto.AddCell(cProducto);

                            PdfPCell cCantidad = new PdfPCell(new Phrase(cantidad.ToString(), fontNormal));
                            cCantidad.BorderColor = colorBorde;
                            cCantidad.Padding = 8f;
                            cCantidad.HorizontalAlignment = Element.ALIGN_CENTER;
                            tablaProducto.AddCell(cCantidad);

                            PdfPCell cPrecio = new PdfPCell(new Phrase($"${precioVenta:N2}", fontNormal));
                            cPrecio.BorderColor = colorBorde;
                            cPrecio.Padding = 8f;
                            cPrecio.HorizontalAlignment = Element.ALIGN_RIGHT;
                            tablaProducto.AddCell(cPrecio);

                            PdfPCell cSubtotal = new PdfPCell(new Phrase($"${total:N2}", fontNormal));
                            cSubtotal.BorderColor = colorBorde;
                            cSubtotal.Padding = 8f;
                            cSubtotal.HorizontalAlignment = Element.ALIGN_RIGHT;
                            tablaProducto.AddCell(cSubtotal);

                            documento.Add(tablaProducto);

                            // --- Total ---
                            PdfPTable tablaTotal = new PdfPTable(2);
                            tablaTotal.WidthPercentage = 100;
                            tablaTotal.SetWidths(new float[] { 80f, 20f });
                            tablaTotal.SpacingBefore = 5f;

                            PdfPCell cTotalLabel = new PdfPCell(new Phrase("TOTAL", fontTotal));
                            cTotalLabel.Border = Rectangle.NO_BORDER;
                            cTotalLabel.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cTotalLabel.Padding = 8f;
                            tablaTotal.AddCell(cTotalLabel);

                            PdfPCell cTotalValor = new PdfPCell(new Phrase($"${total:N2}", fontTotal));
                            cTotalValor.Border = Rectangle.NO_BORDER;
                            cTotalValor.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cTotalValor.Padding = 8f;
                            tablaTotal.AddCell(cTotalValor);

                            documento.Add(tablaTotal);

                            // --- Observaciones ---
                            if (!string.IsNullOrWhiteSpace(detalles))
                            {
                                documento.Add(new Paragraph("\n"));
                                Paragraph pObs = new Paragraph("Observaciones:", fontNormalBold);
                                pObs.SpacingAfter = 5f;
                                documento.Add(pObs);
                                documento.Add(new Paragraph(detalles, fontNormal));
                            }

                            documento.Add(new Paragraph("\n\n"));

                            // --- Pie de página ---
                            Paragraph mensajeFinal = new Paragraph(
                                "Esperamos que disfrutes tu compra. ¡Gracias por elegir AllphoneSF!", fontItalic);
                            mensajeFinal.Alignment = Element.ALIGN_CENTER;
                            documento.Add(mensajeFinal);

                            Paragraph comprobante = new Paragraph(
                                "Este comprobante no es válido como factura.", fontPeque);
                            comprobante.Alignment = Element.ALIGN_CENTER;
                            comprobante.SpacingBefore = 10f;
                            documento.Add(comprobante);

                            documento.Close();
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
