using log4net;
using Microsoft.Reporting.WinForms;
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
   
    /*
     1- Agregar la cantidad de productos electronicos que hay en stock
     2- Coloque un botón que permita exportar el reporte a PDF 
    */
    public partial class frmReporteElectronico : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmReporteElectronico()
        {
            InitializeComponent();
        }

        private void frmReporteElectronico_Load(object sender, EventArgs e)
        {
           
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = "";
           
            try
            {
                Usuario oUsuario = new Usuario();
                oUsuario.Login = Settings.Default.Login;
                oUsuario.Password = Settings.Default.Password;

                // filtro
                filtro = "%" + this.toolStripTxtFiltro.Text + "%";
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(oUsuario.Login, oUsuario.Password)))
                {
                    // Se le coloca al Adaptador la conexion a la BD.
                    ElectronicoTableAdapter.Connection = db._Conexion as System.Data.SqlClient.SqlConnection;
                    // TODO: This line of code loads data into the 'DSReportes.Electronico' table. You can move, or remove it, as needed.
                    this.ElectronicoTableAdapter.Fill(this.DSReportes.Electronico, filtro);
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
    }
}
