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
    public class BLLRol
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public static List<Rol> SelectAll()
        {

            return DAL.DALRol.SelectAll();
        }
        #endregion

        #region AGREGAR o QUITAR IDs del combo

        public static List<int> IDRolesCombo()
        {
            List<int> roles = new List<int>();
            int contador = 3;

            for (int i = 1; i <= contador; i++)
            {
                if (SelectById(i) == null)
                {
                    roles.Add(i);
                }
            }
            return roles;
        }
        #endregion

        #region SELECT BY ID
        public static Rol SelectById(int Id)
        {
            return DAL.DALRol.SelectById(Id);
        }
        #endregion

        #region CREATE
        public static void Create(Rol pRol)
        {
            DAL.DALRol.CREATE(pRol);
        }

        #endregion

        #region DELETE
        public static void Delete(int pIDRol)
        {
            DAL.DALRol.DELETE(pIDRol);
        }
        #endregion

        #region SELECCIONA ROL COLABORADOR

        public static bool EsColaborador(Rol pRol)
        {
            if (pRol.IDRol == 3)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
