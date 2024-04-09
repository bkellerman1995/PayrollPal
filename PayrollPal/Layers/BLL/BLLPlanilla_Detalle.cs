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

namespace PayrollPal.Layers.BLL
{

    public class BLLPlanilla_Detalle
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                     log4net.LogManager.GetLogger("MyControlEventos");

        #region SecuenciadorPlanEncabezado

        public static string SecuenciadorPlanDetalle()
        {
            return DALPlanilla_Encabezado.SecuenciadorPlanEnc();
        }
        #endregion

        #region SELECT ALL
        public static List<Planilla_Detalle> SelectAll()
        {

            return DAL.DALPlanilla_Detalle.SelectAll();
        }
        #endregion

        #region SELECT BY ID
        public static Planilla_Detalle SelectById(string Id)
        {
            return DAL.DALPlanilla_Detalle.SelectById(Id);
        }
        #endregion

        #region CREATE
        public static void Create(Planilla_Detalle pPlanillaDetalle)
        {
            DialogResult resultado = new DialogResult();

            if (ChequearPlanillaDetalle(pPlanillaDetalle.IdDetalle))
            {
                MessageBox.Show("El detalle de planilla con ID: " + pPlanillaDetalle.IdDetalle + " ya existe" +
                    "¿Desea actualizarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DAL.DALPlanilla_Detalle.UPDATE(pPlanillaDetalle);
                }

            }
            else
            {
                DAL.DALPlanilla_Detalle.CREATE(pPlanillaDetalle);
            }

        }
        #endregion

        #region UPDATE
        public static void Update(Planilla_Detalle pPlanillaDetalle)
        {
            DAL.DALPlanilla_Detalle.UPDATE(pPlanillaDetalle);
        }
        #endregion

        #region DELETE
        public static void Delete(string pPlanillaDetalle)
        {
            DAL.DALPlanilla_Detalle.DELETE(pPlanillaDetalle);
        }
        #endregion

        #region EXISTE
        public static bool ChequearPlanillaDetalle(string pIDPlanDet)
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

        public static decimal CalcularSalarioBruto(Planilla_Detalle planillaDetalle)
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

        public static decimal CalcularSalarioNeto(Planilla_Detalle planillaDetalle)
        {
            decimal deducciones = 0;
            decimal percepciones = 0;

            foreach (var item in planillaDetalle.deducciones_Percepciones_Por_Colaborador)
            {
                Deducciones_Percepciones decPerc = BLLDeduccionesPercepciones.SelectById(item.CodigoDeduccionPercepcion.CodigoDeduccionPercepcion);
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

        public static decimal CalcularSalarioDolares(Planilla_Detalle planillaDetalle, decimal dolar)
        {
            return Math.Round(CalcularSalarioNeto(planillaDetalle) / dolar,2);
        }

        #endregion

    }
}
