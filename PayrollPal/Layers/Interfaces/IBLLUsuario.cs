using PayrollPal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using PayrollPal.Layers.Entities;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PayrollPal.Layers.IBLL
{
    public interface IBLLUsuario
    {
        
                             

        #region SELECT ALL
        List<Usuario> SelectAll();

        #endregion

        #region SELECT ALL NO ASIGNADO
        List<Usuario> SelectAllNoAsignado();

        #endregion

        #region SELECT BY ID
        Usuario SelectById(string Id);

        #endregion

        #region CREATE
        void Create(Usuario pUsuario);

        #endregion

        #region UPDATE
        void Update(Usuario pUsuario);

        #endregion

        #region DELETE
        void Delete(string pIdUsuario);

        #endregion

        #region EXISTE
        bool ChequearUsuario(string pIDUsuario);

        #endregion

    }
}
