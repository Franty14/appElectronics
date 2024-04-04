﻿using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.Entities.DTO;
using UTN.Winform.Electronics.Properties;

namespace UTN.Winform.Electronics.Layers.DAL
{
    class DALElectronico : IDALElectronico
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        private Usuario _Usuario = new Usuario();
        public DALElectronico()
        {
            _Usuario.Login = Settings.Default.Login;
            _Usuario.Password = Settings.Default.Password;
        }
        public bool DeleteElectronico(double pId)
        {

            double rows = 0;
            // Crear el SQL
            string sql = @" delete   from  [Electronico] where IdElectronico = @IdElectronico ";
            SqlCommand command = new SqlCommand();

            try
            {
                // Pasar parámetros
                command.Parameters.AddWithValue("@IdElectronico", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                // Ejecutar
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                return rows > 0;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n",Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError) );
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail( MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public List<ElectronicoBodegaDTO> GetAllElectronico()
        {
            DataSet ds = null;
            List<ElectronicoBodegaDTO> lista = new List<ElectronicoBodegaDTO>();
            SqlCommand command = new SqlCommand();

            string sql = @" SELECT   Electronico.IdElectronico, Electronico.DescripcionElectronico, Electronico.Precio, Electronico.Cantidad, Electronico.Imagen, Electronico.Garantia, Electronico.IdBodega, Electronico.Documentacion, 
                              Electronico.FechaInclusion,  Bodega.DescripcionBodega
                            FROM    Bodega INNER JOIN
                              Electronico ON Bodega.IdBodega = Electronico.IdBodega ";
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {

                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ElectronicoBodegaDTO oElectronicoBodegaDTO = new ElectronicoBodegaDTO()
                        {
                            IdElectronico = double.Parse(dr["IdElectronico"].ToString()),
                            Cantidad = int.Parse(dr["Cantidad"].ToString()),
                            DescripcionElectronico = dr["DescripcionElectronico"].ToString(),
                            Documentacion = (byte[])dr["Documentacion"],
                            FechaInclusion = DateTime.Parse(dr["FechaInclusion"].ToString()),
                            Imagen = (byte[])dr["Imagen"],
                            Precio = double.Parse(dr["Precio"].ToString()),
                            DescripcionBodega = dr["DescripcionBodega"].ToString(),
                            Garantia = (bool)dr["Garantia"],
                            IdBodega = int.Parse(dr["IdBodega"].ToString())
                        };

                        lista.Add(oElectronicoBodegaDTO);
                    }
                }

                return lista;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail( MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public List<Electronico> GetElectronicoByFilter(string pDescripcion)
        {
            DataSet ds = null;
            SqlCommand command = new SqlCommand();
            List<Electronico> lista = new List<Electronico>();
            string sql = @" select * from  [Electronico] where [DescripcionElectronico] like @DescripcionElectronico";

            try
            {
                // Pasar Parámetro
                command.Parameters.AddWithValue("@DescripcionElectronico", pDescripcion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                // Ejecutar
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió valores
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Itetarar en las filas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        // Mapear la fila al Objeto
                        Electronico oElectronico = new Electronico()
                        {
                            IdElectronico = double.Parse(dr["IdElectronico"].ToString()),
                            Cantidad = int.Parse(dr["Cantidad"].ToString()),
                            DescripcionElectronico = dr["DescripcionElectronico"].ToString(),
                            Documentacion = (byte[])dr["Documentacion"],
                            FechaInclusion = DateTime.Parse(dr["FechaInclusion"].ToString()),
                            Imagen = (byte[])dr["Imagen"],
                            Precio = double.Parse(dr["Precio"].ToString()),
                            Garantia = (bool)dr["Garantia"],
                            IdBodega = int.Parse(dr["IdBodega"].ToString())
                        };

                        lista.Add(oElectronico);

                    }

                }

                return lista;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail( MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public Electronico GetElectronicoById(double pId)
        {
            DataSet ds = null;
            Electronico oElectronico = null;
            string sql = @" select * from  [Electronico] where IdElectronico = @IdElectronico";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@IdElectronico", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si retornó valores 
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Extraer la primera fila, como se buscó por Id entonces solo una debe devolver  
                    DataRow dr = ds.Tables[0].Rows[0];
                    oElectronico = new Electronico()
                    {
                        IdElectronico = double.Parse(dr["IdElectronico"].ToString()),
                        Cantidad = int.Parse(dr["Cantidad"].ToString()),
                        DescripcionElectronico = dr["DescripcionElectronico"].ToString(),
                        Documentacion = (byte[])dr["Documentacion"],
                        FechaInclusion = DateTime.Parse(dr["FechaInclusion"].ToString()),
                        Imagen = (byte[])dr["Imagen"],
                        Precio = double.Parse(dr["Precio"].ToString()),
                        Garantia = (bool)dr["Garantia"],
                        IdBodega = int.Parse(dr["IdBodega"].ToString()),
                    };


                }

                return oElectronico;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail( MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public Electronico SaveElectronico(Electronico pElectronico)
        {
            Electronico oElectronico = null;
            string sql = @" 
                            INSERT INTO [dbo].[Electronico]
                                        ([IdElectronico],
                                         [DescripcionElectronico],
                                         [Precio],
                                         [Cantidad],
                                         [Imagen],
                                         [Documentacion],
                                         [Garantia] ,
                                         [IdBodega]
                                         )
                                    VALUES
                                        (@IdElectronico ,
                                         @DescripcionElectronico,  
                                         @Precio,  
                                         @Cantidad,  
                                         @Imagen, 
                                         @Documentacion,
                                         @Garantia, 
                                         @IdBodega)";


            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {

                // Pasar parámetros
                command.Parameters.AddWithValue("@IdElectronico", pElectronico.IdElectronico);
                command.Parameters.AddWithValue("@DescripcionElectronico", pElectronico.DescripcionElectronico);
                command.Parameters.AddWithValue("@Precio", pElectronico.Precio);
                command.Parameters.AddWithValue("@Cantidad", pElectronico.Cantidad);
                command.Parameters.AddWithValue("@Imagen", pElectronico.Imagen.ToArray());
                command.Parameters.AddWithValue("@Documentacion", pElectronico.Documentacion.ToArray());
                command.Parameters.AddWithValue("@Garantia", (bool)pElectronico.Garantia);
                command.Parameters.AddWithValue("@IdBodega", pElectronico.IdBodega);
                command.Parameters.AddWithValue("@FechaInclusion", pElectronico.FechaInclusion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oElectronico = GetElectronicoById(pElectronico.IdElectronico);

                return oElectronico;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail( MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public Electronico UpdateElectronico(Electronico pElectronico)
        {
            Electronico oElectronico = null;
            string sql = @" 
                            UPDATE [dbo].[Electronico]
                               SET 
                                   [DescripcionElectronico] =  @DescripcionElectronico
                                  ,[Precio] = @Precio
                                  ,[Cantidad] = @Cantidad
                                  ,[Imagen] = @Imagen
                                  ,[Garantia] = @Garantia
                                  ,[IdBodega] = @IdBodega 
                                  ,[Documentacion] = @Documentacion                                 
                             WHERE [IdElectronico] = @IdElectronico  ";



            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {

                // Pasar parámetros
                command.Parameters.AddWithValue("@IdElectronico", pElectronico.IdElectronico);
                command.Parameters.AddWithValue("@DescripcionElectronico", pElectronico.DescripcionElectronico);
                command.Parameters.AddWithValue("@Precio", pElectronico.Precio);
                command.Parameters.AddWithValue("@Cantidad", pElectronico.Cantidad);
                command.Parameters.AddWithValue("@Imagen", pElectronico.Imagen.ToArray());
                command.Parameters.AddWithValue("@Documentacion", pElectronico.Documentacion.ToArray());
                command.Parameters.AddWithValue("@Garantia", (bool)pElectronico.Garantia);
                command.Parameters.AddWithValue("@IdBodega", pElectronico.IdBodega);
                command.Parameters.AddWithValue("@FechaInclusion", pElectronico.FechaInclusion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oElectronico = GetElectronicoById(pElectronico.IdElectronico);

                return oElectronico;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail( MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

    }
}
