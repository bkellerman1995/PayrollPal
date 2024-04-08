using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.DAL;

namespace PayrollPal.Layers.BLL
{
    public class BLLDeduccionesPercepciones
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorDeduccionesPercepciones

        public static string SecuenciadorDeduccionesPercepciones()
        {
            return DALDeduccionesPercepciones.SecuenciadorDeduccionesPercepciones();
        }

        #endregion

        #region SELECT ALL
        public static List<Deducciones_Percepciones> SelectAll()
        {

            return DAL.DALDeduccionesPercepciones.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public static Deducciones_Percepciones SelectById(string codigo)
        {
            return DAL.DALDeduccionesPercepciones.SelectById(codigo);
        }
        #endregion

        #region CREATE
        public static void Create(Deducciones_Percepciones pDeducciones_Percepciones)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearDeducciones_Percepciones(pDeducciones_Percepciones.CodigoDeduccionPercepcion))
            {
                MessageBox.Show("La deducción/percepción con código: " + pDeducciones_Percepciones.CodigoDeduccionPercepcion + " ya existe" +
                    "¿Desea actualizarla?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALDeduccionesPercepciones.UPDATE(pDeducciones_Percepciones);
                }

            }
            else
            {
                DAL.DALDeduccionesPercepciones.CREATE(pDeducciones_Percepciones);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(Deducciones_Percepciones pDeduccionesPercepciones)
        {
            DAL.DALDeduccionesPercepciones.UPDATE(pDeduccionesPercepciones);
        }
        #endregion

        #region DELETE
        public static void Delete(string pCodigoDeduccionesPercepciones)
        {
            DAL.DALDeduccionesPercepciones.DELETE(pCodigoDeduccionesPercepciones);
        }
        #endregion

        #region EXISTE
        public static bool ChequearDeducciones_Percepciones(string pCodigoDeduccionPercepcion)
        {
            bool existe = false;

            if (SelectById(pCodigoDeduccionPercepcion) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion

    }
}
