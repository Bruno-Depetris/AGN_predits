using AGN_predits.Conexiones.BD.Logica;
using AGN_predits.Conexiones.BD.Modelo;
using AGN_predits.Formularios.Stoc_k;
using AGN_predits.Notificaciones;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types;

namespace AGN_predits.Formularios.Tecnico {
    public partial class ListaTecnico : Form {
        public ListaTecnico() {
            InitializeComponent();
            pictureBox_Cargando.Image = System.Drawing.Image.FromFile("Gif/Dual Ring@1x-1.0s-200px-200px.gif");
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
        private void Editar(int rowIndex) {
            var seleccionarRow = poisonDataGridView_StockTecnico.Rows[rowIndex];

            int TecnicoID = Convert.ToInt32(seleccionarRow.Cells[0].Value);
            string marca = Convert.ToString(seleccionarRow.Cells[1].Value);
            string modelo = Convert.ToString(seleccionarRow.Cells[2].Value);

            decimal almacenamiento = Convert.ToDecimal(seleccionarRow.Cells[3].Value);
            decimal bateria = Convert.ToDecimal(seleccionarRow.Cells[4].Value);

            string falla = Convert.ToString(seleccionarRow.Cells[5].Value);
            string email = Convert.ToString(seleccionarRow.Cells[6].Value);

            decimal costoreparacion = Convert.ToDecimal(seleccionarRow.Cells[7].Value);
            decimal costo = Convert.ToDecimal(seleccionarRow.Cells[8].Value);

            CargaNuevoTecnico editarProducto = new CargaNuevoTecnico(this);
            editarProducto.SetProductData(TecnicoID, marca, modelo, almacenamiento, bateria, falla, email, costoreparacion, costo);
            editarProducto.Text = "Editar Producto";
            editarProducto.Show();
        }
        private void Reperar(int rowIndex) {
            var seleccionarRow = poisonDataGridView_StockTecnico.Rows[rowIndex];
            int TecnicoID = Convert.ToInt32(seleccionarRow.Cells[0].Value);

            string marca = Convert.ToString(seleccionarRow.Cells[1].Value);
            string modelo = Convert.ToString(seleccionarRow.Cells[2].Value);

            decimal almacenamiento = Convert.ToDecimal(seleccionarRow.Cells[3].Value);
            decimal bateria = Convert.ToDecimal(seleccionarRow.Cells[4].Value);

            string falla = Convert.ToString(seleccionarRow.Cells[5].Value);
            string email = Convert.ToString(seleccionarRow.Cells[6].Value);

            decimal costoreparacion = Convert.ToDecimal(seleccionarRow.Cells[7].Value);
            decimal costo = Convert.ToDecimal(seleccionarRow.Cells[8].Value);

            nuevoPorducto editarProducto = new nuevoPorducto(this);
            editarProducto.SetProductRestore(TecnicoID, marca, modelo, almacenamiento, bateria, falla, email, costoreparacion, costo);
            editarProducto.Text = "cargar Producto";
            editarProducto.Show();
        }
        private async void Borrar(int rowIndex) {
       
            if (rowIndex < 0 || rowIndex >= poisonDataGridView_StockTecnico.Rows.Count) {
                MessageBox.Show("Índice fuera de rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var seleccionarRow = poisonDataGridView_StockTecnico.Rows[rowIndex];

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
                if (await LogicaTecnico.Instancia.EliminarTecnico(IDselected)) {
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

               
            }
        }
        private void poisonDataGridView_StockTecnico_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                string columnName = poisonDataGridView_StockTecnico.Columns[e.ColumnIndex].Name;

                switch (columnName) {
                    case "Column_Editar":
                        Editar(e.RowIndex);
                        break;
                    case "Column_Borrar":
                        Borrar(e.RowIndex);
                        break;
                    case "Column_Reparado":
                        Reperar(e.RowIndex);
                        break;
                }
            }
        }
    }
}
