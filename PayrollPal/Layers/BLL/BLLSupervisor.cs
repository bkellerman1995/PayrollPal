using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace PayrollPal.Layers.BLL
{
    public class BLLSupervisor
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<Supervisor> SelectAll()
        {

            return DAL.DALSupervisor.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public static Supervisor SelectById(string Id)
        {
            return DAL.DALSupervisor.SelectById(Id);
        }
        #endregion

        #region CREATE
        public static void Create(Supervisor pSupervisor)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearSupervisor(pSupervisor.IDSupervisor))
            {
                MessageBox.Show("El supervisor con ID: " + pSupervisor.IDSupervisor + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALSupervisor.UPDATE(pSupervisor);
                }

            }
            else
            {
                DAL.DALSupervisor.CREATE(pSupervisor);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(Supervisor pSupervisor)
        {
            DAL.DALSupervisor.UPDATE(pSupervisor);
        }
        #endregion

        #region DELETE
        public static void Delete(string pIdSupervisor)
        {
            DAL.DALSupervisor.DELETE(pIdSupervisor);
        }
        #endregion

        #region EXISTE
        public static bool ChequearSupervisor(string pIdSupervisor)
        {
            bool existe = false;

            if (SelectById(pIdSupervisor) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion

    }
}
