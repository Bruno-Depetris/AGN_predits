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

namespace AGN_predits.Formularios.Tecnico {
    public partial class ListaTecnico : Form {
        public ListaTecnico() {
            InitializeComponent();
            pictureBox_Cargando.Image = Image.FromFile("Gif/Dual Ring@1x-1.0s-200px-200px.gif");
            pictureBox_Cargando.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Cargando.Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e) {
            CargaNuevoTecnico nuevoProducto = new CargaNuevoTecnico(this);
            nuevoProducto.Show();
        }
        public async Task ActualizarDataGreed() {
            poisonDataGridView_StockTecnico.Rows.Clear();
            pictureBox_Cargando.Show();
            label_Cargando.Show();

            var clientes = await LogicaTecnico.Instancia.ListarTecnicos();

            foreach (var dato in clientes) {
                poisonDataGridView_StockTecnico.Rows.Add(dato.TecnicoID, dato.Marca, dato.Modelo,  dato.Almacenamiento, dato.Bateria, dato.Falla, dato.Email, dato.CostoArreglo, dato.Costo);
            }

            pictureBox_Cargando.Hide();
            label_Cargando.Hide();
        }

        private async void ListaTecnico_Load(object sender, EventArgs e) {
            poisonDataGridView_StockTecnico.Rows.Clear();
            pictureBox_Cargando.Show();
            label_Cargando.Show();
            foreach (var dato in await LogicaTecnico.Instancia.ListarTecnicos()) {
                poisonDataGridView_StockTecnico.Rows.Add(dato.TecnicoID, dato.Marca, dato.Modelo, dato.Almacenamiento, dato.Bateria, dato.Falla, dato.Email, dato.CostoArreglo, dato.Costo);
            }
            pictureBox_Cargando.Hide();
            label_Cargando.Hide();
        }
    }
}
