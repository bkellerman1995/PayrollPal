using PayrollPal.Layers.DAL;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers.BLL
{
    public class BLLDepartamento : IBLLDepartamento
    {
        #region SELECT ALL
        public List<Departamento> SelectAll()
        {
            IDALDepartamento dALDepartamento = new DALDepartamento();
            return dALDepartamento.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public Departamento SelectById(string Id)
        {
            IDALDepartamento dALDepartamento = new DALDepartamento();
            return dALDepartamento.SelectById(Id);
        }
        #endregion

        #region CREATE
        public void Create(Departamento pDepartamento)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearDepartamento(pDepartamento.IDDepartamento))
            {
                MessageBox.Show("El deprtamento con ID: " + pDepartamento.IDDepartamento + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    IDALDepartamento dALDepartamento = new DALDepartamento();
                    dALDepartamento.UPDATE(pDepartamento);
                }

            }
            else
            {
                IDALDepartamento dALDepartamento = new DALDepartamento();
                dALDepartamento.CREATE(pDepartamento);
            }

        }
        #endregion

        #region UPDATE
        public void Update(Departamento pDepartamento)
        {
            IDALDepartamento dALDepartamento = new DALDepartamento();
            dALDepartamento.UPDATE(pDepartamento);
        }
        #endregion

        #region DELETE
        public void Delete(string pIdDepartamento)
        {
            IDALDepartamento dALDepartamento = new DALDepartamento();
            dALDepartamento.DELETE(pIdDepartamento);
        }
        #endregion

        #region EXISTE
        public bool ChequearDepartamento(string pIDDepartamento)
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
