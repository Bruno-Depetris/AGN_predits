using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheParfum.APIs.Modelos {
    internal class ModeloApiCotizacion {
        public string Moneda { get; set; }
        public string Casa { get; set; }
        public string Nombre { get; set; }
        public float Compra { get; set; }
        public float Venta { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}