using AGN_predits.Conexiones.BD.Logica;
using AGN_predits.Formularios.Vender;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGN_predits.Formularios.Cliente {
    public partial class ClientesForm : Form {
        public ClientesForm() {
            InitializeComponent();
            pictureBox_Cargando.Image = Image.FromFile("Gif/Dual Ring@1x-1.0s-200px-200px.gif");
            pictureBox_Cargando.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Cargando.Hide();
        }

        private async void Clientes_Load(object sender, EventArgs e) {
            poisonDataGridView_Clientes.Rows.Clear();
            pictureBox_Cargando.Show();
            label_Cargando.Show();
            foreach (var dato in await LogicaCliente.Instancia.ListarClientesAsync()) {
                poisonDataGridView_Clientes.Rows.Add(dato.ClienteID, dato.Nombre, dato.Apellido, dato.Dni, dato.Telefono, dato.Gmail);
            }
            pictureBox_Cargando.Hide();
            label_Cargando.Hide();
        }
        private void Editar(int rowIndex) {
            // Obtener los datos de la fila seleccionada
            int clienteID = Convert.ToInt32(poisonDataGridView_Clientes.Rows[rowIndex].Cells["ClienteID"].Value);
            string nombre = poisonDataGridView_Clientes.Rows[rowIndex].Cells["Nombre"].Value.ToString();
            string apellido = poisonDataGridView_Clientes.Rows[rowIndex].Cells["Apellido"].Value.ToString();
            string dni = poisonDataGridView_Clientes.Rows[rowIndex].Cells["Dni"].Value.ToString();
            string telefono = poisonDataGridView_Clientes.Rows[rowIndex].Cells["Telefono"].Value.ToString();
            string gmail = poisonDataGridView_Clientes.Rows[rowIndex].Cells["Gmail"].Value.ToString();

            // Crear una nueva instancia de CargarCliente (el formulario de edición)
            CargarCliente cargarNuevoCliente = new CargarCliente();

            // Pasar los datos al formulario de CargarCliente
            cargarNuevoCliente.SetClienteData(clienteID, nombre, apellido, dni, telefono, gmail);

            // Abrir el formulario en modo edición (suponiendo que ya tienes un campo de edición en CargarCliente)
            cargarNuevoCliente.Show();
        }

        private void Borrar(int rowIndex) {

        }
        private void poisonDataGridView_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                string columnName = poisonDataGridView_Clientes.Columns[e.ColumnIndex].Name;

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

        private void materialButton_CargarCliente_Click(object sender, EventArgs e) {
            CargarCliente cargarnuevoCliente = new CargarCliente();
            cargarnuevoCliente.Show();
        }
    }
}
