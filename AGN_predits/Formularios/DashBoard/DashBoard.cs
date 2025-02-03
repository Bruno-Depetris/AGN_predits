using AGN_predits.Conexiones.BD.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGN_predits.Formularios.DashBoard {
    public partial class DashBoard : Form {
        public DashBoard() {
            InitializeComponent();
        }

        private async void DashBoard_Load(object sender, EventArgs e) {
            label_dineroInvertido.Text = string.Empty;
            foreach (var dato in await LogicaProducto.Instancia.ListarProductos()) {
                label_dineroInvertido.Text += dato.PrecioCosto.ToString();
            }


        }
    }
}
