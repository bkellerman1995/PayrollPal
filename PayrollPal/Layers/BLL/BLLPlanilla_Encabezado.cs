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
using PayrollPal.Layers.IBLL;

namespace PayrollPal.Layers.BLL
{
    public class BLLPlanilla_Encabezado : IBLLPlanilla_Encabezado
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");


        #region SecuenciadorPlanEncabezado

        public string SecuenciadorPlanEnc()
        {
            IDALPlanilla_Encabezado dALPlanilla_Encabezado = new DALPlanilla_Encabezado();
            return dALPlanilla_Encabezado.SecuenciadorPlanEnc();
        }

        #endregion

        #region SELECT ALL
        public List<Planilla_Encabezado> SelectAll()
        {
            IDALPlanilla_Encabezado dALPlanilla_Encabezado = new DALPlanilla_Encabezado();
            return dALPlanilla_Encabezado.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public Planilla_Encabezado SelectById(string Id)
        {
            IDALPlanilla_Encabezado dALPlanilla_Encabezado = new DALPlanilla_Encabezado();
            return dALPlanilla_Encabezado.SelectById(Id);
        }
        #endregion

        #region CREATE
        public void Create(Planilla_Encabezado pPlanillaEncabezado)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearPlanillaEncabezado(pPlanillaEncabezado.IdEncabezado))
            {
                MessageBox.Show("El encabezado de planilla con ID: " + pPlanillaEncabezado.IdEncabezado + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    IDALPlanilla_Encabezado dALPlanilla_Encabezado = new DALPlanilla_Encabezado();
                    dALPlanilla_Encabezado.UPDATE(pPlanillaEncabezado);
                }

            }
            else
            {
                IDALPlanilla_Encabezado dALPlanilla_Encabezado = new DALPlanilla_Encabezado();
                dALPlanilla_Encabezado.CREATE(pPlanillaEncabezado);
            }

        }
        #endregion

        #region UPDATE
        public void Update(Planilla_Encabezado pPlanillaEncabezado)
        {
            IDALPlanilla_Encabezado dALPlanilla_Encabezado = new DALPlanilla_Encabezado();
            dALPlanilla_Encabezado.UPDATE(pPlanillaEncabezado);
        }
        #endregion

        #region DELETE
        public void Delete(string pIDPlanillaEncabezado)
        {
            IDALPlanilla_Encabezado dALPlanilla_Encabezado = new DALPlanilla_Encabezado();
            dALPlanilla_Encabezado.DELETE(pIDPlanillaEncabezado);
        }
        #endregion

        #region EXISTE
        public bool ChequearPlanillaEncabezado(string pIDPlanEnc)
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
