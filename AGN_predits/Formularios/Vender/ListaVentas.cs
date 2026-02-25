using AGN_predits.Conexiones.BD.Logica;
using AGN_predits.Conexiones.BD.Modelo;
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

namespace AGN_predits.Formularios.Vender {
    public partial class Lista_Ventas : Form {
        public Lista_Ventas() {
            InitializeComponent();
            label_Cargando.Hide();
            pictureBox_Cargando.Image = Image.FromFile("Gif/Dual Ring@1x-1.0s-200px-200px.gif");
            pictureBox_Cargando.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Cargando.Hide();
        }


        public async Task ActualizarDataGreed() {
            poisonDataGridView_Ventas.Rows.Clear();

            label_Cargando.Show();
            pictureBox_Cargando.Show();

            // 1️⃣ Cargar todos los datos en memoria
            var detallesVenta = await LogicaDetalleVenta.Instancia.ListarDetallesVentaAsync();
            var clientes = (await LogicaCliente.Instancia.ListarClientesAsync())
                           .ToDictionary(c => c.ClienteID, c => c); // Diccionario para búsqueda rápida
            var productos = (await LogicaProducto.Instancia.ListarProductos())
                            .ToDictionary(p => p.ProductoID, p => p); // Diccionario para búsqueda rápida

            // 2️⃣ Procesar datos
            foreach (var dato in detallesVenta) {
                // Obtener cliente rápidamente usando el diccionario
                string cliente = clientes.ContainsKey(dato.ClienteID)
                                 ? $"{clientes[dato.ClienteID].Nombre} {clientes[dato.ClienteID].Apellido}"
                                 : "Desconocido";

                // Obtener producto rápidamente usando el diccionario
                string producto = productos.ContainsKey(dato.ProductoID)
                                  ? $"{productos[dato.ProductoID].Modelo} {productos[dato.ProductoID].Marca}"
                                  : "Desconocido";

                string formapago = string.Empty;
                // Obtener forma de pago
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

                int rowIndex = poisonDataGridView_Ventas.Rows.Add(
                    dato.ClienteID,
                    dato.ProductoID,
                    dato.MedioPagoID,
                    dato.Fecha,
                    dato.DetalleVentaID,
                    cliente,
                    producto,
                    formapago,
                    dato.PlanCanje,
                    dato.Cuotas,
                    dato.Detalles
                );

                if (formapago == "Credito") {
                    poisonDataGridView_Ventas.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
                } else {
                    poisonDataGridView_Ventas.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }


            }

            label_Cargando.Hide();
            pictureBox_Cargando.Hide();
        }

        private async void Lista_Ventas_Load(object sender, EventArgs e) {
            label_Cargando.Show();
            pictureBox_Cargando.Show();
            await ActualizarDataGreed();
            label_Cargando.Hide();
            pictureBox_Cargando.Hide();

        }
        private void Imprimir(int rowIndex) {

            var seleccionarRow = poisonDataGridView_Ventas.Rows[rowIndex];

            var IDselected = seleccionarRow.Cells[0].Value;

            Console.Write(IDselected);

            DialogResult result = MessageBox.Show("Seguro que desea Imprimir?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                DetalleVenta datos = new DetalleVenta()
                {
                    DetalleVentaID = IDselected.GetHashCode(),

                };
                bool respuesta = await LogicaDetalleVenta.Instancia.GenerarPDFDetalleVentaAsync(datos);

            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private async void Borrar(int rowIndex) {
            var seleccionarRow = poisonDataGridView_Ventas.Rows[rowIndex];

            int IDselected = Convert.ToInt32(seleccionarRow.Cells[4].Value);

            DialogResult result = MessageBox.Show($"Seguro que desea borrar venta de ID {IDselected}?  ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Mensaje mensaje = new Mensaje();

            if (result == DialogResult.Yes) {
                pictureBox_Cargando.Show();
                label_Cargando.Show();
                if (await LogicaDetalleVenta.Instancia.EliminarDetalleVenta(IDselected)) {
                    await ActualizarDataGreed();

                    pictureBox_Cargando.Hide();
                    label_Cargando.Hide();

                    mensaje.Show($"{IDselected}", "Eliminado", Color.White, Color.White, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.Confirmacion);
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

        private void poisonDataGridView_Ventas_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                string columnName = poisonDataGridView_Ventas.Columns[e.ColumnIndex].Name;

                switch (columnName) {
                    case "Column_Imprimir":
                        Imprimir(e.RowIndex);
                        break;
                    case "Column_Borrar":
                        Borrar(e.RowIndex);
                        break;

                }
            }
        }
    }
}
