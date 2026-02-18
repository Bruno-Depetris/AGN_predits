using AGN_predits.Conexiones.BD.Logica;
using AGN_predits.Notificaciones;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGN_predits.Formularios.Caja {
    public partial class Caja : Form {
        public Caja() {
            InitializeComponent();
        }

        private async void Caja_Load(object sender, EventArgs e) {
            await CargarResumen();
        }

        public async Task CargarResumen() {
            try {
                var apertura = await LogicaCaja.Instancia.ObtenerUltimaApertura();
                var cierre = await LogicaCaja.Instancia.ObtenerUltimoCierre();

                bool cajaAbierta = apertura != null && (cierre == null || apertura.Fecha > cierre.Fecha);

                if (cajaAbierta) {
                    label_FechaApertura.Text = apertura.Fecha.ToString("dd/MM/yy HH:mm");

                    DateTime desde = apertura.Fecha;
                    int cantMov = await LogicaCaja.Instancia.ObtenerCantidadMovimientos(desde);
                    decimal ingresos = await LogicaCaja.Instancia.ObtenerTotalIngresos(desde);
                    decimal egresos = await LogicaCaja.Instancia.ObtenerTotalEgresos(desde);
                    int prodVendidos = await LogicaDashboard.Instancia.VentasProductosHoy();

                    label3.Text = $"Productos vendidos: {prodVendidos}";
                    label4.Text = $"Cantidad de movimientos: {cantMov}";
                    label5.Text = $"Egresos: ${egresos:N2}";
                    label6.Text = $"Ingresos: ${ingresos:N2}";

                    materialButton_AbirirCaja.Enabled = false;
                    materialButton_AbirirCaja.Text = "Caja abierta";
                    materialButton1.Enabled = true;
                    materialButton_Movimiento.Enabled = true;
                } else {
                    label_FechaApertura.Text = "Sin apertura";
                    label3.Text = "Productos vendidos: -";
                    label4.Text = "Cantidad de movimientos: -";
                    label5.Text = "Egresos: $-";
                    label6.Text = "Ingresos: $-";

                    materialButton_AbirirCaja.Enabled = true;
                    materialButton_AbirirCaja.Text = "Abrir Caja";
                    materialButton1.Enabled = false;
                    materialButton_Movimiento.Enabled = false;
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error cargando resumen: {ex.Message}");
            }
        }

        private void materialButton_AbirirCaja_Click(object sender, EventArgs e) {
            AbrirCaja form = new AbrirCaja(this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e) {
            CerrarCaja form = new CerrarCaja(this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void materialButton_Movimiento_Click(object sender, EventArgs e) {
            Movimiento form = new Movimiento(this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void materialButton_DetallesDiarios_Click(object sender, EventArgs e) {
            Detalles form = new Detalles();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
