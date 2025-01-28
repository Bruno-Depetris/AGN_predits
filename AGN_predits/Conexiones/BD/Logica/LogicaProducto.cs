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

                    string query = "INSERT INTO clientes (Marca, Modelo, Condicion, Almacenamiento, Bateria, Stock, PrecioCosto, PrecioVenta, descripcion) " +
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
    }

}
