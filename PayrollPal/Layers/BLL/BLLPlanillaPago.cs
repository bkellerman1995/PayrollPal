using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.DAL;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.IBLL;

namespace PayrollPal.Layers.BLL
{
    public class BLLPlanillaPago : IBLLPlanillaPago
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorPlanillasPago

        public string SecuenciadorPlanillasPago()
        {
            IDALPlanillaPago dALPlanillaPago = new DALPlanillaPago();
            return dALPlanillaPago.SecuenciadorPlanillaPago();
        }
        #endregion

        #region SELECT ALL
        public List<PlanillaPago> SelectAll()
        {
            IDALPlanillaPago dALPlanillaPago = new DALPlanillaPago();
            return dALPlanillaPago.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public PlanillaPago SelectById(string codigo)
        {
            IDALPlanillaPago dALPlanillaPago = new DALPlanillaPago();
            return dALPlanillaPago.SelectById(codigo);
        }
        #endregion

        #region CREATE
        public void Create(PlanillaPago pPlanillaPago)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearPlanillaPago(pPlanillaPago.Codigo))
            {
                MessageBox.Show("La planilla de pago con el código: " + pPlanillaPago.Codigo + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    IDALPlanillaPago dALPlanillaPago = new DALPlanillaPago();
                    dALPlanillaPago.UPDATE(pPlanillaPago);
                }

            }
            else
            {
                IDALPlanillaPago dALPlanillaPago = new DALPlanillaPago();
                dALPlanillaPago.CREATE(pPlanillaPago);
            }

        }
        #endregion

        #region UPDATE
        public void Update(PlanillaPago pPlanillaPago)
        {
            IDALPlanillaPago dALPlanillaPago = new DALPlanillaPago();
            dALPlanillaPago.UPDATE(pPlanillaPago);
        }
        #endregion

        #region DELETE
        public void Delete(string pCodigoPlanillaPago)
        {
            IDALPlanillaPago dALPlanillaPago = new DALPlanillaPago();
            dALPlanillaPago.DELETE(pCodigoPlanillaPago);
        }
        #endregion

        #region EXISTE
        public bool ChequearPlanillaPago(string pCodigoPlanillaPago)
        {
            bool existe = false;

            if (SelectById(pCodigoPlanillaPago) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion

    }
}
