using AGN_predits.Conexiones;
using AGN_predits.Formularios;
using AGN_predits.Formularios.Caja;
using AGN_predits.Formularios.Cliente;
using AGN_predits.Formularios.DashBoard;
using AGN_predits.Formularios.Stoc_k;
using AGN_predits.Notificaciones;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheParfum.APIs.Logicas;
using TheParfum.APIs.Modelos;

namespace AGN_predits {
    public partial class FormPrincipal : Form {
        public FormPrincipal() {
            InitializeComponent();

            AbrirFormNuevo(new DashBoard());

            MoverPanel(parrotButton_Dashboard);


        }
        private Form FormActivo = null;




        // Variable de clase para guardar el último botón presionado
        private ReaLTaiizor.Controls.ParrotButton botonAnterior = null;

        private void MoverPanel(ReaLTaiizor.Controls.ParrotButton botonActual) {
            // Cambiar el color del panel
            panel_imhere.Height = botonActual.Height;
            panel_imhere.Top = botonActual.Top;
            panel_imhere.Left = botonActual.Left - 15;

            // Si hay un botón anterior y es diferente al actual, restaurar su color
            if (botonAnterior != null && botonAnterior != botonActual) {
                botonAnterior.BackgroundColor = Color.FromArgb(28, 143, 243); // Color por defecto
            }

            // Cambiar el color del botón actual
            botonActual.BackgroundColor = Color.FromArgb(8, 123, 223);

            // Actualizar la referencia al botón actual como el último presionado
            botonAnterior = botonActual;

            // Traer el panel al frente
            panel_imhere.BringToFront();
        }


        private void timer_movimientos_Tick(object sender, EventArgs e) {
            // Obtén la fecha y hora actuales
            DateTime fechaActual = DateTime.Now;

            // Actualiza el label con la fecha completa (formato dd:mm:yy)
            bigLabel_Fecha_completa.Text = fechaActual.ToString("dd/MM/yy");

            // Actualiza el label con el día de la semana
            bigLabel_Dia.Text = char.ToUpper(fechaActual.ToString("dddd")[0]) + fechaActual.ToString("dddd").Substring(1);

            // Actualiza el label con la hora en formato hh:mm:22
            bigLabel_Hora.Text = fechaActual.ToString("HH:mm:ss");
        }

        private void AbrirFormNuevo(Form FormHijo) {
            // Cerrar el formulario activo anterior
            if (FormActivo != null) {
                FormActivo.Close();
            }

            // Configurar el nuevo formulario
            FormActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panel_Contenedor.Controls.Add(FormHijo);
            panel_Contenedor.Tag = FormHijo;
            FormHijo.Show();
        }

        private void parrotButton_Dashboard_Click(object sender, EventArgs e) {
            AbrirFormNuevo(new DashBoard());

            MoverPanel(parrotButton_Dashboard);


        }

        private void parrotButton_Vender_Click(object sender, EventArgs e) {
            AbrirFormNuevo(new Venta());
            MoverPanel(parrotButton_Vender);
        }

        private void parrotButton_Caja_Click(object sender, EventArgs e) {
            AbrirFormNuevo(new Caja());
            MoverPanel(parrotButton_Caja);
        }

        private void parrotButton_Config_Click(object sender, EventArgs e) {

        }

        private void parrotButton_Stock_Click(object sender, EventArgs e) {
            AbrirFormNuevo(new Stock());
            MoverPanel(parrotButton_Stock);
        }

        private async void FormPrincipal_Load(object sender, EventArgs e) {
            string urlApi = "https://dolarapi.com/v1/dolares";


            using (var apiHelper = new ApiCotizacion(urlApi)) {
                try {
                    string responce = await apiHelper.GetAsync(urlApi);


                    List<ModeloApiCotizacion> apicotizacion = JsonConvert.DeserializeObject<List<ModeloApiCotizacion>>(responce);
                    var casaSeleccionada = "blue";

                    var cotizacionFiltrada = apicotizacion.Where(c => c.Casa == casaSeleccionada);

                    foreach (var cotizacion in cotizacionFiltrada) {

                        label_BLUE.Text = cotizacion.Compra.ToString();

                    }
                } catch (HttpRequestException httpex) {
                    throw httpex;


                } catch (Exception ex) {
                    throw ex;
                }


            }

            
        }

        private void panel_ContenedorLateral_Paint(object sender, PaintEventArgs e) {

        }

        private void parrotButton_Clientes_Click(object sender, EventArgs e) {
            AbrirFormNuevo(new ClientesFormLista());
            MoverPanel(parrotButton_Clientes);
        }

        private void parrotButton_Tecnico_Click(object sender, EventArgs e) {
            MoverPanel(parrotButton_Tecnico);
        }
    }
}
