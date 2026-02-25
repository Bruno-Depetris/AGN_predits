using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGN_predits.Conexiones.BD.Modelo;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AGN_predits.Conexiones.BD.Logica
{

    internal class LogicaTecnico
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static LogicaTecnico _LogicaTecnico;

        public static LogicaTecnico Instancia
        {
            get
            {
                if (_LogicaTecnico == null)
                {
                    _LogicaTecnico = new LogicaTecnico();
                }
                return _LogicaTecnico;
            }
        }

        // Método para agregar un técnico
        public async Task<bool> CargarTecnico(TecnicoMod tecnico)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadena))
                {
                    await conexion.OpenAsync();

                    string query = "INSERT INTO Tecnico (Modelo, Marca, Bateria, Falla, Email, Almacenamiento, CostoArreglo, Costo) " +
                                   "VALUES (@Modelo, @Marca, @Bateria, @Falla, @Email, @Almacenamiento, @CostoArreglo, @Costo)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Modelo", tecnico.Modelo);
                        cmd.Parameters.AddWithValue("@Marca", tecnico.Marca);
                        cmd.Parameters.AddWithValue("@Bateria", tecnico.Bateria);
                        cmd.Parameters.AddWithValue("@Falla", tecnico.Falla);
                        cmd.Parameters.AddWithValue("@Email", tecnico.Email);
                        cmd.Parameters.AddWithValue("@Almacenamiento", tecnico.Almacenamiento);
                        cmd.Parameters.AddWithValue("@CostoArreglo", tecnico.CostoArreglo);
                        cmd.Parameters.AddWithValue("@Costo", tecnico.Costo);

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

        // Método para listar todos los técnicos
        public async Task<List<TecnicoMod>> ListarTecnicos()
        {
            List<TecnicoMod> lista = new List<TecnicoMod>();

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadena))
                {
                    await conexion.OpenAsync();

                    string query = "SELECT * FROM Tecnico";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                var tecnico = new TecnicoMod
                                {
                                    TecnicoID = Convert.ToInt32(reader["TecnicoID"]),
                                    Modelo = reader["Modelo"].ToString(),
                                    Marca = reader["Marca"].ToString(),
                                    Bateria = Convert.ToDecimal(reader["Bateria"]),
                                    Falla = reader["Falla"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Almacenamiento = Convert.ToDecimal(reader["Almacenamiento"]),
                                    CostoArreglo = Convert.ToDecimal(reader["CostoArreglo"]),
                                    Costo = Convert.ToDecimal(reader["Costo"])
                                };
                                lista.Add(tecnico);
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

        // Método para eliminar un técnico por ID
        public async Task<bool> EliminarTecnico(int id)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadena))
                {
                    await conexion.OpenAsync();

                    string query = "DELETE FROM Tecnico WHERE TecnicoID = @TecnicoID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@TecnicoID", id);
                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar técnico: {ex.Message}");
                return false;
            }
        }

        // Método para editar un técnico
        public async Task<bool> EditarTecnico(TecnicoMod tecnico)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadena))
                {
                    await conexion.OpenAsync();

                    string query = "UPDATE Tecnico SET Modelo = @Modelo, Marca = @Marca, Bateria = @Bateria, " +
                                    "Falla = @Falla, Email = @Email, Almacenamiento = @Almacenamiento, " +
                                    "CostoArreglo = @CostoArreglo, Costo = @Costo " +
                                    "WHERE TecnicoID = @TecnicoID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Modelo", tecnico.Modelo);
                        cmd.Parameters.AddWithValue("@Marca", tecnico.Marca);
                        cmd.Parameters.AddWithValue("@Bateria", tecnico.Bateria);
                        cmd.Parameters.AddWithValue("@Falla", tecnico.Falla);
                        cmd.Parameters.AddWithValue("@Email", tecnico.Email);
                        cmd.Parameters.AddWithValue("@Almacenamiento", tecnico.Almacenamiento);
                        cmd.Parameters.AddWithValue("@CostoArreglo", tecnico.CostoArreglo);
                        cmd.Parameters.AddWithValue("@Costo", tecnico.Costo);
                        cmd.Parameters.AddWithValue("@TecnicoID", tecnico.TecnicoID);

                        int filasAfectadas = await cmd.ExecuteNonQueryAsync();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar técnico: {ex.Message}");
                return false;
            }
        }
    }
}
