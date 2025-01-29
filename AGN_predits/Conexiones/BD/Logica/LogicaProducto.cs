using AGN_predits.Conexiones.BD.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGN_predits.Conexiones.BD.Logica {
    internal class LogicaProducto {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;


        private static LogicaProducto _LogicaProducto;

        public static LogicaProducto Instancia {
            get {
                if (_LogicaProducto == null) {
                    _LogicaProducto = new LogicaProducto();

                }
                return _LogicaProducto;
            }
        }

        public async Task<bool> CargarProducto(Producto prod) {
            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync(); 

                    string query = "INSERT INTO producto (Marca, Modelo, Condicion, Almacenamiento, Bateria, Stock, PrecioCosto, PrecioVenta, descripcion) " +
                                   "VALUES (@Marca,@Modelo,@Condicion,@Almacenamiento,@Bateria,@Stock,@PrecioCosto,@PrecioVenta,@descripcion)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {
                        cmd.Parameters.AddWithValue("@Marca", prod.Marca);
                        cmd.Parameters.AddWithValue("@Modelo", prod.Modelo);
                        cmd.Parameters.AddWithValue("@Condicion", prod.Condicion);
                        cmd.Parameters.AddWithValue("@Almacenamiento", prod.Almacenamiento);
                        cmd.Parameters.AddWithValue("@Bateria", prod.Bateria);
                        cmd.Parameters.AddWithValue("@Stock", prod.Stock);
                        cmd.Parameters.AddWithValue("@PrecioCosto", prod.PrecioCosto);
                        cmd.Parameters.AddWithValue("@PrecioVenta", prod.PrecioVenta);
                        cmd.Parameters.AddWithValue("@descripcion", prod.descripcion);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync(); // Ejecuta de forma asíncrona
                        return filasAfectadas > 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        public async Task<List<Producto>> ListarProductos() {

            List<Producto> lista = new List<Producto>();

            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync(); // Abre la conexión de manera asíncrona

                    string query = "SELECT * FROM producto";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {

                        using (var reader = await cmd.ExecuteReaderAsync()) { 

                            while (await reader.ReadAsync()) {
                                var Producto = new Producto {
                                    ProductoID = Convert.ToInt32(reader["ProductoID"]),
                                    Marca = reader["Marca"].ToString(),
                                    Modelo = reader["Modelo"].ToString(),
                                    Condicion = reader["Condicion"].ToString(),
                                    Almacenamiento = Math.Round(Convert.ToDecimal(reader["Almacenamiento"]), 2),
                                    Bateria = Math.Round(Convert.ToDecimal(reader["Bateria"]), 2),
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    PrecioCosto = Math.Round(Convert.ToDecimal(reader["PrecioCosto"]), 2),
                                    PrecioVenta = Math.Round(Convert.ToDecimal(reader["PrecioVenta"]), 2),
                                    descripcion = reader["descripcion"].ToString()
                                };
                                lista.Add(Producto);
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
        public async Task<bool> EliminarProducto(int id) {
            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {

                    string query = "DELETE FROM Productos WHERE ID = @ProductoID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {

                        cmd.Parameters.AddWithValue("@ProductoID", id);
                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            }catch
            (Exception ex) { Console.WriteLine(ex.Message); return false; }

        }
        public async Task<bool> EditarProducto(Producto prod) {
            try {
                using (MySqlConnection conexion = new MySqlConnection(cadena)) {
                    await conexion.OpenAsync();

                    string query = "UPDATE producto SET Marca = @Marca, Modelo = @Modelo, Condicion = @Condicion, " +
                                   "Almacenamiento = @Almacenamiento, Bateria = @Bateria, Stock = @Stock, " +
                                   "PrecioCosto = @PrecioCosto, PrecioVenta = @PrecioVenta, descripcion = @descripcion " +
                                   "WHERE ProductoID = @ProductoID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion)) {
                        cmd.Parameters.AddWithValue("@Marca", prod.Marca);
                        cmd.Parameters.AddWithValue("@Modelo", prod.Modelo);
                        cmd.Parameters.AddWithValue("@Condicion", prod.Condicion);
                        cmd.Parameters.AddWithValue("@Almacenamiento", prod.Almacenamiento);
                        cmd.Parameters.AddWithValue("@Bateria", prod.Bateria);
                        cmd.Parameters.AddWithValue("@Stock", prod.Stock);
                        cmd.Parameters.AddWithValue("@PrecioCosto", prod.PrecioCosto);
                        cmd.Parameters.AddWithValue("@PrecioVenta", prod.PrecioVenta);
                        cmd.Parameters.AddWithValue("@descripcion", prod.descripcion);
                        cmd.Parameters.AddWithValue("@ProductoID", prod.ProductoID);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }


    }

}
