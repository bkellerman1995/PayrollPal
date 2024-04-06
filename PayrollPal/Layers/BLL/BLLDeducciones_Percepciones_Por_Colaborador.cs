using PayrollPal.Enumeraciones;
using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers.BLL
{
    public class BLLDeducciones_Percepciones_Por_Colaborador
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                     log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<Deducciones_Percepciones_Por_Colaborador> SelectAll()
        {

            return DAL.DALDeducciones_Percepciones_Por_Colaborador.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public static Deducciones_Percepciones_Por_Colaborador SelectById(string codigoDeduccionPercepcion, string idColaborador)
        {
            return DAL.DALDeducciones_Percepciones_Por_Colaborador.SelectById(codigoDeduccionPercepcion, idColaborador);
        }
        #endregion

        #region CREATE
        public static void Create(Deducciones_Percepciones_Por_Colaborador pDedPercColab)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearpDedPercColab(pDedPercColab.CodigoDeduccionPercepcion.ToString(), pDedPercColab.IdColaborador.ToString()))
            {
                MessageBox.Show("La deducción/percepción para el colaborador: " + pDedPercColab.CodigoDeduccionPercepcion.ToString() + " ya existe" +
                    "¿Desea actualizarla?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALDeducciones_Percepciones_Por_Colaborador.UPDATE(pDedPercColab);
                }

            }
            else
            {
                DAL.DALDeducciones_Percepciones_Por_Colaborador.CREATE(pDedPercColab);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(Deducciones_Percepciones_Por_Colaborador pDedPercColab)
        {
            DAL.DALDeducciones_Percepciones_Por_Colaborador.UPDATE(pDedPercColab);
        }
        #endregion

        #region DELETE
        public static void Delete(string pCodigoDeduccionPercepcion, string pIdColaborador)
        {
            DAL.DALDeducciones_Percepciones_Por_Colaborador.DELETE(pCodigoDeduccionPercepcion, pIdColaborador);
        }
        #endregion

        #region EXISTE
        public static bool ChequearpDedPercColab(string pCodigoDeduccionPercepcion, string pIDColaborador)
        {
            bool existe = false;

            if (SelectById(pCodigoDeduccionPercepcion, pIDColaborador) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion
    }
}
