using AGN_predits.Conexiones;
using AGN_predits.Formularios;
using AGN_predits.Formularios.Caja;
using AGN_predits.Formularios.DashBoard;
using AGN_predits.Formularios.Stoc_k;
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

        private void FormPrincipal_Load(object sender, EventArgs e) {

        }

    }
}
