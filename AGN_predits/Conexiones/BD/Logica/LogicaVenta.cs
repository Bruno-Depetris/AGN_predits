using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AGN_predits.Conexiones.BD.Modelo;

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

        public async Task<bool> ImprimirDetalleVenta(DetalleVenta detalle) {
            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync(); // Abre la conexión de manera asíncrona

                    string query = "INSERT INTO detalle_venta (Fecha, ClienteID, ProductoID, MedioPagoID) " +
                                   "VALUES (@Fecha, @ClienteID, @ProductoID, @MedioPagoID)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {
                        cmd.Parameters.AddWithValue("@Fecha", detalle.Fecha);
                        cmd.Parameters.AddWithValue("@ClienteID", detalle.ClienteID);
                        cmd.Parameters.AddWithValue("@ProductoID", detalle.ProductoID);
                        cmd.Parameters.AddWithValue("@MedioPagoID", detalle.MedioPagoID);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync(); // Ejecuta de forma asíncrona
                        return filasAfectadas > 0;
                    }
                }
            } catch (Exception ex) {
                throw new Exception($"Error al imprimir el detalle de la venta: {ex.Message}");
            }
        }

        public async Task<List<DetalleVenta>> ListarDetallesVentaAsync() {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync(); // Abre la conexión de manera asíncrona

                    string query = "SELECT * FROM detalle_venta";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {

                        using (var reader = await cmd.ExecuteReaderAsync()) { // Ejecuta la consulta de forma asíncrona
                            while (await reader.ReadAsync()) { // Itera de forma asíncrona
                                var detalleVenta = new DetalleVenta {
                                    DetalleVentaID = Convert.ToInt32(reader["DetalleVentaID"]),
                                    Fecha = Convert.ToDateTime(reader["Fecha"]),
                                    ClienteID = Convert.ToInt32(reader["ClienteID"]),
                                    ProductoID = Convert.ToInt32(reader["ProductoID"]),
                                    MedioPagoID = Convert.ToInt32(reader["MedioPagoID"])
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

                    string query = "DELETE FROM detalle_venta WHERE DetalleVentaID = @DetalleVentaID";

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
    }
}
