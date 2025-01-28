using AGN_predits.Conexiones.BD.Logica;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGN_predits.Formularios.Vender {
    public partial class ListaClientes : Form {
        public ListaClientes() {
            InitializeComponent();
        }

        private async void ListaClientes_Load(object sender, EventArgs e) {
            poisonDataGridView_Clientes.Rows.Clear();
            foreach (var dato in await LogicaCliente.Instancia.ListarClientesAsync()) {
                poisonDataGridView_Clientes.Rows.Add(dato.ClienteID,dato.Nombre,dato.Apellido,dato.Dni,dato.Telefono,dato.Gmail);
            }
        }
        
        private void poisonDataGridView_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
