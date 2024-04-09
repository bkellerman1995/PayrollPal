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

namespace PayrollPal.Layers.BLL
{
    public class BLLPlanilla_Encabezado
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");


        #region SecuenciadorPlanEncabezado

        public static string SecuenciadorPlanEnc()
        {
            return DALPlanilla_Encabezado.SecuenciadorPlanEnc();
        }

        #endregion

        #region SELECT ALL
        public static List<Planilla_Encabezado> SelectAll()
        {

            return DAL.DALPlanilla_Encabezado.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public static Planilla_Encabezado SelectById(string Id)
        {
            return DAL.DALPlanilla_Encabezado.SelectById(Id);
        }
        #endregion

        #region CREATE
        public static void Create(Planilla_Encabezado pPlanillaEncabezado)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearPlanillaEncabezado(pPlanillaEncabezado.IdEncabezado))
            {
                MessageBox.Show("El encabezado de planilla con ID: " + pPlanillaEncabezado.IdEncabezado + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALPlanilla_Encabezado.UPDATE(pPlanillaEncabezado);
                }

            }
            else
            {
                DAL.DALPlanilla_Encabezado.CREATE(pPlanillaEncabezado);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(Planilla_Encabezado pPlanillaEncabezado)
        {
            DAL.DALPlanilla_Encabezado.UPDATE(pPlanillaEncabezado);
        }
        #endregion

        #region DELETE
        public static void Delete(string pIDPlanillaEncabezado)
        {
            DAL.DALPlanilla_Encabezado.DELETE(pIDPlanillaEncabezado);
        }
        #endregion

        #region EXISTE
        public static bool ChequearPlanillaEncabezado(string pIDPlanEnc)
        {
            bool existe = false;

            if (SelectById(pIDPlanEnc) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion
    }
}
