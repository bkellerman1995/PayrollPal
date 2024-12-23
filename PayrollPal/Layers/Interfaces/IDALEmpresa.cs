﻿using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Interfaces
{
    public interface IDALEmpresa
    {
        #region SELECT ALL
        Task<List<Empresa>> SelectAll();

        #endregion


        #region SELECT BY ID
        Empresa SelectById(string Id);

        #endregion

        #region CREATE
        void Create(Empresa pEmpresa);

        #endregion

        #region UPDATE
        void Update(Empresa pEmpresa);

        #endregion

        #region DELETE
        void Delete(string pEmpresa);

        #endregion

    }
}
