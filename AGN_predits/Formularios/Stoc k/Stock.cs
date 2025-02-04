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
            nuevoPorducto nuevoPorducto = new nuevoPorducto(this);
            nuevoPorducto.Show();
        }
        public async Task ActualizarDataGreed() {
            poisonDataGridView_Stock.Rows.Clear();
            pictureBox_Cargando.Show();
            label_Cargando.Show();

            var clientes = await LogicaProducto.Instancia.ListarProductos();

            foreach (var dato in clientes) {
                poisonDataGridView_Stock.Rows.Add(dato.ProductoID, dato.Marca, dato.Modelo, dato.Condicion, dato.Almacenamiento, dato.Bateria, dato.descripcion,dato.Email, dato.Stock, dato.PrecioCosto, dato.PrecioVenta);
            }

            pictureBox_Cargando.Hide();
            label_Cargando.Hide();
        }
        private async void Stock_Load(object sender, EventArgs e) {
            poisonDataGridView_Stock.Rows.Clear();
            pictureBox_Cargando.Show();
            label_Cargando.Show();
            foreach (var dato in await LogicaProducto.Instancia.ListarProductos()) {
                poisonDataGridView_Stock.Rows.Add(dato.ProductoID,dato.Marca,dato.Modelo,dato.Condicion,dato.Almacenamiento,dato.Bateria,dato.descripcion,dato.Email, dato.Stock,dato.PrecioCosto,dato.PrecioVenta);
            }
            pictureBox_Cargando.Hide();
            label_Cargando.Hide();
        }
        private void Editar(int rowIndex) {
            var seleccionarRow = poisonDataGridView_Stock.Rows[rowIndex];

            int ProductoID = Convert.ToInt32(seleccionarRow.Cells[0].Value);
            string marca = Convert.ToString(seleccionarRow.Cells[1].Value);
            string modelo = Convert.ToString(seleccionarRow.Cells[2].Value);
            string condicion = Convert.ToString(seleccionarRow.Cells[3].Value);

            decimal almacenamiento = Convert.ToDecimal(seleccionarRow.Cells[4].Value);
            decimal bateria = Convert.ToDecimal(seleccionarRow.Cells[5].Value);

            string descripcion = Convert.ToString(seleccionarRow.Cells[6].Value);
            string email = Convert.ToString(seleccionarRow.Cells[7].Value);
            string stock = Convert.ToString(seleccionarRow.Cells[8].Value);

            decimal costo = Convert.ToDecimal(seleccionarRow.Cells[9].Value);
            decimal venta = Convert.ToDecimal(seleccionarRow.Cells[10].Value);

            nuevoPorducto editarProducto = new nuevoPorducto(this);
            editarProducto.SetProductData(ProductoID,marca,modelo,condicion,almacenamiento,bateria,descripcion,email,stock, costo,venta);
            editarProducto.Text = "Editar Producto";
            editarProducto.Show();
        }
        private async Task Borrar(int rowIndex) {
            // Verificar si el índice es válido
            if (rowIndex < 0 || rowIndex >= poisonDataGridView_Stock.Rows.Count) {
                MessageBox.Show("Índice fuera de rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var seleccionarRow = poisonDataGridView_Stock.Rows[rowIndex];

            // Validar si las celdas contienen datos
            if (seleccionarRow.Cells[0].Value == null || seleccionarRow.Cells[1].Value == null || seleccionarRow.Cells[2].Value == null) {
                MessageBox.Show("No se puede eliminar un producto con valores nulos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int IDselected;
     
            if (!int.TryParse(seleccionarRow.Cells[0].Value.ToString(), out IDselected)) {
                MessageBox.Show("ID de producto inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Producto = (seleccionarRow.Cells[1].Value?.ToString() ?? "") + " " + (seleccionarRow.Cells[2].Value?.ToString() ?? "");

            DialogResult result = MessageBox.Show($"¿Seguro que desea borrar {Producto}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) {
                new Mensaje().Show("Cancelar", "Operación Cancelada", Color.Black, Color.White, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.Intermedio);
                return;
            }

            // Mostrar carga
            pictureBox_Cargando.Show();
            label_Cargando.Show();

            try {
                if (await LogicaProducto.Instancia.EliminarProducto(IDselected)) {
                    await ActualizarDataGreed(); // Corregido si el nombre estaba mal

                    new Mensaje().Show($"{Producto}", "Eliminado", Color.White, Color.White, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.Confirmacion);
                } else {
                    new Mensaje().Show("Error", "Contactar soporte", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                // Asegurar que la pantalla de carga se oculta siempre
                pictureBox_Cargando.Hide();
                label_Cargando.Hide();

                Console.WriteLine(await LogicaProducto.Instancia.EliminarProducto(IDselected));
            }
        }
        private  void poisonDataGridView_Stock_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                string columnName = poisonDataGridView_Stock.Columns[e.ColumnIndex].Name;

                switch (columnName) {
                    case "Column_Editar":
                         Editar(e.RowIndex);
                        break;
                    case "Column_Borrar":
                        Borrar(e.RowIndex);
                        break;

                }
            }
        }
    }
}
