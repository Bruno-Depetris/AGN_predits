using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGN_predits.Conexiones.BD.Logica {
    internal class LogicaProducto {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;


        private static LogicaProducto _LogicaProducto;

        public static LogicaProducto Instancia {
            get {
                if (_LogicaProducto == null) {
                    _LogicaProducto = new LogicaProducto();

                }
                return _LogicaProducto;
            }
        }

        private void CargarProducto() {
            try {

            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
    }

}
