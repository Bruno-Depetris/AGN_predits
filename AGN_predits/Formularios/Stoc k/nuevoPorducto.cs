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
        }

        private void Validaciones() {
            Mensaje msj = new Mensaje();
            if (string.IsNullOrEmpty(materialTextBoxEdit_Marca.Text)) {
                materialTextBoxEdit_Marca.Focus();
                msj.Show("Marca","colocar marca",Color.Red,Color.White,Mensaje.TipoIcono.Error,Mensaje.TipoSonido.simple);
                 
            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Marca.Text)) {
                materialTextBoxEdit_Marca.Focus();
                msj.Show("Marca", "colocar marca", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);

            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Marca.Text)) {
                materialTextBoxEdit_Marca.Focus();
                msj.Show("Marca", "colocar marca", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);

            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Marca.Text)) {
                materialTextBoxEdit_Marca.Focus();
                msj.Show("Marca", "colocar marca", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);

            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Marca.Text)) {
                materialTextBoxEdit_Marca.Focus();
                msj.Show("Marca", "colocar marca", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);

            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Marca.Text)) {
                materialTextBoxEdit_Marca.Focus();
                msj.Show("Marca", "colocar marca", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);

            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Marca.Text)) {
                materialTextBoxEdit_Marca.Focus();
                msj.Show("Marca", "colocar marca", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);

            }
            if (string.IsNullOrEmpty(materialTextBoxEdit_Marca.Text)) {
                materialTextBoxEdit_Marca.Focus();
                msj.Show("Marca", "colocar marca", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.simple);

            }
        }
    }
}
