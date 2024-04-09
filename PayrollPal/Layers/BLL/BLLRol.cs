using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.IBLL;
using PayrollPal.Layers.DAL;

namespace PayrollPal.Layers.BLL 
{
    public class BLLRol : IBLLRol
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public List<Rol> SelectAll()
        {
            IDALRol dALRol = new DALRol();
            return dALRol.SelectAll();
        }
        #endregion

        #region AGREGAR o QUITAR IDs del combo

        public List<int> IDRolesCombo()
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
        public Rol SelectById(int Id)
        {
            IDALRol dALRol = new DALRol();
            return dALRol.SelectById(Id);
        }
        #endregion

        #region CREATE
        public void Create(Rol pRol)
        {
            IDALRol dALRol = new DALRol();
            dALRol.CREATE(pRol);
        }

        #endregion

        #region DELETE
        public void Delete(int pIDRol)
        {
            IDALRol dALRol = new DALRol();
            dALRol.DELETE(pIDRol);
        }
        #endregion

        #region SELECCIONA ROL COLABORADOR

        public bool EsColaborador(Rol pRol)
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
