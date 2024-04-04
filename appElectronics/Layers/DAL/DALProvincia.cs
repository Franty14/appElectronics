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
    class DALProvincia : IDALProvincia
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        Usuario _Usuario = new Usuario();
        public DALProvincia()
        {
            _Usuario.Login = Settings.Default.Login;
            _Usuario.Password = Settings.Default.Password;
        }


        public List<Provincia> GetAllProvincia()
        {
            IDataReader reader = null;
            List<Provincia> lista = new List<Provincia>();
            SqlCommand command = new SqlCommand();

            string sql = @" select * from  Provincia WITH (NOLOCK)  ";
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Provincia oProvincia = new Provincia();
                        oProvincia.IdProvincia = int.Parse(reader["IdProvincia"].ToString());
                        oProvincia.Descripcion = reader["Descripcion"].ToString();
                        lista.Add(oProvincia);
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
    }
}
