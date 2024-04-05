using PayrollPal.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Entities
{
    public class Deducciones_Percepciones_Por_Colaborador
    {
        public Deducciones_Percepciones CodigoDeduccionPercepcion { set; get; }
        public Colaborador IdColaborador { set; get; }
        public PrioridadDeduccionPercepcion Prioridad { set; get; }
    }

}
