using PayrollPal.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Entities
{
    public class PlanillaPago
    {
        public string Codigo { set; get; }
        public string Nombre { set; get; }
        public DateTime FechaDesde { set; get; }
        public DateTime FechaHasta { set; get; }
        public DateTime FechaPago { set; get; }
        public PlanillaEstado Estado { set; get; }

        public override string ToString()
        {
            return Codigo + " - " + Nombre;
        }
    }

}
