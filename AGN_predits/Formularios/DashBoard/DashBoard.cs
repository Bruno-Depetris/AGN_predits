using AGN_predits.Conexiones.BD.Logica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheParfum.APIs.Logicas;
using TheParfum.APIs.Modelos;

namespace AGN_predits.Formularios.DashBoard
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private async void DashBoard_Load(object sender, EventArgs e)
        {
            label_Fecha.Text = $"Panel de Control  •  {DateTime.Now:dddd dd/MM/yyyy}";
            await Task.WhenAll(
                CargarKPIs(),
                CargarInversion(),
                CargarCotizaciones(),
                CargarUltimasVentas(),
                CargarAlertasStock(),
                CargarEstadoCaja()
            );
        }

        private async Task CargarKPIs()
        {
            try
            {
                var d = LogicaDashboard.Instancia;
                int vH = await d.VentasHoy(); decimal iH = await d.IngresoHoy();
                label_KPI_VentasHoy_Valor.Text = vH.ToString();
                label_KPI_VentasHoy_Sub.Text = $"${iH:N0}";

                int vM = await d.VentasMes(); decimal iM = await d.IngresoMes();
                label_KPI_VentasMes_Valor.Text = vM.ToString();
                label_KPI_VentasMes_Sub.Text = $"${iM:N0}";

                int tP = await d.TotalProductos(); int sB = await d.ProductosStockBajo();
                label_KPI_Stock_Valor.Text = tP.ToString();
                label_KPI_Stock_Sub.Text = sB > 0 ? $"{sB} stock bajo" : "Stock OK";

                int tC = await d.TotalClientes();
                label_KPI_Clientes_Valor.Text = tC.ToString();
                label_KPI_Clientes_Sub.Text = "Registrados";
            }
            catch (Exception ex) { Console.WriteLine($"KPI Error: {ex.Message}"); }
        }

        private async Task CargarInversion()
        {
            try
            {
                decimal inv = await LogicaDashboard.Instancia.InversionTotal();
                label_Inversion_Valor.Text = $"${inv:N0}";
            }
            catch { label_Inversion_Valor.Text = "$0"; }
        }

        private async Task CargarCotizaciones()
        {
            try
            {
                using (var api = new ApiCotizacion("https://dolarapi.com/v1/dolares"))
                {
                    string resp = await api.GetAsync("https://dolarapi.com/v1/dolares");
                    var cot = JsonConvert.DeserializeObject<List<ModeloApiCotizacion>>(resp);
                    var of = cot.FirstOrDefault(c => c.Casa == "oficial");
                    var bl = cot.FirstOrDefault(c => c.Casa == "blue");
                    var ta = cot.FirstOrDefault(c => c.Casa == "tarjeta");
                    if (of != null) label_DolarOficial_Valor.Text = $"${of.Venta:N0}";
                    if (bl != null) label_DolarBlue_Valor.Text = $"${bl.Venta:N0}";
                    if (ta != null) label_DolarTarjeta_Valor.Text = $"${ta.Venta:N0}";
                }
            }
            catch
            {
                label_DolarOficial_Valor.Text = "Sin datos";
                label_DolarBlue_Valor.Text = "Sin datos";
                label_DolarTarjeta_Valor.Text = "Sin datos";
            }
        }

        private async Task CargarUltimasVentas()
        {
            try
            {
                var ventas = await LogicaDashboard.Instancia.UltimasVentas(8);
                dgv_UltimasVentas.Columns.Clear();
                dgv_UltimasVentas.Columns.Add("ID", "#");
                dgv_UltimasVentas.Columns.Add("Cliente", "Cliente");
                dgv_UltimasVentas.Columns.Add("Producto", "Producto");
                dgv_UltimasVentas.Columns.Add("Total", "Total");
                dgv_UltimasVentas.Columns.Add("Medio", "Medio");
                dgv_UltimasVentas.Columns.Add("Fecha", "Fecha");
                dgv_UltimasVentas.Columns["ID"].Width = 35;
                dgv_UltimasVentas.Columns["Cliente"].Width = 100;
                dgv_UltimasVentas.Columns["Producto"].Width = 110;
                dgv_UltimasVentas.Columns["Total"].Width = 70;
                dgv_UltimasVentas.Columns["Medio"].Width = 75;
                dgv_UltimasVentas.Columns["Fecha"].Width = 70;
                dgv_UltimasVentas.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dgv_UltimasVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
                dgv_UltimasVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
                dgv_UltimasVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_UltimasVentas.EnableHeadersVisualStyles = false;
                dgv_UltimasVentas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255);
                dgv_UltimasVentas.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgv_UltimasVentas.Rows.Clear();
                foreach (var v in ventas)
                {
                    string fc = DateTime.TryParse(v.Fecha, out DateTime dt) ? dt.ToString("dd/MM HH:mm") : v.Fecha;
                    dgv_UltimasVentas.Rows.Add(v.ID, v.Cliente, v.Producto, $"${v.Total:N0}", v.MedioPago, fc);
                }
            }
            catch (Exception ex) { Console.WriteLine($"Ventas Error: {ex.Message}"); }
        }

        private async Task CargarAlertasStock()
        {
            try
            {
                var d = LogicaDashboard.Instancia;
                label_SinStock_Valor.Text = (await d.ProductosSinStock()).ToString();
                label_StockBajo_Valor.Text = (await d.ProductosStockBajo()).ToString();
                label_StockOk_Valor.Text = (await d.ProductosStockOk()).ToString();
            }
            catch
            {
                label_SinStock_Valor.Text = "0";
                label_StockBajo_Valor.Text = "0";
                label_StockOk_Valor.Text = "0";
            }
        }

        private async Task CargarEstadoCaja()
        {
            try
            {
                var ap = await LogicaCaja.Instancia.ObtenerUltimaApertura();
                var ci = await LogicaCaja.Instancia.ObtenerUltimoCierre();
                bool abierta = ap != null && (ci == null || ap.Fecha > ci.Fecha);
                if (abierta)
                {
                    label_EstadoCaja.Text = "● CAJA ABIERTA";
                    label_EstadoCaja.ForeColor = Color.FromArgb(16, 185, 129);
                    label_SaldoCaja.Text = $"Apertura: ${ap.Monto:N0}";
                }
                else
                {
                    label_EstadoCaja.Text = "● CAJA CERRADA";
                    label_EstadoCaja.ForeColor = Color.FromArgb(239, 68, 68);
                    label_SaldoCaja.Text = "Sin apertura activa";
                }
            }
            catch
            {
                label_EstadoCaja.Text = "● SIN DATOS";
                label_EstadoCaja.ForeColor = Color.FromArgb(148, 163, 184);
            }
        }
    }
}
