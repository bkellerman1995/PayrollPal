using PayrollPal.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Entities
{
    public class Deducciones_Percepciones
    {
        public string CodigoDeduccionPercepcion { set; get; }
        public string Nombre { set; get; }
        public TipoPercepcionDeduccion Tipo { set; get; }
        public double Valor { set; get; }
        public TipoPorcAbs TipoValor { set; get; }

        public override string ToString()
        {
            return CodigoDeduccionPercepcion + " - " + Nombre +
                " - " + Valor + "- " + TipoValor;
        }
    }

}
