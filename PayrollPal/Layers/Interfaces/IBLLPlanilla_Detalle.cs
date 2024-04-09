using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.Util;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using PayrollPal.Layers.DAL;

namespace PayrollPal.Layers.IBLL
{

    public interface IBLLPlanilla_Detalle
    {

                     

        #region SecuenciadorPlanEncabezado

        string SecuenciadorPlanDetalle();

        #endregion

        #region SELECT ALL
        List<Planilla_Detalle> SelectAll();

        #endregion

        #region SELECT BY ID
        Planilla_Detalle SelectById(string Id);

        #endregion

        #region CREATE
        void Create(Planilla_Detalle pPlanillaDetalle);

        #endregion

        #region UPDATE
        void Update(Planilla_Detalle pPlanillaDetalle);

        #endregion

        #region DELETE
        void Delete(string pPlanillaDetalle);

        #endregion

        #region EXISTE
        bool ChequearPlanillaDetalle(string pIDPlanDet);

        #endregion

        #region CALCULAR SALARIO BRUTO

        decimal CalcularSalarioBruto(Planilla_Detalle planillaDetalle);


        #endregion

        #region CALCULAR SALARIO NETO

        decimal CalcularSalarioNeto(Planilla_Detalle planillaDetalle);


        #endregion

        #region CALCULAR SALARIO DÓLARES

        decimal CalcularSalarioDolares(Planilla_Detalle planillaDetalle, decimal dolar);
 

        #endregion

    }
}
