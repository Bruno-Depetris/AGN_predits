using AGN_predits.Conexiones.BD.Logica;
using AGN_predits.Conexiones.BD.Modelo;
using AGN_predits.Formularios.Vender;
using AGN_predits.Notificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGN_predits.Formularios {
    public partial class Venta : Form {
        public Venta() {
            InitializeComponent();
            VerificarProgreso();
            Restaurar();
            CargarCB();
            label_Cargando.Hide();
            pictureBox_Cargando.Image = Image.FromFile("Gif/Dual Ring@1x-1.0s-200px-200px.gif");
            pictureBox_Cargando.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Cargando.Hide();
        }
        string Client = Path.Combine(Application.StartupPath, "Img/Iconos", "tab_client.png");
        string Producto = Path.Combine(Application.StartupPath, "Img/Iconos", "nuy.png");
        string plan = string.Empty;
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
        private async void CargarCB() {
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
                    materialComboBox_SeleccionCliente.Items.Insert(i, $"ID:{dato.ClienteID} | {dato.Nombre}  {dato.Apellido}  {dato.Telefono}  {dato.Gmail}");
                    i++;
                }
                int x = 1;
                foreach (var dato in producto) {
                    materialComboBox_SelectProducto.Items.Insert(x, $"ID:{dato.ProductoID} | {dato.Marca}  {dato.Modelo} {dato.Condicion} almacenamiento: {dato.Almacenamiento} bateria: {dato.Bateria} precio: {dato.PrecioVenta}");
                    x++;
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pictureBox_Cliente.Image = Image.FromFile(Client);
            pictureBox_Prod.Image = Image.FromFile(Producto);
        }

        private void Venta_Load(object sender, EventArgs e) {
            Restaurar();
  
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

        private void Restaurar() {
            materialComboBox_SeleccionCliente.Items.Clear();
            materialComboBox_SelectProducto.Items.Clear();

            materialComboBox_SeleccionCliente.Items.Insert(0, "Seleccionar");
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
            materialTextBoxEdit_DetallesVenta.Clear();
            materialSwitch_canje.Checked = false;

           
        }
        private async void materialButton_Vender_Click(object sender, EventArgs e) {
            
            if (Validaciones()) {
                Mensaje msj = new Mensaje();
                int productoID = Convert.ToInt32(materialComboBox_SelectProducto.Text.ToString().Split(' ')[0].Replace("ID:", ""));
                DetalleVenta nuevaVenta = new DetalleVenta(); 
                nuevaVenta.ProductoID = productoID;
                nuevaVenta.ClienteID = Convert.ToInt32(materialComboBox_SeleccionCliente.Text.ToString().Split(' ')[0].Replace("ID:", ""));
                nuevaVenta.Fecha = DateTime.Now;
                int formaPago = 0;
                switch (materialComboBox_FormasPago.Text) {
                    case "Transferencia":
                        formaPago = 1;
                        break;
                    case "Efectivo":
                        formaPago = 2;
                        break;
                    case "Credito":
                        formaPago = 3;
                        break;
                    case "Crypto":
                        formaPago = 4;
                        break;
                }
                nuevaVenta.MedioPagoID = formaPago;
                nuevaVenta.Cantidad = Convert.ToInt32(materialComboBox_Cantidad.Text.ToString());
                nuevaVenta.Cuotas = Convert.ToInt32(materialComboBox_Cuotas.Text.ToString());
                string detalle = string.Empty;
                if (string.IsNullOrEmpty(materialTextBoxEdit_DetallesVenta.Text.ToString())) {
                    detalle = "Sin detalle";
                } else {
                    detalle = materialTextBoxEdit_DetallesVenta.Text.ToString();
                }
                nuevaVenta.Detalles = detalle;
                if (materialSwitch_canje.Checked) {
                    plan = "Canje";
                } else {
                    plan = "Sin plan";
                }
                nuevaVenta.PlanCanje = plan;
                int cantidad = int.Parse(materialComboBox_Cantidad.Text);
                label_Cargando.Show();
                pictureBox_Cargando.Show();
                //APLICAR PARA QUE SI NO HAY UN PRODUCTO ESTE MISMO REQUIERA RECARGA DE STOCK
                if (await LogicaDetalleVenta.Instancia.CargarDetalleVenta(nuevaVenta)) {
                    msj.Show("Exito", "Venta Concretada", Color.White, Color.White, Mensaje.TipoIcono.Cash, Mensaje.TipoSonido.Money);

                   

                    Console.WriteLine(cantidad);

                    foreach (var dato in await LogicaProducto.Instancia.ListarProductos()) {

                        if (dato.ProductoID == productoID) {
                            Producto restarStock = new Producto();
                            restarStock.ProductoID = productoID;
                            restarStock.Marca = dato.Marca;
                            restarStock.Modelo = dato.Modelo;
                            restarStock.Condicion = dato.Condicion;
                            restarStock.Almacenamiento = dato.Almacenamiento;
                            restarStock.Bateria = dato.Bateria;
                            restarStock.Stock = dato.Stock - cantidad;
                            restarStock.Email = dato.Email;
                            restarStock.PrecioCosto = dato.PrecioCosto;
                            restarStock.PrecioVenta = dato.PrecioVenta;
                            restarStock.descripcion = dato.descripcion;

                            await LogicaProducto.Instancia.EditarProducto(restarStock);
                        } else {
                            Console.WriteLine("que id maestro?");
                        }
                    }
                } else {
                    msj.Show("Error", "Logica Venta", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.popTres);
                }
                label_Cargando.Hide();
                pictureBox_Cargando.Hide();
                Restaurar();
                CargarCB();
            }
   
        }

        
    }
}
