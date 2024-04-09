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
using PayrollPal.Layers.DAL;

namespace PayrollPal.Layers.IBLL
{
    public interface IBLLPlanilla_Encabezado
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
        void Create(Planilla_Encabezado pPlanillaEncabezado);

        #endregion

        #region UPDATE
        void Update(Planilla_Encabezado pPlanillaEncabezado);

        #endregion

        #region DELETE
        void Delete(string pIDPlanillaEncabezado);

        #endregion

        #region EXISTE
        bool ChequearPlanillaEncabezado(string pIDPlanEnc);

        #endregion
    }
}
