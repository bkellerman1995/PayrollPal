using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.DAL;
using PayrollPal.Layers.Entities;

namespace PayrollPal.Layers.IBLL
{
    public interface IBLLPlanillaPago
    {

                             

        #region SecuenciadorPlanillasPago

        string SecuenciadorPlanillasPago();

        #endregion

        #region SELECT ALL
        List<PlanillaPago> SelectAll();

        #endregion

        #region SELECT BY ID
        PlanillaPago SelectById(string codigo);

        #endregion

        #region CREATE
        void Create(PlanillaPago pPlanillaPago);

        #endregion

        #region UPDATE
        void Update(PlanillaPago pPlanillaPago);
        #endregion

        #region DELETE
        void Delete(string pCodigoPlanillaPago);
        #endregion

        #region EXISTE
        bool ChequearPlanillaPago(string pCodigoPlanillaPago);

        #endregion

    }
}
