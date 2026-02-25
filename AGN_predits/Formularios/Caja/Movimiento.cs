using AGN_predits.Conexiones.BD.Logica;
using AGN_predits.Conexiones.BD.Modelo;
using AGN_predits.Notificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGN_predits.Formularios.Caja {
    public partial class Movimiento : Form
    {
        private Caja _formCaja;

        public Movimiento(Caja formCaja)
        {
            InitializeComponent();
            _formCaja = formCaja;
            CargarCombos();
        }

        private void CargarCombos()
        {
            materialComboBox_Movimiento.Items.Clear();
            materialComboBox_Movimiento.Items.Add("Seleccionar");
            materialComboBox_Movimiento.Items.Add("Ingreso");
            materialComboBox_Movimiento.Items.Add("Egreso");
            materialComboBox_Movimiento.SelectedIndex = 0;

            materialComboBox_Medio.Items.Clear();
            materialComboBox_Medio.Items.Add("Seleccionar");
            materialComboBox_Medio.Items.Add("Efectivo");
            materialComboBox_Medio.Items.Add("Transferencia");
            materialComboBox_Medio.Items.Add("Tarjeta");
            materialComboBox_Medio.Items.Add("Crypto");
            materialComboBox_Medio.SelectedIndex = 0;
        }

        private async void materialButton_CargarMovimiento_Click(object sender, EventArgs e)
        {
            Mensaje msj = new Mensaje();

            // Validaciones
            if (materialComboBox_Movimiento.SelectedIndex <= 0)
            {
                msj.Show("Error", "Seleccione tipo de movimiento", Color.Red, Color.White,
                    Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                return;
            }

            if (!decimal.TryParse(materialTextBoxEdit_Monto.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal monto) || monto <= 0)
            {
                msj.Show("Error", "Ingrese un monto válido", Color.Red, Color.White,
                    Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                materialTextBoxEdit_Monto.Focus();
                return;
            }

            if (string.IsNullOrEmpty(materialTextBoxEdit_Responsable.Text))
            {
                msj.Show("Error", "Ingrese un responsable", Color.Red, Color.White,
                    Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Intermedio);
                materialTextBoxEdit_Responsable.Focus();
                return;
            }

            if (materialComboBox_Medio.SelectedIndex <= 0)
            {
                msj.Show("Error", "Seleccione medio de pago", Color.Red, Color.White,
                    Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                return;
            }

            string motivo = string.IsNullOrEmpty(materialTextBoxEdit_Motivo.Text)
                ? "Sin especificar"
                : materialTextBoxEdit_Motivo.Text;

            MovimientoCaja mov = new MovimientoCaja
            {
                Tipo = materialComboBox_Movimiento.SelectedItem.ToString(),
                Monto = monto,
                MedioPago = materialComboBox_Medio.SelectedItem.ToString(),
                Motivo = motivo,
                Responsable = materialTextBoxEdit_Responsable.Text
            };

            if (await LogicaCaja.Instancia.CargarMovimiento(mov))
            {
                string icon = mov.Tipo == "Ingreso" ? "Cash" : "Ok";
                msj.Show($"{mov.Tipo}", $"${monto:N2} - {mov.MedioPago}", Color.Green, Color.White,
                    mov.Tipo == "Ingreso" ? Mensaje.TipoIcono.Cash : Mensaje.TipoIcono.Ok,
                    Mensaje.TipoSonido.Money);

                await _formCaja.CargarResumen();
                this.Close();
            }
            else
            {
                msj.Show("Error", "No se pudo cargar el movimiento", Color.Red, Color.White,
                    Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
            }
        }
    }
}
