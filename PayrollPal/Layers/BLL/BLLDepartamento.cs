using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers.BLL
{
    public class BLLDepartamento
    {
        #region SELECT ALL
        public static List<Departamento> SelectAll()
        {
            return DAL.DALDepartamento.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public static Departamento SelectById(string Id)
        {
            return DAL.DALDepartamento.SelectById(Id);
        }
        #endregion

        #region CREATE
        public static void Create(Departamento pDepartamento)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearDepartamento(pDepartamento.IDDepartamento))
            {
                MessageBox.Show("El deprtamento con ID: " + pDepartamento.IDDepartamento + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALDepartamento.UPDATE(pDepartamento);
                }

            }
            else
            {
                DAL.DALDepartamento.CREATE(pDepartamento);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(Departamento pDepartamento)
        {
            DAL.DALDepartamento.UPDATE(pDepartamento);
        }
        #endregion

        #region DELETE
        public static void Delete(string pIdDepartamento)
        {
            DAL.DALDepartamento.DELETE(pIdDepartamento);
        }
        #endregion

        #region EXISTE
        public static bool ChequearDepartamento(string pIDDepartamento)
        {
            bool existe = false;

            if (SelectById(pIDDepartamento) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion
    }
}
