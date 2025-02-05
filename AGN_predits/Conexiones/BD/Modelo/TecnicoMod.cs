using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGN_predits.Conexiones.BD.Modelo {
    internal class TecnicoMod {
        public int TecnicoID {  get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public decimal Bateria { get; set; }
        public string Falla { get; set; }
        public string Email { get; set; }
        public decimal Almacenamiento { get; set; }
        public decimal CostoArreglo { get; set; }
        public decimal Costo {  get; set; }

    }
}
