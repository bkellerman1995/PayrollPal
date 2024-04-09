using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace PayrollPal.Layers.IBLL
{
    public interface IBLLRol
    {

                             

        #region SELECT ALL
        List<Rol> SelectAll();

        #endregion

        #region AGREGAR o QUITAR IDs del combo

        List<int> IDRolesCombo();

        #endregion

        #region SELECT BY ID
        Rol SelectById(int Id);

        #endregion

        #region CREATE
        void Create(Rol pRol);


        #endregion

        #region DELETE
        void Delete(int pIDRol);

        #endregion

        #region SELECCIONA ROL COLABORADOR

        bool EsColaborador(Rol pRol);


        #endregion
    }
}
