using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Properties;

namespace UTN.Winform.Electronics.Layers.UI.Reportes
{
    public partial class frmReporteVentaElectronico : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmReporteVentaElectronico()
        {
            InitializeComponent();
        }

        private void frmReporteVentaElectronico_Load(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario();

            try
            {
                oUsuario.Login = Settings.Default.Login;
                oUsuario.Password = Settings.Default.Password;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(oUsuario.Login, oUsuario.Password)))
                {
                    // Se le coloca al Adaptador la conexion a la BD.
                    ventaElectronicoTableAdapter.Connection = db._Conexion as System.Data.SqlClient.SqlConnection;

                    // TODO: This line of code loads data into the 'dSReportes.VentaElectronico' table. You can move, or remove it, as needed.
                    this.ventaElectronicoTableAdapter.Fill(this.dSReportes.VentaElectronico);
                }
                 

                // Invoca el reporte
                this.rptVisor.RefreshReport();
            }
            catch (SqlException sqlError)
            {
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: \n" + Utilitarios.GetCustomErrorByNumber(sqlError), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
