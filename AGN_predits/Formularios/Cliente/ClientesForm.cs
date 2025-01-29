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
        }

        private async void Clientes_Load(object sender, EventArgs e) {
            poisonDataGridView_Clientes.Rows.Clear();
            foreach (var dato in await LogicaCliente.Instancia.ListarClientesAsync()) {
                poisonDataGridView_Clientes.Rows.Add(dato.ClienteID, dato.Nombre, dato.Apellido, dato.Dni, dato.Telefono, dato.Gmail);
            }
        }
        private void Editar(int rowIndex) {

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
            Lista_Ventas listaventas = new Lista_Ventas();
            listaventas.Show();
        }
    }
}
