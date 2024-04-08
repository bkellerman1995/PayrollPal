using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.DAL;
using PayrollPal.Layers.Entities;

namespace PayrollPal.Layers.BLL
{
    public class BLLPlanillaPago
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorPlanillasPago

        public static string SecuenciadorPlanillasPago()
        {
            return DALPlanillaPago.SecuenciadorPlanillaPago();
        }
        #endregion

        #region SELECT ALL
        public static List<PlanillaPago> SelectAll()
        {

            return DAL.DALPlanillaPago.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public static PlanillaPago SelectById(string codigo)
        {
            return DAL.DALPlanillaPago.SelectById(codigo);
        }
        #endregion

        #region CREATE
        public static void Create(PlanillaPago pPlanillaPago)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearPlanillaPago(pPlanillaPago.Codigo))
            {
                MessageBox.Show("La planilla de pago con el código: " + pPlanillaPago.Codigo + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALPlanillaPago.UPDATE(pPlanillaPago);
                }

            }
            else
            {
                DAL.DALPlanillaPago.CREATE(pPlanillaPago);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(PlanillaPago pPlanillaPago)
        {
            DAL.DALPlanillaPago.UPDATE(pPlanillaPago);
        }
        #endregion

        #region DELETE
        public static void Delete(string pCodigoPlanillaPago)
        {
            DAL.DALPlanillaPago.DELETE(pCodigoPlanillaPago);
        }
        #endregion

        #region EXISTE
        public static bool ChequearPlanillaPago(string pCodigoPlanillaPago)
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
