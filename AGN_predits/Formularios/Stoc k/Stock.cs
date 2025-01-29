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

namespace AGN_predits.Formularios.Stoc_k {
    public partial class Stock : Form {
        public Stock() {
            InitializeComponent();
            label_Cargando.Hide();
            pictureBox_Cargando.Image = Image.FromFile("Gif/Dual Ring@1x-1.0s-200px-200px.gif");
            pictureBox_Cargando.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Cargando.Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e) {
            nuevoPorducto nuevoPorducto = new nuevoPorducto();
            nuevoPorducto.Show();
        }

        private async void Stock_Load(object sender, EventArgs e) {
            poisonDataGridView_Stock.Rows.Clear();
            pictureBox_Cargando.Show();
            label_Cargando.Show();
            foreach (var dato in await LogicaProducto.Instancia.ListarProductos()) {
                poisonDataGridView_Stock.Rows.Add(dato.ProductoID,dato.Marca,dato.Modelo,dato.Condicion,dato.Almacenamiento,dato.Bateria,dato.descripcion,dato.Stock,dato.PrecioCosto,dato.PrecioVenta);
            }
            pictureBox_Cargando.Hide();
            label_Cargando.Hide();
        }
    }
}
