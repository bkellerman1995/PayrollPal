using PayrollPal.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers.BLL
{
    public class BLLControlDeMarcas
    {
        #region CREATE

        public static void CREATE(ControlDeMarcas control)
        {
            DAL.DALControlDeMarcas.CREATE(control);

        }

        #endregion
        #region SELECT ALL
        public static List<ControlDeMarcas> SelectAll()
        {
            return DAL.DALControlDeMarcas.SelectAll();
        }
        #endregion

        #region DELETE
        public static void DELETE()
        {
            DAL.DALControlDeMarcas.DELETE();
        }
        #endregion
    }

}
