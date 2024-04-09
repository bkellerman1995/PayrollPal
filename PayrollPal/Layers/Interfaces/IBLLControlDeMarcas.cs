using PayrollPal.Entities;
using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers.IBLL
{
    public interface IBLLControlDeMarcas
    {
        #region CREATE

        void CREATE(ControlDeMarcas control);


        #region UPDATE
        void Update(ControlDeMarcas control);

        #endregion

        #endregion
        #region SELECT ALL
        List<ControlDeMarcas> SelectAll();

        #endregion

        #region DELETE
        void DELETE();

        #endregion
    }

}
