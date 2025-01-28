using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGN_predits.Conexiones.BD.Modelo {
    internal class DetalleVenta {
        public int DetalleVentaID { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteID { get; set; }
        public int ProductoID { get; set; }
        public int MedioPagoID { get; set; }
    }
}
