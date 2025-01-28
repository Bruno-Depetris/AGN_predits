using AGN_predits.Conexiones;
using AGN_predits.Conexiones.BD.Logica;
using AGN_predits.Conexiones.BD.Modelo;
using AGN_predits.Formularios.Vender;
using AGN_predits.Notificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGN_predits.Formularios {
    public partial class CargarCliente : Form {
        public CargarCliente() {
            InitializeComponent();
            label_Cargando.Hide();
       

        }
        string dni = "0";
        public bool Validaciones() {
            Mensaje msj = new Mensaje();    
            if (string.IsNullOrEmpty(materialTextBoxEdit_Nombre.Text)) {
                materialTextBoxEdit_Nombre.Focus();
                msj.Show("Nombre?", "Ingresar nombre", Color.Red, Color.White,Mensaje.TipoIcono.Error,Mensaje.TipoSonido.Intermedio);
                return false;
            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Apellido.Text)) {
                materialTextBoxEdit_Apellido.Focus();
                msj.Show("Apellido?", "Ingresar Apellido", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Intermedio);
                return false;
            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Dni.Text)) {
                dni = "0";
            } else {
                dni = materialTextBoxEdit_Dni.Text;
            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Telefono.Text)) {
                materialTextBoxEdit_Telefono.Focus();
                msj.Show("Telefono?", "Ingresar numero", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Intermedio);
                return false;
            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Gmail.Text) || materialTextBoxEdit_Gmail.Text.IndexOf("@") == -1) {
                materialTextBoxEdit_Gmail.Focus();
                msj.Show("Gmail?", "Ingresar Gmail", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Intermedio);
                return false;
            }

            return true;
        }
        private void Restaurar() {
            materialTextBoxEdit_Nombre.Clear();
            materialTextBoxEdit_Apellido.Clear();
            materialTextBoxEdit_Dni.Clear();
            materialTextBoxEdit_Telefono.Clear();
            materialTextBoxEdit_Gmail.Clear();
        }
        private async void materialButton_CargarCliente_Click(object sender, EventArgs e) {
            
            if (Validaciones()) {
                Cliente cliente = new Cliente();
                cliente.Nombre = materialTextBoxEdit_Nombre.Text;
                cliente.Apellido = materialTextBoxEdit_Apellido.Text;
                cliente.Dni = dni.ToString();
                cliente.Telefono = materialTextBoxEdit_Telefono.Text;
                cliente.Gmail = materialTextBoxEdit_Gmail.Text;

                label_Cargando.Show();
                pictureBox_Cargando.Image = Image.FromFile("Gif/Dual Ring@1x-1.0s-200px-200px.gif");
                pictureBox_Cargando.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_Cargando.Show();
                if (await LogicaCliente.Instancia.CargarCliente(cliente)) {
                    Mensaje msj = new Mensaje();
                    msj.Show("Felicitaciones","Cliente cargado",Color.Green,Color.White,Mensaje.TipoIcono.Ok,Mensaje.TipoSonido.Confirmacion);
                    Restaurar();
                }
                pictureBox_Cargando.Hide();
                label_Cargando.Hide();
            }

   
        }

        private void materialButton_VerClientes_Click(object sender, EventArgs e) {
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.Show();
        }




    }
}
