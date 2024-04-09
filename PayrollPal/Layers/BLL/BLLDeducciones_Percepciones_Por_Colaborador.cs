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
using PayrollPal.Layers.IBLL;
using PayrollPal.Layers.DAL;

namespace PayrollPal.Layers.BLL
{
    public class BLLDeducciones_Percepciones_Por_Colaborador : IBLLDeducciones_Percepciones_Por_Colaborador
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                     log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public List<Deducciones_Percepciones_Por_Colaborador> SelectAll()
        {
            IDALDeducciones_Percepciones_Por_Colaborador dALDeducciones_Percepciones_Por_Colaborador = new DALDeducciones_Percepciones_Por_Colaborador();
            return dALDeducciones_Percepciones_Por_Colaborador.SelectAll();
        }
        #endregion

        #region SELECT TODOS    
        public List<Deducciones_Percepciones_Por_Colaborador> SelectTodo()
        {
            IDALDeducciones_Percepciones_Por_Colaborador dALDeducciones_Percepciones_Por_Colaborador = new DALDeducciones_Percepciones_Por_Colaborador();
            return dALDeducciones_Percepciones_Por_Colaborador.SelectTodo();
        }
        #endregion

        #region SELECT BY ID
        public Deducciones_Percepciones_Por_Colaborador SelectById(string codigoDeduccionPercepcion, string idColaborador)
        {
            IDALDeducciones_Percepciones_Por_Colaborador dALDeducciones_Percepciones_Por_Colaborador = new DALDeducciones_Percepciones_Por_Colaborador();
            return dALDeducciones_Percepciones_Por_Colaborador.SelectById(codigoDeduccionPercepcion, idColaborador);
        }
        #endregion

        #region CREATE
        public void Create(Deducciones_Percepciones_Por_Colaborador pDedPercColab)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearpDedPercColab(pDedPercColab.CodigoDeduccionPercepcion.ToString(), pDedPercColab.IdColaborador.ToString()))
            {
                MessageBox.Show("La deducción/percepción para el colaborador: " + pDedPercColab.CodigoDeduccionPercepcion.ToString() + " ya existe" +
                    "¿Desea actualizarla?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    IDALDeducciones_Percepciones_Por_Colaborador dALDeducciones_Percepciones_Por_Colaborador = new DALDeducciones_Percepciones_Por_Colaborador();
                    dALDeducciones_Percepciones_Por_Colaborador.UPDATE(pDedPercColab);
                }

            }
            else
            {
                IDALDeducciones_Percepciones_Por_Colaborador dALDeducciones_Percepciones_Por_Colaborador = new DALDeducciones_Percepciones_Por_Colaborador();
                dALDeducciones_Percepciones_Por_Colaborador.CREATE(pDedPercColab);
            }

        }
        #endregion

        #region UPDATE
        public void Update(Deducciones_Percepciones_Por_Colaborador pDedPercColab)
        {
            IDALDeducciones_Percepciones_Por_Colaborador dALDeducciones_Percepciones_Por_Colaborador = new DALDeducciones_Percepciones_Por_Colaborador();
            dALDeducciones_Percepciones_Por_Colaborador.UPDATE(pDedPercColab);
        }
        #endregion

        #region DELETE
        public void Delete(string pCodigoDeduccionPercepcion, string pIdColaborador)
        {
            IDALDeducciones_Percepciones_Por_Colaborador dALDeducciones_Percepciones_Por_Colaborador = new DALDeducciones_Percepciones_Por_Colaborador();
            dALDeducciones_Percepciones_Por_Colaborador.DELETE(pCodigoDeduccionPercepcion, pIdColaborador);
        }
        #endregion

        #region EXISTE
        public bool ChequearpDedPercColab(string pCodigoDeduccionPercepcion, string pIDColaborador)
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
