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
    public class BLLColaborador
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                         log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<Colaborador> SelectAll()
        {

            return DAL.DALColaborador.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public static Colaborador SelectById(string Id)
        {
            return DAL.DALColaborador.SelectById(Id);
        }
        #endregion

        #region SELECT Solo Colaboradores
        public static List<Colaborador> SelectSoloColaboradores()
        {

            return DAL.DALColaborador.SelectSoloColaboradores();
        }
        #endregion

        #region SELECT Colaborador BY ID Supervisor
        public static List<Colaborador> SelectColaboradorIdSupervisor(string Id)
        {
            return DAL.DALColaborador.SelectColaboradorIdSupervisor(Id);
        }

        #endregion

        #region CREATE
        public static void Create(Colaborador pColaborador)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearColaborador(pColaborador.IDColaborador))
            {
                MessageBox.Show("El colaborador con ID: " + pColaborador.IDUsuario + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALColaborador.UPDATE(pColaborador);
                }

            }
            else
            {
                DAL.DALColaborador.CREATE(pColaborador);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(Colaborador pColaborador)
        {
            DAL.DALColaborador.UPDATE(pColaborador);
        }
        #endregion

        #region DELETE
        public static void Delete(string pIdColaborador)
        {
            DAL.DALColaborador.DELETE(pIdColaborador);
        }
        #endregion

        #region EXISTE
        public static bool ChequearColaborador(string pColaborador)
        {
            bool existe = false;

            if (SelectById(pColaborador) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion
    }
}
