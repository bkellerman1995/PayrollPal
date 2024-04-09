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
using log4net;
using PayrollPal.Enumeraciones;

namespace PayrollPal.Layers.DAL
{
    public interface DALPlanillaPago
    {
        
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        List<PlanillaPago> SelectAll();

        #endregion

        #region SELECT BY ID
        PlanillaPago SelectById(string codigo);

        #endregion

        #region SecuenciadorPlanillaPago

        string SecuenciadorPlanillaPago();


        #endregion

        #region CREATE
        void CREATE(PlanillaPago pPlanillaPago);

        #endregion

        #region UPDATE

        void UPDATE(PlanillaPago pPlanillaPago);

        #endregion

        #region DELETE
        void DELETE(string pCodigoPlanilla);

        #endregion
    }
}
