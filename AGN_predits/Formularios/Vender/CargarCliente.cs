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
        }
        float dni = 0;
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
                dni = 0;
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

        private void materialButton_CargarCliente_Click(object sender, EventArgs e) {
            /*
            if (Validaciones()) {
                Cliente cliente = new Cliente();
                cliente.Nombre = materialTextBoxEdit_Nombre.Text;
                cliente.Apellido = materialTextBoxEdit_Apellido.Text;
                cliente.Dni = dni.ToString();
                cliente.Telefono = materialTextBoxEdit_Telefono.Text;
                cliente.Gmail = materialTextBoxEdit_Gmail.Text;

                if( await LogicaCliente.Instancia.CargarCliente(cliente)) {
                    Mensaje msj = new Mensaje();
                    msj.Show("Felicitaciones","Cliente cargado",Color.Green,Color.White,Mensaje.TipoIcono.Ok,Mensaje.TipoSonido.Confirmacion);
                }

               
            }*/

            LogicaCliente.Instancia.Connect();
        }

        private void materialButton_VerClientes_Click(object sender, EventArgs e) {
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.Show();
        }
    }
}
