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

namespace AGN_predits.Formularios.Stoc_k {
    public partial class nuevoPorducto : Form {
        public nuevoPorducto() {
            InitializeComponent();
            materialSwitch_Condicion.Checked = false;
            label_Cargando.Hide();
            pictureBox_Cargando.Image = Image.FromFile("Gif/Dual Ring@1x-1.0s-200px-200px.gif");
            pictureBox_Cargando.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Cargando.Hide();
        }

        decimal almacenamiento,bateria, costo, venta;
        string condicion = string.Empty;

        private bool Validaciones() {

            Mensaje msj = new Mensaje();

            if (string.IsNullOrEmpty(materialTextBoxEdit_Marca.Text)) {
                materialTextBoxEdit_Marca.Focus();
                msj.Show("Marca" , "Colocar marca" , Color.Red , Color.White , Mensaje.TipoIcono.Error , Mensaje.TipoSonido.simple);
                return false;
            }
            
            if (string.IsNullOrEmpty(materialTextBoxEdit_Modelo.Text)) {
                materialTextBoxEdit_Modelo.Focus();
                msj.Show("Modelo" , "Colocar modelo" , Color.Red , Color.White , Mensaje.TipoIcono.Error , Mensaje.TipoSonido.simple);
                return false;
            }

            if (decimal.TryParse(materialTextBoxEdit_Almacenamiento.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.CurrentCulture,
                out almacenamiento)) {

            } else {

                materialTextBoxEdit_Almacenamiento.Clear();
                materialTextBoxEdit_Almacenamiento.Focus();

                msj.Show("Error", "Almacenamiento", Color.Red, Color.WhiteSmoke, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                msj.Show();
            }

            if (decimal.TryParse(materialTextBoxEdit_Bateria.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.CurrentCulture,
                out bateria)) {

            } else {

                materialTextBoxEdit_Bateria.Clear();
                materialTextBoxEdit_Bateria.Focus();

                msj.Show("Error", "Almacenamiento", Color.Red, Color.WhiteSmoke, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                msj.Show();
            }
            if (materialSwitch_Condicion.Checked == false) {
                condicion = "Nuevo";
            } else {

                condicion = "Usado";
            }

            if (string.IsNullOrEmpty(materialTextBoxEdit_Stock.Text)) {
                materialTextBoxEdit_Stock.Focus();
                msj.Show("Stock?", "error", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);
                return false;
            }

            if (decimal.TryParse(materialTextBoxEdit_Costo.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.CurrentCulture,
                out costo)) {

            } else {

                materialTextBoxEdit_Costo.Clear();
                materialTextBoxEdit_Costo.Focus();

                msj.Show("Error", "costo", Color.Red, Color.WhiteSmoke, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                msj.Show();
            }

            if (decimal.TryParse(materialTextBoxEdit_Venta.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.CurrentCulture,
                out venta)) {

            } else {

                materialTextBoxEdit_Venta.Clear();
                materialTextBoxEdit_Venta.Focus();

                msj.Show("Error", "venta", Color.Red, Color.WhiteSmoke, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                msj.Show();
            }
            return true;
        }
        

        private void Restaurar() {
            materialTextBoxEdit_Marca.Clear();
            materialTextBoxEdit_Modelo.Clear();
            materialTextBoxEdit_Almacenamiento.Clear();
            materialTextBoxEdit_Bateria.Clear();
            materialTextBoxEdit_Stock.Clear();
            materialTextBoxEdit_Descripcion.Clear();
            materialTextBoxEdit_Costo.Clear();
            materialTextBoxEdit_Venta.Clear();
        }
        private async void materialButton_CargarProducto_Click(object sender, EventArgs e) {
            if (Validaciones()) {
                Producto producto = new Producto();
                
                producto.Marca = materialTextBoxEdit_Marca.Text;
                producto.Modelo = materialTextBoxEdit_Modelo.Text;
                producto.Condicion = condicion;
                producto.Almacenamiento = almacenamiento;
                producto.Bateria = bateria;
                producto.Stock = int.Parse(materialTextBoxEdit_Stock.Text);
                producto.descripcion = materialTextBoxEdit_Descripcion.Text;
                producto.PrecioCosto = costo;
                producto.PrecioVenta = venta;
                Mensaje msj = new Mensaje();


                pictureBox_Cargando.Show();
                label_Cargando.Show();
                if (await LogicaProducto.Instancia.CargarProducto(producto)) {
                   
                    msj.Show("Producto","Cargado",Color.Green,Color.White,Mensaje.TipoIcono.Ok,Mensaje.TipoSonido.start);
                    Restaurar();
                } else {
                    msj.Show("Error", "logica producto", Color.Red, Color.White, Mensaje.TipoIcono.BaseDatos, Mensaje.TipoSonido.archive);
                }
                pictureBox_Cargando.Hide();
                label_Cargando.Hide();


            }
        }
    }
}
