using log4net;
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
using UTN.Winform.Electronics.Properties;

namespace UTN.Winform.Electronics.Layers.DAL
{
    class DALCliente : IDALCliente
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        Usuario _Usuario = new Usuario();
        public DALCliente()
        {
            _Usuario.Login = Settings.Default.Login;
            _Usuario.Password = Settings.Default.Password;
        }

        public bool DeleteCliente(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {

                string sql = @"Delete from  Cliente Where (IdCliente = @IdCliente) ";
                command.Parameters.AddWithValue("@IdCliente", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    retorno = true;

                return retorno;
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
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public List<Cliente> GetAllCliente()
        {
            DataSet ds = null;
            List<Cliente> lista = new List<Cliente>();
            SqlCommand command = new SqlCommand();

            try
            {

                string sql = @" select * from  Cliente  WITH (NOLOCK)  ";
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
                        Cliente oCliente = new Cliente();
                        oCliente.IdCliente = dr["IdCliente"].ToString();
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.Apellido1 = dr["Apellido1"].ToString();
                        oCliente.Apellido2 = dr["Apellido2"].ToString();
                        oCliente.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        oCliente.IdProvincia = (int)dr["IdProvincia"];
                        oCliente.Sexo = (int)dr["Sexo"];

                        lista.Add(oCliente);
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
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public List<Cliente> GetClienteByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Cliente> lista = new List<Cliente>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Cliente WITH (NOLOCK) Where Nombre+Apellido1+Apellido2 like @filtro ";
                command.Parameters.AddWithValue("@filtro", pDescripcion);
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
                        Cliente oCliente = new Cliente();
                        oCliente.IdCliente = dr["IdCliente"].ToString();
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.Apellido1 = dr["Apellido1"].ToString();
                        oCliente.Apellido2 = dr["Apellido2"].ToString();
                        oCliente.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        oCliente.IdProvincia = (int)dr["IdProvincia"];
                        oCliente.Sexo = (int)dr["Sexo"];

                        lista.Add(oCliente);
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
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public Cliente GetClienteById(string pIdCliente)
        {
            DataSet ds = null;
            Cliente oCliente = null;
            SqlCommand command = new SqlCommand();


            try
            {

                string sql = @" select * from  Cliente Where IdCliente = @IdCliente ";
                command.Parameters.AddWithValue("@IdCliente", pIdCliente);
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
                        oCliente = new Cliente();
                        oCliente.IdCliente = dr["IdCliente"].ToString();
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.Apellido1 = dr["Apellido1"].ToString();
                        oCliente.Apellido2 = dr["Apellido2"].ToString();
                        oCliente.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        oCliente.IdProvincia = (int)dr["IdProvincia"];
                        oCliente.Sexo = (int)dr["Sexo"];

                    }
                }

                return oCliente;
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
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public Cliente SaveCliente(Cliente pCliente)
        {
            Cliente oCliente = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"Insert into Cliente(IdCliente,Nombre,Apellido1,Apellido2,Sexo,FechaNacimiento,IdProvincia)
                           values (@IdCliente,@Nombre,@Apellido1,@Apellido2,@Sexo,@FechaNacimiento,@IdProvincia)";


            double rows = 0;
            try
            {
                command.Parameters.AddWithValue("@IdCliente", pCliente.IdCliente);
                command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                command.Parameters.AddWithValue("@Apellido1", pCliente.Apellido1);
                command.Parameters.AddWithValue("@Apellido2", pCliente.Apellido2);
                command.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                command.Parameters.AddWithValue("@FechaNacimiento", pCliente.FechaNacimiento);
                command.Parameters.AddWithValue("@IdProvincia", pCliente.IdProvincia);
                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;

                //command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oCliente = this.GetClienteById(pCliente.IdCliente);

                return oCliente;

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
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public Cliente UpdateCliente(Cliente pCliente)
        {
            Cliente oCliente = null;
            SqlCommand command = new SqlCommand();

            string sql = @"Update Cliente SET IdCliente = @IdCliente, Nombre = @Nombre, Apellido1 = @Apellido1, Apellido2 = @Apellido2, Sexo = @Sexo, FechaNacimiento = @FechaNacimiento, IdProvincia = @IdProvincia  Where (IdCliente = @IdCliente) ";

            double rows = 0;
            try
            {
                command.Parameters.AddWithValue("@IdCliente", pCliente.IdCliente);
                command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                command.Parameters.AddWithValue("@Apellido1", pCliente.Apellido1);
                command.Parameters.AddWithValue("@Apellido2", pCliente.Apellido2);
                command.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                command.Parameters.AddWithValue("@FechaNacimiento", pCliente.FechaNacimiento);
                command.Parameters.AddWithValue("@IdProvincia", pCliente.IdProvincia);
                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oCliente = this.GetClienteById(pCliente.IdCliente);

                return oCliente;

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
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }
    }
}
