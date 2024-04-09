using PayrollPal.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollPal.Layers.Entities;
using System.Reflection;
using log4net;

namespace PayrollPal.Layers.DAL
{
    public interface DALControlDeMarcas
    {
        
                             log4net.LogManager.GetLogger("MyControlEventos");
        #region CREATE  
        void CREATE(ControlDeMarcas control);

        #endregion

        #region UPDATE
        void UPDATE(ControlDeMarcas control);

        #endregion

        #region SELECT ALL
        List<ControlDeMarcas> SelectAll();


        #endregion

        #region DELETE
        void DELETE();
		 
        #endregion

    }
}
