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
using PayrollPal.Layers.IBLL;

namespace PayrollPal.Layers.BLL 
{
    public class BLLPuesto : IBLLPuesto
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                     log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public List<Puesto> SelectAll()
        {
            IDALPuesto dALPuesto = new DALPuesto();
            return dALPuesto.SelectAll();
        }
        #endregion

        #region SecuenciadorPuesto

        public string SecuenciadorPuesto()
        {
            IDALPuesto dALPuesto = new DALPuesto();
            return dALPuesto.SecuenciadorPuestoAumentar();
        }

        #endregion

        #region SELECT BY ID
        public Puesto SelectById(string Id)
        {
            IDALPuesto dALPuesto = new DALPuesto();
            return dALPuesto.SelectById(Id);
        }
        #endregion

        #region CREATE
        public void Create(Puesto pPuesto)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearPuesto(pPuesto.CodigoPuesto))
            {
                MessageBox.Show("El puesto con código: " + pPuesto.CodigoPuesto + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    IDALPuesto dALPuesto = new DALPuesto();
                    dALPuesto.UPDATE(pPuesto);
                }

            }
            else
            {
                IDALPuesto dALPuesto = new DALPuesto();
                dALPuesto.CREATE(pPuesto);
            }

        }
        #endregion

        #region UPDATE
        public void Update(Puesto pPuesto)
        {
            IDALPuesto dALPuesto = new DALPuesto();
            dALPuesto.UPDATE(pPuesto);
        }
        #endregion

        #region DELETE
        public void Delete(string pCodigoPuesto)
        {
            IDALPuesto dALPuesto = new DALPuesto();
            dALPuesto.DELETE(pCodigoPuesto);
        }
        #endregion

        #region EXISTE
        public bool ChequearPuesto(string pCodigoPuesto)
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
