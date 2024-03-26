﻿using PayrollPal.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPal.Layers.DAL
{
    public class DALControlDeMarcas
    {
        #region CREATE  
        public static void CREATE (ControlDeMarcas control)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_ControlDeMarcas");
                    command.Parameters.AddWithValue("@idMarca", control.idMarca);
                    command.Parameters.AddWithValue("@IdColaborador", control.IdColaborador);
                    command.Parameters.AddWithValue("@HoraEntrada", control.HoraEntrada);
                    command.Parameters.AddWithValue("@HoraSalida", control.HoraSalida);
                    command.Parameters.AddWithValue("@Fecha", control.Fecha);
                    command.Parameters.AddWithValue("@HorasTrabajadas", control.HorasTrabajadas);

                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        #endregion

        #region SELECT ALL

        public static List<ControlDeMarcas> SelectAll()
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_ControlDeMarcas_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "ControlDeMarcas");
                }

                List<ControlDeMarcas> lista = new List<ControlDeMarcas>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        ControlDeMarcas controlDeMarcas = new ControlDeMarcas();
                        controlDeMarcas.idMarca = int.Parse(dr["idMarca"].ToString());
                        controlDeMarcas.IdColaborador = int.Parse(dr["IdColaborador"].ToString());
                        controlDeMarcas.HoraEntrada = (dr["HoraEntrada"].ToString());
                        controlDeMarcas.HoraSalida = (dr["HoraSalida"].ToString());
                        controlDeMarcas.Fecha = (dr["Fecha"].ToString());
                        controlDeMarcas.HorasTrabajadas = double.Parse(dr["HorasTrabajadas"].ToString());

                        lista.Add(controlDeMarcas);
                    }
                }
                return lista;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return null;
            }
        }

        #endregion

        #region DELETE
        public static void DELETE()
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_ControlDeMarcas");
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        #endregion

    }
}
