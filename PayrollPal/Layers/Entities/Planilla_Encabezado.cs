using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Entities
{
    public class Planilla_Encabezado
    {
        public string IdEncabezado { set; get; }
        public PlanillaPago Codigo { set; get; }
        public double TipoCambio { set; get; }
        public double TotalIngresos { set; get; }
        public double TotalGastos { set; get; }
        public double TotalPagar { set; get; }

        public override string ToString()
        {
            return IdEncabezado + " - " + Codigo;
        }
    }

}
