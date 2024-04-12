using PayrollPal.Entities;
using PayrollPal.Layers.DAL;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.IBLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers.BLL
{
    public class BLLControlDeMarcas : IBLLControlDeMarcas
    {
        #region CREATE

        public void CREATE(ControlDeMarcas control)
        {
            IDALControlDeMarcas dALControlDeMarcas = new DALControlDeMarcas();
            dALControlDeMarcas.CREATE(control);

        }

        #region UPDATE
        public void Update(ControlDeMarcas control)
        {
            IDALControlDeMarcas dALControlDeMarcas = new DALControlDeMarcas();
            dALControlDeMarcas.UPDATE(control);
        }
        #endregion

        #endregion
        #region SELECT ALL
        public List<ControlDeMarcas> SelectAll()
        {
            IDALControlDeMarcas dALControlDeMarcas = new DALControlDeMarcas();
            return dALControlDeMarcas.SelectAll();
        }
        #endregion

        #region DELETE
        public void DELETE()
        {
            IDALControlDeMarcas dALControlDeMarcas = new DALControlDeMarcas();
            dALControlDeMarcas.DELETE();
        }
        #endregion

        #region DELETEBYID
        public void DELETEBYID(int ID)
        {
            IDALControlDeMarcas dALControlDeMarcas = new DALControlDeMarcas();
            dALControlDeMarcas.DELETE();
        }
        #endregion
    }

}
