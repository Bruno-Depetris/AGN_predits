using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

using System.IO;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Globalization;
using System.Media;
using AGN_predits.Conexiones.BD.Modelo;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;



namespace AGN_predits.Conexiones.BD.Logica {
    internal class LogicaCliente {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;


        private static LogicaCliente _LogicaCliente;

        public static LogicaCliente Instancia {
            get {
                if (_LogicaCliente == null) {
                    _LogicaCliente = new LogicaCliente();

                }
                return _LogicaCliente;
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

        public async Task<bool> CargarCliente(ClienteMod cli) {
            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync(); // Abre la conexión de manera asíncrona

                    string query = "INSERT INTO clientes (Nombre, Apellido, Dni, Telefono, Gmail) " +
                                   "VALUES (@Nombre, @Apellido, @Dni, @Telefono, @Gmail)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {
                        cmd.Parameters.AddWithValue("@Nombre", cli.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", cli.Apellido);
                        cmd.Parameters.AddWithValue("@Dni", cli.Dni);
                        cmd.Parameters.AddWithValue("@Telefono", cli.Telefono);
                        cmd.Parameters.AddWithValue("@Gmail", cli.Gmail);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync(); // Ejecuta de forma asíncrona
                        return filasAfectadas > 0;
                    }
                }
            } catch (Exception ex) {
                throw new Exception($"Error al cargar el cliente: {ex.Message}");
            }
        }


        public async Task<List<ClienteMod>> ListarClientesAsync() {
            List<ClienteMod> lista = new List<ClienteMod>();

            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync(); // Abre la conexión de manera asíncrona

                    string query = "SELECT * FROM clientes";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {

                        using (var reader = await cmd.ExecuteReaderAsync()) { // Ejecuta la consulta de forma asíncrona
                            while (await reader.ReadAsync()) { // Itera de forma asíncrona
                                var cliente = new ClienteMod {
                                    ClienteID = Convert.ToInt32(reader["ClienteID"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Dni = reader["Dni"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Gmail = reader["Gmail"].ToString(),
                                };
                                lista.Add(cliente);
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

        public async Task<bool> EditarCliente(ClienteMod cli) {
            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync();

                    string query = "UPDATE clientes SET Nombre = @Nombre, Apellido = @Apellido, Dni = @Dni, " +
                                   "Telefono = @Telefono, Gmail = @Gmail WHERE ClienteID = @ClienteID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {
                        cmd.Parameters.AddWithValue("@Nombre", cli.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", cli.Apellido);
                        cmd.Parameters.AddWithValue("@Dni", cli.Dni);
                        cmd.Parameters.AddWithValue("@Telefono", cli.Telefono);
                        cmd.Parameters.AddWithValue("@Gmail", cli.Gmail);
                        cmd.Parameters.AddWithValue("@ClienteID", cli.ClienteID);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error al editar el cliente: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> EliminarCliente(int id) {
            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync();

                    string query = "DELETE FROM clientes WHERE ClienteID = @ClienteID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {
                        cmd.Parameters.AddWithValue("@ClienteID", id);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error al eliminar el cliente: {ex.Message}");
                return false;
            }
        }


    }
}
