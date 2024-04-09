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
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Util;

namespace PayrollPal.Layers.DAL
{
    public interface IDALPlanilla_Encabezado
    {
        
                             

        #region SecuenciadorPlanEncabezado

        string SecuenciadorPlanEnc();


        #endregion

        #region SELECT ALL
        List<Planilla_Encabezado> SelectAll();

        #endregion

        #region SELECT BY ID
        Planilla_Encabezado SelectById(string Id);

        #endregion

        #region CREATE
        void CREATE(Planilla_Encabezado pPlanillaEncabezado);

        #endregion

        #region UPDATE

        void UPDATE(Planilla_Encabezado pPlanillaEncabezado);

        #endregion

        #region DELETE
        void DELETE(string pIDPlanillaEnc);

        #endregion
    }
}
