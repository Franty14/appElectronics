using log4net;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Properties;

namespace UTN.Winform.Electronics.Layers.UI.Reportes
{
    public partial class frmReporteFactura : Form
    {
        private decimal _IdFactura;
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmReporteFactura()
        {
            InitializeComponent();
        }

        public frmReporteFactura(decimal pIdFactura)
        {
            InitializeComponent();
            _IdFactura = pIdFactura;
        }

        private void frmReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                Usuario oUsuario = new Usuario();
                oUsuario.Login = Settings.Default.Login;
                oUsuario.Password = Settings.Default.Password;

              
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(oUsuario.Login, oUsuario.Password)))
                {
                    // Se le coloca al Adaptador la conexion a la BD.
                    FacturaTableAdapter.Connection = db._Conexion as System.Data.SqlClient.SqlConnection;
                    this.FacturaTableAdapter.Fill(this.DSReportes.Factura, _IdFactura);
                }

                string ruta = @"file:///" + @"C:/TEMP/qr.png";
                // Habilitar imagenes externas
                this.rptVisor.LocalReport.EnableExternalImages = true;
                ReportParameter param = new ReportParameter("quickresponse", ruta);
                this.rptVisor.LocalReport.SetParameters(param);
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

        private void toolStripBtnExportarPDF_Click(object sender, EventArgs e)
        {
            string ruta = @"c:\temp\reporte.pdf";
            try
            {
                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");

                byte[] Bytes = this.rptVisor.LocalReport.Render(format: "PDF", deviceInfo: "");

                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }

                Process.Start(ruta);
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
