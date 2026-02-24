using AGN_predits.Conexiones.BD.Modelo;
using Lam7ara.Conexiones.BD;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AGN_predits.Conexiones.BD.Logica
{

    internal class LogicaProducto
    {
        private static LogicaProducto _LogicaProducto;

        public static LogicaProducto Instancia
        {
            get
            {
                if (_LogicaProducto == null)
                {
                    _LogicaProducto = new LogicaProducto();
                }
                return _LogicaProducto;
            }
        }

        public async Task<bool> CargarProducto(Producto prod)
        {
            try
            {
                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {
                    

                    string query = "INSERT INTO Producto (Marca, Modelo, Condicion, Almacenamiento, Bateria, Stock, Email, PrecioCosto, PrecioVenta, descripcion) " +
                                   "VALUES (@Marca, @Modelo, @Condicion, @Almacenamiento, @Bateria, @Stock, @Email, @PrecioCosto, @PrecioVenta, @descripcion)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Marca", prod.Marca);
                        cmd.Parameters.AddWithValue("@Modelo", prod.Modelo);
                        cmd.Parameters.AddWithValue("@Condicion", prod.Condicion);
                        cmd.Parameters.AddWithValue("@Almacenamiento", prod.Almacenamiento);
                        cmd.Parameters.AddWithValue("@Bateria", prod.Bateria);
                        cmd.Parameters.AddWithValue("@Stock", prod.Stock);
                        cmd.Parameters.AddWithValue("@Email", prod.Email);
                        cmd.Parameters.AddWithValue("@PrecioCosto", prod.PrecioCosto);
                        cmd.Parameters.AddWithValue("@PrecioVenta", prod.PrecioVenta);
                        cmd.Parameters.AddWithValue("@descripcion", prod.descripcion);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<List<Producto>> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {
                    

                    string query = "SELECT * FROM Producto";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                var Producto = new Producto
                                {
                                    ProductoID = Convert.ToInt32(reader["ProductoID"]),
                                    Marca = reader["Marca"].ToString(),
                                    Modelo = reader["Modelo"].ToString(),
                                    Condicion = reader["Condicion"].ToString(),
                                    Almacenamiento = Math.Round(Convert.ToDecimal(reader["Almacenamiento"]), 2),
                                    Bateria = Math.Round(Convert.ToDecimal(reader["Bateria"]), 2),
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    Email = reader["Email"].ToString(),
                                    PrecioCosto = Math.Round(Convert.ToDecimal(reader["PrecioCosto"]), 2),
                                    PrecioVenta = Math.Round(Convert.ToDecimal(reader["PrecioVenta"]), 2),
                                    descripcion = reader["descripcion"].ToString()
                                };
                                lista.Add(Producto);
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

        public async Task<bool> EliminarProducto(int id)
        {
            try
            {
                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {
                    

                    string query = "DELETE FROM Producto WHERE ProductoID = @ProductoID";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@ProductoID", id);
                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar producto: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> EditarProducto(Producto prod)
        {
            try
            {
                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {
                    

                    string query = "UPDATE Producto SET Marca = @Marca, Modelo = @Modelo, Condicion = @Condicion, " +
                                    "Almacenamiento = @Almacenamiento, Bateria = @Bateria, Stock = @Stock, " +
                                    "Email = @Email, PrecioCosto = @PrecioCosto, PrecioVenta = @PrecioVenta, descripcion = @Descripcion " +
                                    "WHERE ProductoID = @ProductoID";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Marca", prod.Marca);
                        cmd.Parameters.AddWithValue("@Modelo", prod.Modelo);
                        cmd.Parameters.AddWithValue("@Condicion", prod.Condicion);
                        cmd.Parameters.AddWithValue("@Almacenamiento", prod.Almacenamiento);
                        cmd.Parameters.AddWithValue("@Bateria", prod.Bateria);
                        cmd.Parameters.AddWithValue("@Stock", prod.Stock);
                        cmd.Parameters.AddWithValue("@Email", prod.Email);
                        cmd.Parameters.AddWithValue("@PrecioCosto", prod.PrecioCosto);
                        cmd.Parameters.AddWithValue("@PrecioVenta", prod.PrecioVenta);
                        cmd.Parameters.AddWithValue("@Descripcion", prod.descripcion);
                        cmd.Parameters.AddWithValue("@ProductoID", prod.ProductoID);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar producto: {ex.Message}");
                return false;
            }
        }
    }
}
