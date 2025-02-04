using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGN_predits.Conexiones.BD.Modelo {
    internal class Producto {
        public int ProductoID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Condicion { get; set; }
        public decimal Almacenamiento { get; set; }
        public decimal Bateria { get; set; }
        public int Stock { get; set; }
        public string Email { get; set; }   
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public string descripcion { get; set; }
    }
}
