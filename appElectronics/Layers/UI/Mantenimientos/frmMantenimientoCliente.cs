using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.BLL;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.UI.Reportes;

namespace UTN.Winform.Electronics.Layers.UI.Mantenimientos
{
    public partial class frmMantenimientoCliente : Form
    {

        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmMantenimientoCliente()
        {
            InitializeComponent();
        }



        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMantenimientoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
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

        private void CambiarEstado(EstadoMantenimiento estado)
        {
            this.txtIdCliente.Clear();
            this.txtNombre.Clear();
            this.txtApellido1.Clear();
            this.txtApellido2.Clear();

            this.txtIdCliente.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApellido1.Enabled = false;
            this.txtApellido2.Enabled = false;

            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.cmbProvincia.Enabled = false;

            // Coloca el primer item por defecto
            if (cmbProvincia.Items.Count > 0)
                this.cmbProvincia.SelectedIndex = 0;

            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    this.txtIdCliente.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.cmbProvincia.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    txtIdCliente.Focus();
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtIdCliente.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.cmbProvincia.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    txtNombre.Focus();
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    break;
            }
        }

        private void CargarDatos()
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            IBLLProvincia _BLLProvincia = new BLLProvincia();
            List<Provincia> lista = null;

            // Cambiar el estado
            this.CambiarEstado(EstadoMantenimiento.Ninguno);

            // Configuracion del DataGridView para que se vea bien la imagen.
            dgvDatos.AutoGenerateColumns = false;
            // dgvDatos.RowTemplate.Height = 100;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            // Cargar el DataGridView
            this.dgvDatos.DataSource = _BLLCliente.GetAllCliente();

            // Cargar el combo
            this.cmbProvincia.Items.Clear();
            lista = _BLLProvincia.GetAllProvincia();
            foreach (Provincia oProvincia in lista)
            {
                this.cmbProvincia.Items.Add(oProvincia);
            }
            // Colocar el primero como default
            this.cmbProvincia.SelectedIndex = 0;
        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            this.CambiarEstado(EstadoMantenimiento.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CambiarEstado(EstadoMantenimiento.Ninguno);
        }
        ErrorProvider erp = new ErrorProvider();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            erp = new ErrorProvider();
            try
            { 

                Cliente oCliente = new Cliente();

                if (string.IsNullOrEmpty(txtIdCliente.Text))
                {
                    erp.SetError(txtIdCliente, "Id Requerido");
                    txtIdCliente.Focus();
                    return;
                }

                oCliente.IdCliente = this.txtIdCliente.Text;
                oCliente.Nombre = this.txtNombre.Text;
                oCliente.Apellido1 = this.txtApellido1.Text;
                oCliente.Apellido2 = this.txtApellido2.Text;
                oCliente.FechaNacimiento = dtpFechaNacimiento.Value;
                oCliente.IdProvincia = (cmbProvincia.SelectedItem as Provincia).IdProvincia;
                oCliente.Sexo = rdbFemenino.Checked ? 2 : 1;

                oCliente = _BLLCliente.SaveCliente(oCliente);

                //frmReporteXClienteId reporte = new frmReporteXClienteId(oCliente.IdCliente);
                //reporte.ShowDialog();

                if (oCliente != null)
                    this.CargarDatos();

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

        private void toolStripBtnBorrar_Click(object sender, EventArgs e)
        {
            IBLLCliente _IBLLCliente = new BLLCliente();

            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Borrar);

                    Cliente oCliente = this.dgvDatos.SelectedRows[0].DataBoundItem as Cliente;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oCliente.IdCliente} {oCliente.Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _IBLLCliente.DeleteCliente(oCliente.IdCliente);
                        this.CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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

        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = null;
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    // Cambiar de estado
                    this.CambiarEstado(EstadoMantenimiento.Editar);
                    oCliente = this.dgvDatos.SelectedRows[0].DataBoundItem as Cliente;
                    this.txtIdCliente.Text = oCliente.IdCliente;
                    this.txtApellido1.Text = oCliente.Apellido1;
                    this.txtApellido2.Text = oCliente.Apellido2;
                    this.txtNombre.Text = oCliente.Nombre;
                    this.rdbFemenino.Checked = oCliente.Sexo == 2 ? true : false;
                    this.rdbMasculino.Checked = oCliente.Sexo == 1 ? true : false;
                    this.dtpFechaNacimiento.Value = oCliente.FechaNacimiento;
                    cmbProvincia.SelectedIndex = cmbProvincia.FindString(oCliente.IdProvincia.ToString());


                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
