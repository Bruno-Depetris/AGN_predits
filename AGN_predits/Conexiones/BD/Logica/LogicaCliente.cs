using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

using System.IO;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Globalization;
using System.Media;
using AGN_predits.Conexiones.BD.Modelo;
using MySql.Data.MySqlClient;



namespace AGN_predits.Conexiones.BD.Logica {
    internal class LogicaCliente {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;


        private static LogicaCliente _LogicaCliente;

        public static LogicaCliente Instancia {
            get {
                if (_LogicaCliente == null) {
                    _LogicaCliente = new LogicaCliente();

                }
                return _LogicaCliente;
            }
        }
        private MySqlConnection conn;
        public void Connect() {
         

            try {
                conn = new MySqlConnection(cadena);
                conn.Open();
                MessageBox.Show("Conexión exitosa.");
            } catch (Exception ex) {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

    }
}
