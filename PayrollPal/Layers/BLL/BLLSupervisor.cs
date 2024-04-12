using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.DAL;
using PayrollPal.Layers.IBLL;

namespace PayrollPal.Layers.BLL
{
    public class BLLSupervisor : IBLLSupervisor
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public List<Supervisor> SelectAll()
        {
            IDALSupervisor dALSupervisor = new DALSupervisor();
            return dALSupervisor.SelectAll();
        }
        #endregion

        #region SecuenciadorSupervisor

        public string SecuenciadorPuesto()
        {
            IDALSupervisor dALSupervisor = new DALSupervisor();
            return dALSupervisor.SecuenciadorPuestoAumentar();
        }

        #endregion

        #region SELECT BY ID
        public Supervisor SelectById(string Id)
        {
            IDALSupervisor dALSupervisor = new DALSupervisor();
            return dALSupervisor.SelectById(Id);
        }
        #endregion

        #region CREATE
        public void Create(Supervisor pSupervisor)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearSupervisor(pSupervisor.IDSupervisor))
            {
                MessageBox.Show("El supervisor con ID: " + pSupervisor.IDSupervisor + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    IDALSupervisor dALSupervisor = new DALSupervisor();
                    dALSupervisor.UPDATE(pSupervisor);
                }

            }
            else
            {
                IDALSupervisor dALSupervisor = new DALSupervisor();
                dALSupervisor.CREATE(pSupervisor);
            }

        }
        #endregion

        #region UPDATE
        public void Update(Supervisor pSupervisor)
        {
            IDALSupervisor dALSupervisor = new DALSupervisor();
            dALSupervisor.UPDATE(pSupervisor);
        }
        #endregion

        #region DELETE
        public void Delete(string pIdSupervisor)
        {
            IDALSupervisor dALSupervisor = new DALSupervisor();
            dALSupervisor.DELETE(pIdSupervisor);
        }
        #endregion

        #region EXISTE
        public bool ChequearSupervisor(string pIdSupervisor)
        {
            bool existe = false;

            if (SelectById(pIdSupervisor) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion

        #region SELECT ALL NO ASIGNADO
        public List<Supervisor> SelectAllNoAsignado()
        {
            IDALSupervisor dALSupervisor = new DALSupervisor();
            return dALSupervisor.SelectAllNoAsignado();
        }
        #endregion

    }
}
