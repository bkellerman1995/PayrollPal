using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollPal.Entities;

namespace PayrollPal.Layers.DAL
{
    public interface IDALSupervisor
    {
        
                             

        #region SELECT ALL
        List<Supervisor> SelectAll();

        #endregion

        #region SecuenciadorSupervisor

        string SecuenciadorPuestoAumentar();


        #endregion

        #region SELECT BY ID
        Supervisor SelectById(string Id);

        #endregion

        #region CREATE
        void CREATE(Supervisor pSupervisor);

        #endregion

        #region UPDATE
        void UPDATE(Supervisor pSupervisor);

        #endregion

        #region DELETE
        void DELETE(string pIdSupervisor);

        #endregion
    }
}
