using PayrollPal.Entities;
using PayrollPal.Layers.Entities;
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

        #region UPDATE
        public static void Update(ControlDeMarcas control)
        {
            DAL.DALControlDeMarcas.UPDATE(control);
        }
        #endregion

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
