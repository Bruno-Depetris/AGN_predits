using AGN_predits.Conexiones.BD.Modelo;
using Lam7ara.Conexiones.BD;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace AGN_predits.Conexiones.BD.Logica
{
    internal class LogicaCliente
    {

        private static LogicaCliente _LogicaCliente;

        public static LogicaCliente Instancia
        {
            get
            {
                if (_LogicaCliente == null)
                {
                    _LogicaCliente = new LogicaCliente();

                }
                return _LogicaCliente;
            }
        }


        public async Task<bool> CargarCliente(ClienteMod cli)
        {
            try
            {
                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {

                    string query = "INSERT INTO Cliente (Nombre, Apellido, Dni, Telefono, Gmail) " +
                                   "VALUES (@Nombre, @Apellido, @Dni, @Telefono, @Gmail)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", cli.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", cli.Apellido);
                        cmd.Parameters.AddWithValue("@Dni", cli.Dni);
                        cmd.Parameters.AddWithValue("@Telefono", cli.Telefono);
                        cmd.Parameters.AddWithValue("@Gmail", cli.Gmail);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync(); // Ejecuta de forma asíncrona
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar el cliente: {ex.Message}");
            }
        }


        public async Task<List<ClienteMod>> ListarClientesAsync()
        {
            List<ClienteMod> lista = new List<ClienteMod>();

            try
            {
                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {
                     // Abre la conexión de manera asíncrona

                    string query = "SELECT * FROM Cliente";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {

                        using (var reader = await cmd.ExecuteReaderAsync())
                        { // Ejecuta la consulta de forma asíncrona
                            while (await reader.ReadAsync())
                            { // Itera de forma asíncrona
                                var cliente = new ClienteMod
                                {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }

            return lista;
        }

        public async Task<bool> EditarCliente(ClienteMod cli)
        {
            try
            {
                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {
                    

                    string query = "UPDATE Cliente SET Nombre = @Nombre, Apellido = @Apellido, Dni = @Dni, " +
                                   "Telefono = @Telefono, Gmail = @Gmail WHERE ClienteID = @ClienteID";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar el cliente: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> EliminarCliente(int id)
        {
            try
            {
                using (SQLiteConnection conexion = Conectar.ObtenerConexion())
                {
                    

                    string query = "DELETE FROM Cliente WHERE ClienteID = @ClienteID";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@ClienteID", id);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el cliente: {ex.Message}");
                return false;
            }
        }


    }
}
