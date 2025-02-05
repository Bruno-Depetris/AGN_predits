using AGN_predits.Conexiones.BD.Logica;
using AGN_predits.Conexiones.BD.Modelo;
using AGN_predits.Formularios.Stoc_k;
using AGN_predits.Notificaciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGN_predits.Formularios.Tecnico {
    public partial class CargaNuevoTecnico : Form {
        private ListaTecnico _ListaTecnico;
        public CargaNuevoTecnico(ListaTecnico listaTecnico) {
            InitializeComponent();

            label_Cargando.Hide();
            pictureBox_Cargando.Image = Image.FromFile("Gif/Dual Ring@1x-1.0s-200px-200px.gif");
            pictureBox_Cargando.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Cargando.Hide();
            _ListaTecnico = listaTecnico;
        }

        decimal almacenamiento, bateria, costo, venta;
        string condicion = string.Empty;
        bool editar = false;

        private async void materialButton_CargarProducto_Click(object sender, EventArgs e) {
            if (Validaciones() && editar == false) {
                TecnicoMod producto = new TecnicoMod();

                producto.Marca = materialTextBoxEdit_Marca.Text;
                producto.Modelo = materialTextBoxEdit_Modelo.Text;
                producto.Almacenamiento = almacenamiento;
                producto.Bateria = bateria;
                producto.Falla = materialTextBoxEdit_Falla.Text;
                producto.CostoArreglo = venta;
                producto.Costo = costo;
                producto.Email = materialTextBoxEdit_Email.Text;
                Mensaje msj = new Mensaje();


                pictureBox_Cargando.Show();
                label_Cargando.Show();

                if (await LogicaTecnico.Instancia.CargarTecnico(producto)) {

                    msj.Show("Producto", "Cargado", Color.Green, Color.White, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.start);
                    Restaurar();
                } else {
                    msj.Show("Error", "logica producto", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.archive);
                }
                await _ListaTecnico.ActualizarDataGreed();
                pictureBox_Cargando.Hide();
                label_Cargando.Hide();

                return;
            }
            /*
            if (Validaciones() && editar == true) {
                Producto producto = new Producto();

                producto.ProductoID = IdSeleccionado;
                producto.Marca = materialTextBoxEdit_Marca.Text;
                producto.Modelo = materialTextBoxEdit_Modelo.Text;
                producto.Condicion = condicion;
                producto.Almacenamiento = almacenamiento;
                producto.Bateria = bateria;
                producto.Stock = int.Parse(materialTextBoxEdit_Stock.Text);
                producto.descripcion = materialTextBoxEdit_Descripcion.Text;
                producto.PrecioCosto = costo;
                producto.PrecioVenta = venta;
                producto.Email = materialTextBoxEdit_Email.Text;
                Mensaje msj = new Mensaje();


                pictureBox_Cargando.Show();
                label_Cargando.Show();

                if (await LogicaProducto.Instancia.EditarProducto(producto)) {

                    msj.Show("Producto", "Editado", Color.Green, Color.White, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.start);
                    Restaurar();
                    this.Close();
                } else {
                    msj.Show("Error", "logica Edicion", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.archive);
                }
                await _stock.ActualizarDataGreed();
                pictureBox_Cargando.Hide();
                label_Cargando.Hide();
                return;
            }
            */
        }

        int IdSeleccionado;
        private bool Validaciones() {

            Mensaje msj = new Mensaje();

            if (string.IsNullOrEmpty(materialTextBoxEdit_Marca.Text)) {
                materialTextBoxEdit_Marca.Focus();
                msj.Show("Marca", "Colocar marca", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);
                return false;
            }

            if (string.IsNullOrEmpty(materialTextBoxEdit_Modelo.Text)) {
                materialTextBoxEdit_Modelo.Focus();
                msj.Show("Modelo", "Colocar modelo", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);
                return false;
            }

            if (decimal.TryParse(materialTextBoxEdit_Almacenamiento.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out almacenamiento)) {

            } else {

                materialTextBoxEdit_Almacenamiento.Clear();
                materialTextBoxEdit_Almacenamiento.Focus();

                msj.Show("Error", "Almacenamiento", Color.Red, Color.WhiteSmoke, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                msj.Show();
            }

            if (string.IsNullOrEmpty(materialTextBoxEdit_Email.Text)) {
                materialTextBoxEdit_Email.Focus();
                msj.Show("Error", "Colocar Email", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);
                return false;
            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Falla.Text)) {
                materialTextBoxEdit_Falla.Focus();
                msj.Show("Error", "Colocar falla", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);
                return false;
            }
            if (decimal.TryParse(materialTextBoxEdit_Bateria.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out bateria)) {

            } else {

                materialTextBoxEdit_Bateria.Clear();
                materialTextBoxEdit_Bateria.Focus();

                msj.Show("Error", "Almacenamiento", Color.Red, Color.WhiteSmoke, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                msj.Show();
            }


            if (decimal.TryParse(materialTextBoxEdit_Costo.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out costo)) {

            } else {

                materialTextBoxEdit_Costo.Clear();
                materialTextBoxEdit_Costo.Focus();

                msj.Show("Error", "costo", Color.Red, Color.WhiteSmoke, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                msj.Show();
            }

            if (decimal.TryParse(materialTextBoxEdit_CostoReparacion.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out venta)) {

            } else {

                materialTextBoxEdit_CostoReparacion.Clear();
                materialTextBoxEdit_CostoReparacion.Focus();

                msj.Show("Error", "Reparaccion", Color.Red, Color.WhiteSmoke, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                msj.Show();
            }
            return true;
        }
        private void Restaurar() {
            materialTextBoxEdit_Marca.Clear();
            materialTextBoxEdit_Email.Clear();
            materialTextBoxEdit_Modelo.Clear();
            materialTextBoxEdit_Almacenamiento.Clear();
            materialTextBoxEdit_Bateria.Clear();
            materialTextBoxEdit_Falla.Clear();
            materialTextBoxEdit_CostoReparacion.Clear();
            materialTextBoxEdit_Costo.Clear();
        }
    }
}
