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

namespace PayrollPal.Layers.DAL
{
    public interface IDALPlanilla_Detalle
    {
        
        #region SecuenciadorPlanEncabezado

        string SecuenciadorPlanDetalle();


        #endregion

        #region SELECT ALL
        List<Planilla_Detalle> SelectAll();

        #endregion

        #region SELECT BY ID
        Planilla_Detalle SelectById(string Id);

        #endregion

        #region CREATE
        void CREATE(Planilla_Detalle pPlanilla_Detalle);

        #endregion

        #region UPDATE

        void UPDATE(Planilla_Detalle pPlanilla_Detalle);

        #endregion

        #region DELETE
        void DELETE(string pPlanillaDetalle);

        #endregion
    }
}
