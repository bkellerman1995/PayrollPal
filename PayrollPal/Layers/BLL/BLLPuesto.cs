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
using PayrollPal.Layers.DAL;

namespace PayrollPal.Layers.BLL
{
    public class BLLPuesto
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                     log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<Puesto> SelectAll()
        {

            return DAL.DALPuesto.SelectAll();
        }
        #endregion

        #region SecuenciadorPuesto

        public static string SecuenciadorPuesto()
        {
            return DALPuesto.SecuenciadorPuestoAumentar();
        }

        #endregion

        #region SELECT BY ID
        public static Puesto SelectById(string Id)
        {
            return DAL.DALPuesto.SelectById(Id);
        }
        #endregion

        #region CREATE
        public static void Create(Puesto pPuesto)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearPuesto(pPuesto.CodigoPuesto))
            {
                MessageBox.Show("El puesto con código: " + pPuesto.CodigoPuesto + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALPuesto.UPDATE(pPuesto);
                }

            }
            else
            {
                DAL.DALPuesto.CREATE(pPuesto);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(Puesto pPuesto)
        {
            DAL.DALPuesto.UPDATE(pPuesto);
        }
        #endregion

        #region DELETE
        public static void Delete(string pCodigoPuesto)
        {
            DAL.DALPuesto.DELETE(pCodigoPuesto);
        }
        #endregion

        #region EXISTE
        public static bool ChequearPuesto(string pCodigoPuesto)
        {
            bool existe = false;

            if (SelectById(pCodigoPuesto) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion
    }
}
