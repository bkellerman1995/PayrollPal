using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Entities
{
    public class Planilla_Detalle
    {
        public string IdDetalle { set; get; }
        public Planilla_Encabezado IdEncabezado { set; get; }
        public Colaborador IdColaborador { set; get; }
        public string NombreColaborador { set; get; }
        public double hrsTrabajadas { set; get; }
        public double hrsExtras { set; get; }
        public double MontoHora { set; get; }
        public double SalarioBruto { set; get; }
        public Deducciones_Percepciones CodigoDeduccionPercepcion { set; get; }
        public string TipoDecPerc { set; get; }
        public double SalarioNeto { set; get; }

        public string devolverHorasTrabajadas
        {
            get { return hrsTrabajadas.ToString(); }
        }

        public string devolverHorasExtras
        {
            get { return hrsExtras.ToString(); }
        }
    }

}
