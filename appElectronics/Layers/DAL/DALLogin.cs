using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    class DALLogin : IDALLogin
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
 
        public bool Login(string pUsuario, string pContrasena)
        {
            StringBuilder conexion = new StringBuilder();
            try
            {                    
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(pUsuario, pContrasena)))
                {
                    // Si esto da error es porque el usuario no existe! 
                }

                return true;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), null, sqlError));
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
