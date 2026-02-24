using System;

namespace AGN_predits.Conexiones.BD.Modelo {
    internal class MovimientoCaja {
        public int MovimientoID { get; set; }
        public string Tipo { get; set; }        // "Ingreso" o "Egreso"
        public decimal Monto { get; set; }
        public string MedioPago { get; set; }   // "Efectivo", "Transferencia", etc.
        public string Motivo { get; set; }
        public string Responsable { get; set; }
        public DateTime Fecha { get; set; }
    }
}
