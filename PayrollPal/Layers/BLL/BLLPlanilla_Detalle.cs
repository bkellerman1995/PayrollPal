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
using PayrollPal.Layers.IBLL;

namespace PayrollPal.Layers.BLL
{

    public class BLLPlanilla_Detalle : IBLLPlanilla_Detalle
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                     log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorPlanEncabezado

        public string SecuenciadorPlanDetalle()
        {
            DALPlanilla_Encabezado dALPlanilla_Encabezado = new DALPlanilla_Encabezado();
            return dALPlanilla_Encabezado.SecuenciadorPlanEnc();
        }
        #endregion

        #region SELECT ALL
        public List<Planilla_Detalle> SelectAll()
        {
            IDALPlanilla_Detalle dALPlanilla_Detalle = new DALPlanilla_Detalle();
            return dALPlanilla_Detalle.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public Planilla_Detalle SelectById(string Id)
        {
            IDALPlanilla_Detalle dALPlanilla_Detalle = new DALPlanilla_Detalle();
            return dALPlanilla_Detalle.SelectById(Id);
        }
        #endregion

        #region CREATE
        public void Create(Planilla_Detalle pPlanillaDetalle)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearPlanillaDetalle(pPlanillaDetalle.IdDetalle))
            {
                MessageBox.Show("El detalle de planilla con ID: " + pPlanillaDetalle.IdDetalle + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    IDALPlanilla_Detalle dALPlanilla_Detalle = new DALPlanilla_Detalle();
                    dALPlanilla_Detalle.UPDATE(pPlanillaDetalle);
                }

            }
            else
            {
                IDALPlanilla_Detalle dALPlanilla_Detalle = new DALPlanilla_Detalle();
                dALPlanilla_Detalle.CREATE(pPlanillaDetalle);
            }

        }
        #endregion

        #region UPDATE
        public void Update(Planilla_Detalle pPlanillaDetalle)
        {
            IDALPlanilla_Detalle dALPlanilla_Detalle = new DALPlanilla_Detalle();
            dALPlanilla_Detalle.UPDATE(pPlanillaDetalle);
        }
        #endregion

        #region DELETE
        public void Delete(string pPlanillaDetalle)
        {
            IDALPlanilla_Detalle dALPlanilla_Detalle = new DALPlanilla_Detalle();
            dALPlanilla_Detalle.DELETE(pPlanillaDetalle);
        }
        #endregion

        #region EXISTE
        public bool ChequearPlanillaDetalle(string pIDPlanDet)
        {
            bool existe = false;

            if (SelectById(pIDPlanDet) != null)
            {
                existe = true;
            }
            return existe;
        }
        #endregion

        #region CALCULAR SALARIO BRUTO

        public decimal CalcularSalarioBruto(Planilla_Detalle planillaDetalle)
        {
            decimal resultado = 0;

            if (planillaDetalle.hrsTrabajadas >=0)
                resultado += (decimal)planillaDetalle.hrsTrabajadas * planillaDetalle.MontoHora;
            if (planillaDetalle.hrsExtras > 0)
                resultado += (decimal)planillaDetalle.hrsExtras * (planillaDetalle.MontoHora) *(decimal)1.5;

            return resultado;
        }

        #endregion

        #region CALCULAR SALARIO NETO

        public decimal CalcularSalarioNeto(Planilla_Detalle planillaDetalle)
        {
            decimal deducciones = 0;
            decimal percepciones = 0;
            IBLLDeduccionesPercepciones bLLDeduccionesPercepciones = new BLLDeduccionesPercepciones();

            foreach (var item in planillaDetalle.deducciones_Percepciones_Por_Colaborador)
            {
                Deducciones_Percepciones decPerc = bLLDeduccionesPercepciones.SelectById(item.CodigoDeduccionPercepcion.CodigoDeduccionPercepcion);
                if (decPerc.Tipo == Enumeraciones.TipoPercepcionDeduccion.Deduccion)
                {
                    if (item.Prioridad == Enumeraciones.PrioridadDeduccionPercepcion.Alta)
                    {
                        if (decPerc.TipoValor == Enumeraciones.TipoPorcAbs.Porcentaje)
                        {
                            deducciones += CalcularSalarioBruto(planillaDetalle) * (decimal)(decPerc.Valor / 100);
                        }
                        else
                        {
                            deducciones += (decimal)(decPerc.Valor);
                        }

                        if (deducciones >= CalcularSalarioBruto(planillaDetalle))
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (decPerc.TipoValor == Enumeraciones.TipoPorcAbs.Porcentaje)
                        {
                            deducciones += CalcularSalarioBruto(planillaDetalle) * (decimal)(decPerc.Valor / 100);
                        }
                        else
                        {
                            deducciones += CalcularSalarioBruto(planillaDetalle) * (decimal)(decPerc.Valor);
                        }
                        if (deducciones >= CalcularSalarioBruto(planillaDetalle))
                        {
                            break;
                        }
                    }

                }
                else
                {
                    if (decPerc.TipoValor == Enumeraciones.TipoPorcAbs.Porcentaje)
                    {
                        percepciones += CalcularSalarioBruto(planillaDetalle) * (decimal)(decPerc.Valor / 100);
                    }
                    else
                    {
                        percepciones += CalcularSalarioBruto(planillaDetalle) * (decimal)(decPerc.Valor);
                    }
                }
            }

            return CalcularSalarioBruto(planillaDetalle) - deducciones + percepciones;
        }

        #endregion

        #region CALCULAR SALARIO DÓLARES

        public decimal CalcularSalarioDolares(Planilla_Detalle planillaDetalle, decimal dolar)
        {
            return Math.Round(CalcularSalarioNeto(planillaDetalle) / dolar,2);
        }

        #endregion


    }
}
