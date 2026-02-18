using AGN_predits.Conexiones.BD.Modelo;
using Lam7ara.Conexiones.BD;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AGN_predits.Conexiones.BD.Logica {
    internal class LogicaCaja {
        private static LogicaCaja _instancia;
        public static LogicaCaja Instancia {
            get {
                if (_instancia == null) _instancia = new LogicaCaja();
                return _instancia;
            }
        }

        // ═══════════════════════════════════════════════
        // APERTURA DE CAJA
        // ═══════════════════════════════════════════════
        public async Task<bool> AbrirCaja(decimal monto) {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "INSERT INTO Caja (Fecha, Monto) VALUES (@Fecha, @Monto)";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@Monto", monto);
                        return await cmd.ExecuteNonQueryAsync() > 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error al abrir caja: {ex.Message}");
                return false;
            }
        }

        public async Task<Caja> ObtenerUltimaApertura() {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "SELECT * FROM Caja ORDER BY AperturaID DESC LIMIT 1";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            if (await reader.ReadAsync()) {
                                return new Caja {
                                    AperturaID = Convert.ToInt32(reader["AperturaID"]),
                                    Fecha = DateTime.Parse(reader["Fecha"].ToString()),
                                    Monto = Convert.ToDecimal(reader["Monto"])
                                };
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        // ═══════════════════════════════════════════════
        // CIERRE DE CAJA
        // ═══════════════════════════════════════════════
        public async Task<bool> CerrarCaja(Cierre cierre) {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "INSERT INTO Cierre (Transferencias, Efectivo, Tarjetas, Crypto, Fecha) " +
                               "VALUES (@Transferencias, @Efectivo, @Tarjetas, @Crypto, @Fecha)";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        cmd.Parameters.AddWithValue("@Transferencias", cierre.Transferencias);
                        cmd.Parameters.AddWithValue("@Efectivo", cierre.Efectivo);
                        cmd.Parameters.AddWithValue("@Tarjetas", cierre.Tarjetas);
                        cmd.Parameters.AddWithValue("@Crypto", cierre.Crypto);
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        return await cmd.ExecuteNonQueryAsync() > 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error al cerrar caja: {ex.Message}");
                return false;
            }
        }

        public async Task<Cierre> ObtenerUltimoCierre() {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "SELECT * FROM Cierre ORDER BY CierreID DESC LIMIT 1";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            if (await reader.ReadAsync()) {
                                return new Cierre {
                                    CierreID = Convert.ToInt32(reader["CierreID"]),
                                    Transferencias = Convert.ToDecimal(reader["Transferencias"]),
                                    Efectivo = Convert.ToDecimal(reader["Efectivo"]),
                                    Tarjetas = Convert.ToDecimal(reader["Tarjetas"]),
                                    Crypto = Convert.ToDecimal(reader["Crypto"]),
                                    Fecha = DateTime.Parse(reader["Fecha"].ToString())
                                };
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }

        public async Task<List<Cierre>> ListarCierres() {
            List<Cierre> lista = new List<Cierre>();
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "SELECT * FROM Cierre ORDER BY CierreID DESC";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            while (await reader.ReadAsync()) {
                                lista.Add(new Cierre {
                                    CierreID = Convert.ToInt32(reader["CierreID"]),
                                    Transferencias = Convert.ToDecimal(reader["Transferencias"]),
                                    Efectivo = Convert.ToDecimal(reader["Efectivo"]),
                                    Tarjetas = Convert.ToDecimal(reader["Tarjetas"]),
                                    Crypto = Convert.ToDecimal(reader["Crypto"]),
                                    Fecha = DateTime.Parse(reader["Fecha"].ToString())
                                });
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return lista;
        }

        // ═══════════════════════════════════════════════
        // MOVIMIENTOS DE CAJA
        // ═══════════════════════════════════════════════
        public async Task<bool> CargarMovimiento(MovimientoCaja mov) {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "INSERT INTO MovimientoCaja (Tipo, Monto, MedioPago, Motivo, Responsable, Fecha) " +
                               "VALUES (@Tipo, @Monto, @MedioPago, @Motivo, @Responsable, @Fecha)";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        cmd.Parameters.AddWithValue("@Tipo", mov.Tipo);
                        cmd.Parameters.AddWithValue("@Monto", mov.Monto);
                        cmd.Parameters.AddWithValue("@MedioPago", mov.MedioPago);
                        cmd.Parameters.AddWithValue("@Motivo", mov.Motivo);
                        cmd.Parameters.AddWithValue("@Responsable", mov.Responsable);
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        return await cmd.ExecuteNonQueryAsync() > 0;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error al cargar movimiento: {ex.Message}");
                return false;
            }
        }

        public async Task<List<MovimientoCaja>> ListarMovimientos() {
            List<MovimientoCaja> lista = new List<MovimientoCaja>();
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "SELECT * FROM MovimientoCaja ORDER BY MovimientoID DESC";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            while (await reader.ReadAsync()) {
                                lista.Add(new MovimientoCaja {
                                    MovimientoID = Convert.ToInt32(reader["MovimientoID"]),
                                    Tipo = reader["Tipo"].ToString(),
                                    Monto = Convert.ToDecimal(reader["Monto"]),
                                    MedioPago = reader["MedioPago"].ToString(),
                                    Motivo = reader["Motivo"].ToString(),
                                    Responsable = reader["Responsable"].ToString(),
                                    Fecha = DateTime.Parse(reader["Fecha"].ToString())
                                });
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return lista;
        }

        public async Task<List<MovimientoCaja>> ListarMovimientosDesde(DateTime desde) {
            List<MovimientoCaja> lista = new List<MovimientoCaja>();
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "SELECT * FROM MovimientoCaja WHERE Fecha >= @Desde ORDER BY MovimientoID DESC";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        cmd.Parameters.AddWithValue("@Desde", desde.ToString("yyyy-MM-dd HH:mm:ss"));
                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            while (await reader.ReadAsync()) {
                                lista.Add(new MovimientoCaja {
                                    MovimientoID = Convert.ToInt32(reader["MovimientoID"]),
                                    Tipo = reader["Tipo"].ToString(),
                                    Monto = Convert.ToDecimal(reader["Monto"]),
                                    MedioPago = reader["MedioPago"].ToString(),
                                    Motivo = reader["Motivo"].ToString(),
                                    Responsable = reader["Responsable"].ToString(),
                                    Fecha = DateTime.Parse(reader["Fecha"].ToString())
                                });
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return lista;
        }

        // ═══════════════════════════════════════════════
        // RESUMEN (para el panel Caja)
        // ═══════════════════════════════════════════════
        public async Task<decimal> ObtenerTotalIngresos(DateTime desde) {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "SELECT COALESCE(SUM(Monto),0) FROM MovimientoCaja WHERE Tipo='Ingreso' AND Fecha >= @Desde";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        cmd.Parameters.AddWithValue("@Desde", desde.ToString("yyyy-MM-dd HH:mm:ss"));
                        var result = await cmd.ExecuteScalarAsync();
                        return Convert.ToDecimal(result);
                    }
                }
            } catch { return 0; }
        }

        public async Task<decimal> ObtenerTotalEgresos(DateTime desde) {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "SELECT COALESCE(SUM(Monto),0) FROM MovimientoCaja WHERE Tipo='Egreso' AND Fecha >= @Desde";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        cmd.Parameters.AddWithValue("@Desde", desde.ToString("yyyy-MM-dd HH:mm:ss"));
                        var result = await cmd.ExecuteScalarAsync();
                        return Convert.ToDecimal(result);
                    }
                }
            } catch { return 0; }
        }

        public async Task<int> ObtenerCantidadMovimientos(DateTime desde) {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "SELECT COUNT(*) FROM MovimientoCaja WHERE Fecha >= @Desde";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        cmd.Parameters.AddWithValue("@Desde", desde.ToString("yyyy-MM-dd HH:mm:ss"));
                        var result = await cmd.ExecuteScalarAsync();
                        return Convert.ToInt32(result);
                    }
                }
            } catch { return 0; }
        }
    }
}
