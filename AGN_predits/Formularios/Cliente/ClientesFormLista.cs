using AGN_predits.Conexiones.BD.Logica;
using AGN_predits.Formularios.Vender;
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

namespace AGN_predits.Formularios.Cliente {
    public partial class ClientesFormLista : Form {
       
        public ClientesFormLista() {
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
        public async Task ActualizarDataGreed() {
            poisonDataGridView_Clientes.Rows.Clear();
            pictureBox_Cargando.Show();
            label_Cargando.Show();

            var clientes = await LogicaCliente.Instancia.ListarClientesAsync();

            foreach (var dato in clientes) {
                poisonDataGridView_Clientes.Rows.Add(dato.ClienteID, dato.Nombre, dato.Apellido, dato.Dni, dato.Telefono, dato.Gmail);
            }

            pictureBox_Cargando.Hide();
            label_Cargando.Hide();
        }

        private void Editar(int rowIndex) {
            var seleccionarRow = poisonDataGridView_Clientes.Rows[rowIndex];

            int clienteID = Convert.ToInt32(seleccionarRow.Cells[0].Value);
            string nombre = Convert.ToString(seleccionarRow.Cells[1].Value);
            string apellido = Convert.ToString(seleccionarRow.Cells[2].Value);
            string dni = Convert.ToString(seleccionarRow.Cells[3].Value);
            string telefono = Convert.ToString(seleccionarRow.Cells[4].Value);
            string gmail = Convert.ToString(seleccionarRow.Cells[5].Value);

            // Pasamos 'this' para que CargarCliente tenga acceso a ClientesForm
            CargarCliente cargarNuevoCliente = new CargarCliente(this);

            cargarNuevoCliente.SetClienteData(clienteID, nombre, apellido, dni, telefono, gmail);
            cargarNuevoCliente.Show();
        }


        private async void Borrar(int rowIndex) {
            var seleccionarRow = poisonDataGridView_Clientes.Rows[rowIndex];

            int IDselected = Convert.ToInt32(seleccionarRow.Cells[0].Value);

            string NombreApellido = Convert.ToString(seleccionarRow.Cells[1].Value) + " " + Convert.ToString(seleccionarRow.Cells[2].Value);

            DialogResult result = MessageBox.Show($"Seguro que desea borrar a {NombreApellido}?  ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Mensaje mensaje = new Mensaje();
            if (result == DialogResult.Yes) {
                pictureBox_Cargando.Show();
                label_Cargando.Show();
                if (await LogicaCliente.Instancia.EliminarCliente(IDselected)) {
                    await ActualizarDataGreed();

                    pictureBox_Cargando.Hide();
                    label_Cargando.Hide();

                    mensaje.Show($"{NombreApellido}", "Eliminado", Color.White, Color.White, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.Confirmacion);
                    mensaje.Show();
                } else {
                    mensaje.Show("Error", $"Contactar soporte", Color.Red, Color.White, Mensaje.TipoIcono.Error, Mensaje.TipoSonido.Error);
                    mensaje.Show();
                }
            } else {
                mensaje.Show("Cancelar", $"Operacion Cancelada", Color.Black, Color.White, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.Intermedio);
                mensaje.Show();
            }

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
            CargarCliente cargarnuevoCliente = new CargarCliente(this);
            cargarnuevoCliente.Show();
        }
    }
}
