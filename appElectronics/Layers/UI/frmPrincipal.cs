using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using UTN.Winform.Electronics.Layers.UI.Mantenimientos;
using UTN.Winform.Electronics.Layers.UI.Procesos;
using UTN.Winform.Electronics.Layers.UI.Reportes;
using UTN.Winform.Electronics.Layers.UI.Seguridad;
using UTN.Winform.Electronics.Properties;

namespace UTN.Winform.Electronics.Layers.UI
{
    public partial class frmPrincipal : Form
    {
        private static readonly ILog _MyLogControlEventos =
           log4net.LogManager.GetLogger("MyControlEventos");

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Application.ProductName + " Versión:  " + Application.ProductVersion;
                Utilitarios.CultureInfo();
                toolStripStatusLblMensaje.Text = "Usuario Conectado: " + Settings.Default.Login;

                BLL.BLLFactura _BLLFactura = new BLL.BLLFactura();
                double monto = _BLLFactura.GetTotalFactura(80);

                if (!Directory.Exists(@"C:\temp"))
                    Directory.CreateDirectory(@"C:\temp");


                _MyLogControlEventos.InfoFormat("Conectado a Form Principal");
                 // Seguridad();

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

        private void productosToolStripMenuItemProductos_Click(object sender, EventArgs e)
        {
            frmMantenimientoElectronico ofrmMantenimientoElectronico;
            try
            {
                ofrmMantenimientoElectronico = new frmMantenimientoElectronico();
                ofrmMantenimientoElectronico.MdiParent = this;
                ofrmMantenimientoElectronico.Show();
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

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturacion ofrmFacturacion;
            try
            {
                ofrmFacturacion = new frmFacturacion();
                ofrmFacturacion.MdiParent = this;
                ofrmFacturacion.Show();
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

        private void toolStripMenuItemAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercade ofrmAcercade;
            try
            {
                ofrmAcercade = new frmAcercade();
                ofrmAcercade.MdiParent = this;
                ofrmAcercade.Show();
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

        private void clientesToolStripMenuItemCliente_Click(object sender, EventArgs e)
        {
            frmMantenimientoCliente ofrmMantenimientoCliente;

            try
            {
                ofrmMantenimientoCliente = new frmMantenimientoCliente();
                ofrmMantenimientoCliente.MdiParent = this;
                ofrmMantenimientoCliente.Show();
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

        private void anularFacturaToolStripMenuItemAnularFactura_Click(object sender, EventArgs e)

        {
            MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void clientesToolStripMenuItemClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void electronicoToolStripMenuItemElectronico_Click(object sender, EventArgs e)
        {
            frmReporteElectronico ofrmReporteElectronico;
            try
            {
                ofrmReporteElectronico = new frmReporteElectronico();
                ofrmReporteElectronico.MdiParent = this;
                ofrmReporteElectronico.Show();
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

        private void ventaElectronicoToolStripMenuItemVentaElectronico_Click(object sender, EventArgs e)
        {
            frmReporteVentaElectronico ofrmReporteVentaElectronico;
            try
            {
                ofrmReporteVentaElectronico = new frmReporteVentaElectronico();
                ofrmReporteVentaElectronico.MdiParent = this;
                ofrmReporteVentaElectronico.Show();
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

        private void ventaPorClienteToolStripMenuItemVentaXCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void facturaciónToolStripMenuItemfacturacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cierreToolStripMenuItemCierre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void usuariosToolStripMenuItemUsuarios_Click(object sender, EventArgs e)
        {
            frmSeguridad ofrmSeguridad;
            try
            {
                ofrmSeguridad = new frmSeguridad();
                ofrmSeguridad.MdiParent = this;
                ofrmSeguridad.Show();
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


        private void Seguridad()
        {

            List<string> menus = new List<string>();

            // Se deshabilita TODO primero
            foreach (ToolStripItem opcionMenu in this.mspMenuPrincipal.Items) //para cada opción de la barra de menú
            {
                // deshabita todos !
                ((ToolStripItem)(opcionMenu)).Enabled = false;
            }


            //// extraigo de la tabla Seguridad el rol que tiene el usuario
            //string rol = "M";

            //if (rol.Equals("M")) {

            menus.Add("toolStripMenuItemProcesos");

            //    // Opciones habilitadas en el Menú           
            //    // menus.Add("toolStripMenuItemMantenimientos");
            //    menus.Add("toolStripMenuItemProcesos");
            //    //menus.Add("reportesToolStripMenuItemReportes");
            //    //menus.Add("administracionToolStripMenuItem");
            //     menus.Add("toolStripMenuItemAcercaDe");

            //}

            foreach (ToolStripItem opcionMenu in this.mspMenuPrincipal.Items) //para cada opción de la barra de menú
            {
                if (opcionMenu is ToolStripDropDownButton)
                {
                    foreach (ToolStripMenuItem oToolStripMenuItem in ((ToolStripDropDownButton)opcionMenu).DropDownItems)
                    {
                        oToolStripMenuItem.Enabled = menus.Exists(p => p.Equals(oToolStripMenuItem.Name, StringComparison.InvariantCultureIgnoreCase));
                    }
                }
                // Habilita solo las opciones que se encuentrna en la lista "menu"
                opcionMenu.Enabled = menus.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
            }

        }

        private void tarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                 
                MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            _MyLogControlEventos.InfoFormat("Salida del Sistema");
        }

        private void mspMenuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
