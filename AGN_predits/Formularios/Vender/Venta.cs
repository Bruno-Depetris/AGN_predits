using AGN_predits.Conexiones.BD.Logica;
using AGN_predits.Formularios.Vender;
using AGN_predits.Notificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            materialComboBox_FormasPago.Items.Insert(1, "Transferencia");
            materialComboBox_FormasPago.Items.Insert(2, "Efectivo");
            materialComboBox_FormasPago.Items.Insert(3, "Credito");
            materialComboBox_FormasPago.Items.Insert(4, "Crypto");
            materialComboBox_FormasPago.SelectedIndex = 0;

            materialComboBox_Cuotas.Items.Insert(0, "Seleccionar");
            materialComboBox_Cuotas.Items.Insert(1, "1");
            materialComboBox_Cuotas.Items.Insert(2, "2");
            materialComboBox_Cuotas.Items.Insert(3, "6");
            materialComboBox_Cuotas.Items.Insert(4, "12");
            materialComboBox_Cuotas.SelectedIndex = 0;

            materialComboBox_Cantidad.Items.Insert(0, "Seleccionar");
            materialComboBox_Cantidad.Items.Insert(1, "1");
            materialComboBox_Cantidad.Items.Insert(2, "2");
            materialComboBox_Cantidad.Items.Insert(3, "3");
            materialComboBox_Cantidad.Items.Insert(4, "4");
            materialComboBox_Cantidad.SelectedIndex = 0;

            
        }
        string Client = Path.Combine(Application.StartupPath, "Img/Iconos", "tab_client.png");
        string Producto = Path.Combine(Application.StartupPath, "Img/Iconos", "nuy.png");
        
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
            int totalCampos = 5;
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


        private async void Venta_Load(object sender, EventArgs e) {

            try {
                //load cliente
                pictureBox_Cliente.Image = Image.FromFile("Gif/Pulse@1x-1.0s-200px-200px.gif");
                pictureBox_Cliente.SizeMode = PictureBoxSizeMode.Zoom;

                //load producto
                pictureBox_Prod.Image = Image.FromFile("Gif/Pulse@1x-1.0s-200px-200px.gif");
                pictureBox_Prod.SizeMode = PictureBoxSizeMode.Zoom;

                var clientes = await LogicaCliente.Instancia.ListarClientesAsync();
                var producto = await LogicaProducto.Instancia.ListarProductos();

                int i = 1;
                foreach (var dato in clientes) {
                    materialComboBox_SeleccionCliente.Items.Insert(i, $"{dato.Nombre} {dato.Apellido} {dato.Telefono} {dato.Gmail}");
                    i++;
                }
                int x = 1;
                foreach (var dato in producto) {
                    materialComboBox_SelectProducto.Items.Insert(x, $"{dato.Marca} {dato.Modelo} {dato.Condicion} almacenamiento: {dato.Almacenamiento} bateria: {dato.Bateria} precio: {dato.PrecioVenta}");
                    x++;
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pictureBox_Cliente.Image = Image.FromFile(Client);
            pictureBox_Prod.Image = Image.FromFile(Producto);

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

        private void materialButton_VerVentas_Click(object sender, EventArgs e) {
           Lista_Ventas listaventas = new Lista_Ventas();
            listaventas.Show();
        }


        private void materialButton_Vender_Click(object sender, EventArgs e) {
            if (Validaciones()) {

            }
        }
    }
}
