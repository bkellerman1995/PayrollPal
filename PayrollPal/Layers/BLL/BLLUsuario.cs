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
using PayrollPal.Layers.IBLL;
using PayrollPal.Layers.DAL;

namespace PayrollPal.Layers.BLL
{
    public class BLLUsuario : IBLLUsuario
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        #region SELECT ALL
        public List<Usuario> SelectAll()
        {
            IDALUsuario _DALUsuario = new DALUsuario();
            return _DALUsuario.SelectAll();
        }
        #endregion

        #region SELECT ALL NO ASIGNADO
        public List<Usuario> SelectAllNoAsignado()
        {
            IDALUsuario _DALUsuario = new DALUsuario();
            return _DALUsuario.SelectAllNoAsignado();
        }
        #endregion

        #region SELECT BY ID
        public Usuario SelectById(string Id)
        {
            IDALUsuario _DALUsuario = new DALUsuario();
            return _DALUsuario.SelectById(Id);
        }
        #endregion

        #region CREATE
        public void Create(Usuario pUsuario)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearUsuario(pUsuario.IDUsuario))
            {
                MessageBox.Show("El usuario con ID: " + pUsuario.IDUsuario + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    IDALUsuario _DALUsuario = new DALUsuario();
                    _DALUsuario.UPDATE(pUsuario);
                }

            }
            else
            {
                IDALUsuario _DALUsuario = new DALUsuario();
                _DALUsuario.CREATE(pUsuario);
            }

        }
        #endregion

        #region UPDATE
        public void Update(Usuario pUsuario)
        {
            IDALUsuario _DALUsuario = new DALUsuario();
            _DALUsuario.UPDATE(pUsuario);
        }
        #endregion

        #region DELETE
        public void Delete(string pIdUsuario)
        {
            IDALUsuario _DALUsuario = new DALUsuario();
            _DALUsuario.DELETE(pIdUsuario);
        }
        #endregion

        #region EXISTE
        public bool ChequearUsuario(string pIDUsuario)
        {
            bool existe = false;

            IDALUsuario _DALUsuario = new DALUsuario();

            if (_DALUsuario.SelectById(pIDUsuario) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion

    }
}
