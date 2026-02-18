using AGN_predits.Conexiones.BD.Logica;
using AGN_predits.Conexiones.BD.Modelo;
using AGN_predits.Notificaciones;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AGN_predits.Formularios.Caja {
    public partial class CerrarCaja : Form {
        private Caja _formCaja;

        public CerrarCaja(Caja formCaja) {
            InitializeComponent();
            _formCaja = formCaja;
        }

        private async void materialButton_CerrarCaja_Click(object sender, EventArgs e) {
            Mensaje msj = new Mensaje();

            decimal transferencias = 0, efectivo = 0, tarjetas = 0, crypto = 0;

            if (!string.IsNullOrEmpty(materialTextBoxEdit_Transferencias.Text)) {
                if (!decimal.TryParse(materialTextBoxEdit_Transferencias.Text.Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out transferencias)) {
                    msj.Show("Error", "Transferencias inválido", Color.Red, Color.White,
                        Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(materialTextBoxEdit_Efectivo.Text)) {
                if (!decimal.TryParse(materialTextBoxEdit_Efectivo.Text.Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out efectivo)) {
                    msj.Show("Error", "Efectivo inválido", Color.Red, Color.White,
                        Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(materialTextBoxEdit_Tarjeta.Text)) {
                if (!decimal.TryParse(materialTextBoxEdit_Tarjeta.Text.Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out tarjetas)) {
                    msj.Show("Error", "Tarjeta inválido", Color.Red, Color.White,
                        Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(materialTextBoxEdit_Crypto.Text)) {
                if (!decimal.TryParse(materialTextBoxEdit_Crypto.Text.Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out crypto)) {
                    msj.Show("Error", "Crypto inválido", Color.Red, Color.White,
                        Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                    return;
                }
            }

            decimal total = transferencias + efectivo + tarjetas + crypto;

            DialogResult result = MessageBox.Show(
                $"¿Confirmar cierre de caja?\n\n" +
                $"Transferencias: ${transferencias:N2}\n" +
                $"Efectivo: ${efectivo:N2}\n" +
                $"Tarjetas: ${tarjetas:N2}\n" +
                $"Crypto: ${crypto:N2}\n" +
                $"───────────────\n" +
                $"TOTAL: ${total:N2}",
                "Cerrar Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                Cierre cierre = new Cierre {
                    Transferencias = transferencias,
                    Efectivo = efectivo,
                    Tarjetas = tarjetas,
                    Crypto = crypto
                };

                if (await LogicaCaja.Instancia.CerrarCaja(cierre)) {
                    msj.Show("Caja cerrada", $"Total: ${total:N2}", Color.White, Color.White,
                        Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.Confirmacion);
                    await _formCaja.CargarResumen();
                    this.Close();
                } else {
                    msj.Show("Error", "No se pudo cerrar la caja", Color.Red, Color.White,
                        Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                }
            }
        }
    }
}
