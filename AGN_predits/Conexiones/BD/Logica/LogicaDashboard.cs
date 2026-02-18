using Lam7ara.Conexiones.BD;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AGN_predits.Conexiones.BD.Logica {
    internal class LogicaDashboard {
        private static LogicaDashboard _instancia;
        public static LogicaDashboard Instancia {
            get {
                if (_instancia == null) _instancia = new LogicaDashboard();
                return _instancia;
            }
        }

        // ═══════════════════════════════════════════════
        // VENTAS
        // ═══════════════════════════════════════════════
        public async Task<int> VentasHoy() {
            return await ContarVentas("date(Fecha) = date('now','localtime')");
        }

        public async Task<int> VentasMes() {
            return await ContarVentas("strftime('%Y-%m', Fecha) = strftime('%Y-%m', 'now','localtime')");
        }

        public async Task<decimal> IngresoHoy() {
            return await SumarIngresos("date(Fecha) = date('now','localtime')");
        }

        public async Task<decimal> IngresoMes() {
            return await SumarIngresos("strftime('%Y-%m', Fecha) = strftime('%Y-%m', 'now','localtime')");
        }

        private async Task<int> ContarVentas(string where) {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = $"SELECT COUNT(*) FROM DetalleVenta WHERE {where}";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        var r = await cmd.ExecuteScalarAsync();
                        return Convert.ToInt32(r);
                    }
                }
            } catch { return 0; }
        }

        private async Task<decimal> SumarIngresos(string where) {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = $@"SELECT COALESCE(SUM(p.PrecioVenta * dv.Cantidad), 0)
                                  FROM DetalleVenta dv
                                  JOIN Producto p ON dv.ProductoID = p.ProductoID
                                  WHERE {where}";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        var r = await cmd.ExecuteScalarAsync();
                        return Convert.ToDecimal(r);
                    }
                }
            } catch { return 0; }
        }

        // ═══════════════════════════════════════════════
        // STOCK
        // ═══════════════════════════════════════════════
        public async Task<int> TotalProductos() {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Producto", con)) {
                        return Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            } catch { return 0; }
        }

        public async Task<int> ProductosSinStock() {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Producto WHERE Stock = 0", con)) {
                        return Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            } catch { return 0; }
        }

        public async Task<int> ProductosStockBajo(int umbral = 3) {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    using (SQLiteCommand cmd = new SQLiteCommand($"SELECT COUNT(*) FROM Producto WHERE Stock > 0 AND Stock <= {umbral}", con)) {
                        return Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            } catch { return 0; }
        }

        public async Task<int> ProductosStockOk(int umbral = 3) {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    using (SQLiteCommand cmd = new SQLiteCommand($"SELECT COUNT(*) FROM Producto WHERE Stock > {umbral}", con)) {
                        return Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            } catch { return 0; }
        }

        // ═══════════════════════════════════════════════
        // INVERSIÓN
        // ═══════════════════════════════════════════════
        public async Task<decimal> InversionTotal() {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT COALESCE(SUM(PrecioCosto * Stock), 0) FROM Producto", con)) {
                        return Convert.ToDecimal(await cmd.ExecuteScalarAsync());
                    }
                }
            } catch { return 0; }
        }

        // ═══════════════════════════════════════════════
        // CLIENTES
        // ═══════════════════════════════════════════════
        public async Task<int> TotalClientes() {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Cliente", con)) {
                        return Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            } catch { return 0; }
        }

        // ═══════════════════════════════════════════════
        // ÚLTIMAS VENTAS (top 10)
        // ═══════════════════════════════════════════════
        public async Task<List<UltimaVentaDTO>> UltimasVentas(int top = 10) {
            List<UltimaVentaDTO> lista = new List<UltimaVentaDTO>();
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = $@"
                        SELECT dv.DetalleVentaID, dv.Fecha,
                               COALESCE(c.Nombre || ' ' || c.Apellido, 'N/A') AS ClienteNombre,
                               COALESCE(p.Marca || ' ' || p.Modelo, 'N/A') AS ProductoNombre,
                               COALESCE(p.PrecioVenta * dv.Cantidad, 0) AS Total,
                               COALESCE(mp.Mediopago, 'N/A') AS MedioPago,
                               dv.Cantidad
                        FROM DetalleVenta dv
                        LEFT JOIN Cliente c ON dv.ClienteID = c.ClienteID
                        LEFT JOIN Producto p ON dv.ProductoID = p.ProductoID
                        LEFT JOIN MedioPago mp ON dv.MedioPagoID = mp.MediosPagoID
                        ORDER BY dv.DetalleVentaID DESC
                        LIMIT {top}";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            while (await reader.ReadAsync()) {
                                lista.Add(new UltimaVentaDTO {
                                    ID = Convert.ToInt32(reader["DetalleVentaID"]),
                                    Fecha = reader["Fecha"].ToString(),
                                    Cliente = reader["ClienteNombre"].ToString(),
                                    Producto = reader["ProductoNombre"].ToString(),
                                    Total = Convert.ToDecimal(reader["Total"]),
                                    MedioPago = reader["MedioPago"].ToString(),
                                    Cantidad = Convert.ToInt32(reader["Cantidad"])
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
        // VENTAS POR DÍA (última semana para chart)
        // ═══════════════════════════════════════════════
        public async Task<int> VentasProductosHoy() {
            try {
                using (SQLiteConnection con = Conectar.ObtenerConexion()) {
                    string q = "SELECT COALESCE(SUM(Cantidad),0) FROM DetalleVenta WHERE date(Fecha) = date('now','localtime')";
                    using (SQLiteCommand cmd = new SQLiteCommand(q, con)) {
                        return Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            } catch { return 0; }
        }
    }

    // DTO para últimas ventas
    internal class UltimaVentaDTO {
        public int ID { get; set; }
        public string Fecha { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public decimal Total { get; set; }
        public string MedioPago { get; set; }
        public int Cantidad { get; set; }
    }
}
