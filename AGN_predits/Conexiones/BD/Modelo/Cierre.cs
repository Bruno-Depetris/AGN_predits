using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGN_predits.Conexiones.BD.Modelo {
    internal class Cierre {
        public int CierreID { get; set; }
        public decimal Transferencias { get; set; }
        public decimal Efectivo { get; set; }
        public decimal Tarjetas { get; set; }
        public decimal Crypto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
