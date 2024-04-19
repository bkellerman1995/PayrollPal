using PayrollPal.Layers.DAL;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.BLL
{
    public class BLLEmpresa : IBLLEmpresa
    {
        public bool ChequearEmpresa(string pIDEmpresa)
        {
            bool existe = false;

            IDALEmpresa dALEmpresa = new DALEmpresa();

            if (dALEmpresa.SelectById(pIDEmpresa) != null)
            {
                existe = true;
            }
            return existe;
        }

        public void Create(Empresa pEmpresa)
        {
            IDALEmpresa dALEmpresa = new DALEmpresa();
            dALEmpresa.Create(pEmpresa);
        }

        public void Delete(string pEmpresa)
        {
            IDALEmpresa dALEmpresa = new DALEmpresa();
            dALEmpresa.Delete(pEmpresa);
        }

        public Task<List<Empresa>> SelectAll()
        {
            IDALEmpresa dALEmpresa = new DALEmpresa();
            return dALEmpresa.SelectAll();
        }

        public Empresa SelectById(string Id)
        {
            IDALEmpresa dALEmpresa = new DALEmpresa();
            return dALEmpresa.SelectById(Id);
        }

        public void Update(Empresa pEmpresa)
        {
            IDALEmpresa dALEmpresa = new DALEmpresa();
            dALEmpresa.Update(pEmpresa);
        }
    }
}
