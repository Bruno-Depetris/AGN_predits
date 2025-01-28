using AGN_predits.Formularios.Vender;
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

namespace AGN_predits.Formularios {
    public partial class Venta : Form {
        public Venta() {
            InitializeComponent();
            VerificarProgreso();
            materialComboBox_SeleccionCliente.Items.Insert(0,"Seleccionar");
            materialComboBox_SeleccionCliente.SelectedIndex = 0;

            materialComboBox_SelectProducto.Items.Insert(0, "Seleccionar");
            materialComboBox_SelectProducto.SelectedIndex = 0;

            materialComboBox_FormasPago.Items.Insert(0, "Seleccionar");
            materialComboBox_FormasPago.SelectedIndex = 0;

            materialComboBox_Cuotas.Items.Insert(0, "Seleccionar");
            materialComboBox_Cuotas.SelectedIndex = 0;

            materialComboBox_Cantidad.Items.Insert(0, "Seleccionar");
            materialComboBox_Cantidad.SelectedIndex = 0;
        }



        private bool Validaciones() {
            Mensaje mensaje = new Mensaje();
            if (materialComboBox_SeleccionCliente.SelectedIndex == 0) {
                materialComboBox_SeleccionCliente.SelectedIndex = 0;
                materialComboBox_SeleccionCliente.Focus();
                mensaje.Show("Error","Selecciona un cliente",Color.Red,Color.White,Mensaje.TipoIcono.Error,Mensaje.TipoSonido.Error);

                return false;
            }
            if (materialComboBox_SelectProducto.SelectedIndex == -1) {
                materialComboBox_SelectProducto.SelectedIndex = 0;
                materialComboBox_SelectProducto.Focus();
                mensaje.Show("Que vas a vender?", "Selecciona un producto", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);

                return false;
            }
            if (materialComboBox_FormasPago.SelectedIndex == -1) {
                materialComboBox_FormasPago.SelectedIndex = 0;
                materialComboBox_FormasPago.Focus();
                mensaje.Show("Como paga?", "Selecciona un medio", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);

                return false;
            }
            if (materialComboBox_Cuotas.SelectedIndex == -1) {
                materialComboBox_Cuotas.SelectedIndex = 0;
                materialComboBox_Cuotas.Focus();
                mensaje.Show("Cuantas cuotas?", "Seleccionar valido", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);

                return false;
            }
            if (materialComboBox_Cantidad.SelectedIndex == -1) {
                materialComboBox_Cantidad.SelectedIndex = 0;
                materialComboBox_Cantidad.Focus();
                mensaje.Show("Cuantos compro?", "Seleccionar valido", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);

                return false;
            }

            return true;
        }

        private void VerificarProgreso() {
            int totalCampos = 6;
            int camposCompletos = 0;

            if (materialComboBox_SeleccionCliente.SelectedIndex != 0) camposCompletos++;
            if (materialComboBox_SelectProducto.SelectedIndex != 0) camposCompletos++;
            if (materialComboBox_FormasPago.SelectedIndex != 0) camposCompletos++;
            if (materialComboBox_Cuotas.SelectedIndex != 0) camposCompletos++;
            if (materialComboBox_Cantidad.SelectedIndex != 0) camposCompletos++;
            if (!string.IsNullOrEmpty(materialTextBoxEdit_DetallesVenta.Text)) camposCompletos++;

            Console.WriteLine(camposCompletos);
            int porcentaje = (int)((double)camposCompletos / totalCampos * 100);
            parrotFlatProgressBar_BarraProgresoFormulario.Value = porcentaje;
        }
        private void materialButton_Vender_Click(object sender, EventArgs e) {
            if (Validaciones()) {
                
            }
        }

        private void Venta_Load(object sender, EventArgs e) {
            
        }

        private void materialComboBox_SeleccionCliente_SelectedIndexChanged(object sender, EventArgs e) {
            VerificarProgreso();
        }

        private void materialComboBox_SelectProducto_SelectedIndexChanged(object sender, EventArgs e) {
            VerificarProgreso();
        }

        private void materialComboBox_FormasPago_SelectedIndexChanged(object sender, EventArgs e) {
            VerificarProgreso();
        }

        private void materialComboBox_Cuotas_SelectedIndexChanged(object sender, EventArgs e) {
            VerificarProgreso();
        }

        private void materialComboBox_Cantidad_SelectedIndexChanged(object sender, EventArgs e) {
            VerificarProgreso();
        }

        private void materialTextBoxEdit_DetallesVenta_Click(object sender, EventArgs e) {
            VerificarProgreso();
        }

        private void materialButton_CargarNuevoCliente_Click(object sender, EventArgs e) {
            CargarCliente cargarCliente = new CargarCliente();
            cargarCliente.Show();
        }

        private void materialButton_VerVentas_Click(object sender, EventArgs e) {
            Lista_Ventas listaventas = new Lista_Ventas();
            listaventas.Show();
        }
    }
}
