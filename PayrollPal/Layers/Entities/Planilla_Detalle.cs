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
        public decimal MontoHora { set; get; }
        public decimal SalarioBruto { set; get; }
        public List<Deducciones_Percepciones_Por_Colaborador> deducciones_Percepciones_Por_Colaborador { set; get; }
        public decimal SalarioNeto { set; get; }

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
