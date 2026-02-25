using AGN_predits.Conexiones.BD.Logica;
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
    public partial class AbrirCaja : Form {
        private Caja _formCaja;
        public AbrirCaja(Caja formCaja) {
            InitializeComponent();
            _formCaja = formCaja;
        }




        private async void materialButton_AbrirCaja_Click(object sender, EventArgs e)
        {
            Mensaje msj = new Mensaje();

            if (!decimal.TryParse(materialTextBoxEdit1.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal monto))
            {
                msj.Show("Error", "Ingrese un monto válido", Color.Red, Color.White,
                    Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                materialTextBoxEdit1.Focus();
                return;
            }

            if (monto < 0)
            {
                msj.Show("Error", "El monto no puede ser negativo", Color.Red, Color.White,
                    Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                return;
            }

            if (await LogicaCaja.Instancia.AbrirCaja(monto))
            {
                msj.Show("Caja abierta", $"Monto: ${monto:N2}", Color.Green, Color.White,
                    Mensaje.TipoIcono.Cash, Mensaje.TipoSonido.Money);
                await _formCaja.CargarResumen();
                this.Close();
            }
            else
            {
                msj.Show("Error", "No se pudo abrir la caja", Color.Red, Color.White,
                    Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
            }
        }
    }
 
}
