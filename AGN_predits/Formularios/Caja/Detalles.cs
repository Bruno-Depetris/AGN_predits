using AGN_predits.Conexiones.BD.Logica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AGN_predits.Formularios.Caja {
    public partial class Detalles : Form {
        public Detalles() {
            InitializeComponent();
            this.Load += Detalles_Load;
        }

        private async void Detalles_Load(object sender, EventArgs e) {
            try {
                // Crear DataGridView dinámico para movimientos
                DataGridView dgv = new DataGridView();
                dgv.Location = new Point(14, 14);
                dgv.Size = new Size(770, 220);
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.ReadOnly = true;
                dgv.RowHeadersVisible = false;
                dgv.BorderStyle = BorderStyle.None;
                dgv.BackgroundColor = Color.White;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgv.GridColor = Color.FromArgb(230, 230, 230);

                dgv.Columns.Add("ID", "#");
                dgv.Columns.Add("Tipo", "Tipo");
                dgv.Columns.Add("Monto", "Monto");
                dgv.Columns.Add("Medio", "Medio");
                dgv.Columns.Add("Motivo", "Motivo");
                dgv.Columns.Add("Responsable", "Responsable");
                dgv.Columns.Add("Fecha", "Fecha");

                dgv.Columns["ID"].Width = 40;
                dgv.Columns["Tipo"].Width = 70;
                dgv.Columns["Monto"].Width = 90;
                dgv.Columns["Medio"].Width = 100;
                dgv.Columns["Motivo"].Width = 160;
                dgv.Columns["Responsable"].Width = 120;
                dgv.Columns["Fecha"].Width = 130;

                var movimientos = await LogicaCaja.Instancia.ListarMovimientos();
                foreach (var m in movimientos) {
                    int idx = dgv.Rows.Add(m.MovimientoID, m.Tipo, $"${m.Monto:N2}",
                        m.MedioPago, m.Motivo, m.Responsable, m.Fecha.ToString("dd/MM/yy HH:mm"));
                    if (m.Tipo == "Egreso") {
                        dgv.Rows[idx].DefaultCellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                    } else {
                        dgv.Rows[idx].DefaultCellStyle.ForeColor = Color.FromArgb(5, 150, 105);
                    }
                }

                this.Controls.Add(dgv);

                // Label título movimientos
                Label lblMov = new Label();
                lblMov.Text = "HISTORIAL DE MOVIMIENTOS";
                lblMov.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                lblMov.ForeColor = Color.FromArgb(15, 23, 42);
                lblMov.Location = new Point(14, -2);
                lblMov.AutoSize = true;
                this.Controls.Add(lblMov);
                lblMov.BringToFront();

                // DataGridView para cierres
                Label lblCierres = new Label();
                lblCierres.Text = "HISTORIAL DE CIERRES";
                lblCierres.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                lblCierres.ForeColor = Color.FromArgb(15, 23, 42);
                lblCierres.Location = new Point(14, 242);
                lblCierres.AutoSize = true;
                this.Controls.Add(lblCierres);

                DataGridView dgvC = new DataGridView();
                dgvC.Location = new Point(14, 260);
                dgvC.Size = new Size(770, 170);
                dgvC.AllowUserToAddRows = false;
                dgvC.ReadOnly = true;
                dgvC.RowHeadersVisible = false;
                dgvC.BorderStyle = BorderStyle.None;
                dgvC.BackgroundColor = Color.White;
                dgvC.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
                dgvC.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                dgvC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 64, 175);
                dgvC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvC.EnableHeadersVisualStyles = false;
                dgvC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvC.GridColor = Color.FromArgb(230, 230, 230);

                dgvC.Columns.Add("ID", "#");
                dgvC.Columns.Add("Transf", "Transferencias");
                dgvC.Columns.Add("Efect", "Efectivo");
                dgvC.Columns.Add("Tarj", "Tarjetas");
                dgvC.Columns.Add("Crypto", "Crypto");
                dgvC.Columns.Add("Total", "Total");
                dgvC.Columns.Add("Fecha", "Fecha");

                dgvC.Columns["ID"].Width = 40;
                dgvC.Columns["Transf"].Width = 110;
                dgvC.Columns["Efect"].Width = 100;
                dgvC.Columns["Tarj"].Width = 100;
                dgvC.Columns["Crypto"].Width = 90;
                dgvC.Columns["Total"].Width = 100;
                dgvC.Columns["Fecha"].Width = 130;

                var cierres = await LogicaCaja.Instancia.ListarCierres();
                foreach (var c in cierres) {
                    decimal total = c.Transferencias + c.Efectivo + c.Tarjetas + c.Crypto;
                    dgvC.Rows.Add(c.CierreID, $"${c.Transferencias:N2}", $"${c.Efectivo:N2}",
                        $"${c.Tarjetas:N2}", $"${c.Crypto:N2}", $"${total:N2}",
                        c.Fecha.ToString("dd/MM/yy HH:mm"));
                }

                this.Controls.Add(dgvC);

            } catch (Exception ex) {
                MessageBox.Show($"Error cargando detalles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
