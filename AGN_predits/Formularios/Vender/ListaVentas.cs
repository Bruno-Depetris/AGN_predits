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

namespace AGN_predits.Formularios.Vender {
    public partial class Lista_Ventas : Form {
        public Lista_Ventas() {
            InitializeComponent();
        }

        private void poisonDataGridView_Stock_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private async void Lista_Ventas_Load(object sender, EventArgs e) {
            poisonDataGridView_Stock.Rows.Clear();
            string cliente = string.Empty;
            string producto = string.Empty;
            string formapago = string.Empty;

            foreach (var dato in await LogicaDetalleVenta.Instancia.ListarDetallesVentaAsync()) {
                foreach (var datocli in await LogicaCliente.Instancia.ListarClientesAsync()) {
                    if (dato.ClienteID == datocli.ClienteID) {
                        cliente = datocli.Nombre + " " + datocli.Apellido;
                    }
                }
                foreach (var datoprod in await LogicaProducto.Instancia.ListarProductos()) {
                    if (dato.ProductoID == datoprod.ProductoID) {
                        producto = datoprod.Modelo + " " + datoprod.Marca;
                    }
                }
                switch (dato.MedioPagoID) {
                    case 1:
                        formapago = "Transferencia";
                        break;
                    case 2:
                        formapago = "Efectivo";
                        break;
                    case 3:
                        formapago = "Credito";
                        break;

                    case 4:
                        formapago = "Crypto";
                        break;
                }


                poisonDataGridView_Stock.Rows.Add(dato.ClienteID, dato.ProductoID, dato.MedioPagoID, dato.Fecha, dato.DetalleVentaID, cliente, producto, formapago, dato.PlanCanje, dato.Cuotas, dato.Detalles);

                cliente = string.Empty;
                producto = string.Empty;
                formapago = string.Empty;
            }

        }


    }
}
