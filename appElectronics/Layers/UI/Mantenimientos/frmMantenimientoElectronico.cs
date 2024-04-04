using log4net;
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
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.BLL;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.Entities.DTO;

namespace UTN.Winform.Electronics.Layers.UI.Mantenimientos
{


    public partial class frmMantenimientoElectronico : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        #region Constructor

        public frmMantenimientoElectronico()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMantenimientoElectronico_Load(object sender, EventArgs e)
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

        /// <summary>
        /// Nota:
        /// Faltan validaciones que ud debe realizar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Electronico oElectronico = null;
            IBLLElectronico _IBLLElectronico = new BLLElectronico();
            try
            {


                if (this.pbImagen.Tag == null)
                {
                    MessageBox.Show("La Imagen  es un dato requerido !", "Atención");
                    return;
                }

                if (this.pbDocumentacion.Tag == null)
                {
                    MessageBox.Show("La documentación es un dato requerido !", "Atención");
                    return;
                }

                oElectronico = new Electronico();

                oElectronico.Precio = double.Parse(this.mskPrecio.Text);
                oElectronico.Cantidad = int.Parse(this.mskCantidad.Text);
                oElectronico.DescripcionElectronico = this.txtDescripcion.Text;
                oElectronico.Documentacion = (byte[])this.pbDocumentacion.Tag;
                oElectronico.Imagen = (byte[])this.pbImagen.Tag;
                oElectronico.FechaInclusion = DateTime.Now;
                oElectronico.Precio = double.Parse(this.mskPrecio.Text);
                oElectronico.IdBodega = (cmbBodega.SelectedItem as Bodega).IdBodega;
                oElectronico.Garantia = rdSi.Checked ? true : false;
                oElectronico.IdElectronico = double.Parse(this.mskCodigo.Text);

                oElectronico = _IBLLElectronico.SaveElectronico(oElectronico);

                if (oElectronico != null)
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
            IBLLElectronico _BLLElectronico = new BLLElectronico();

            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Borrar);

                    ElectronicoBodegaDTO oElectronicoBodegaDTO = this.dgvDatos.SelectedRows[0].DataBoundItem as ElectronicoBodegaDTO;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oElectronicoBodegaDTO.IdElectronico} {oElectronicoBodegaDTO.DescripcionElectronico}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _BLLElectronico.DeleteElectronico(oElectronicoBodegaDTO.IdElectronico);
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

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {

            try
            {
                this.CambiarEstado(EstadoMantenimiento.Nuevo);

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
            ElectronicoBodegaDTO oElectronicoBodegaDTO = null;
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    // Cambiar de estado
                    this.CambiarEstado(EstadoMantenimiento.Editar);
                    //Extraer el DTO seleccionado
                    oElectronicoBodegaDTO = this.dgvDatos.SelectedRows[0].DataBoundItem as ElectronicoBodegaDTO;

                    this.mskCodigo.Text = oElectronicoBodegaDTO.IdElectronico.ToString();
                    this.txtDescripcion.Text = oElectronicoBodegaDTO.DescripcionElectronico;
                    this.mskCantidad.Text = oElectronicoBodegaDTO.Cantidad.ToString();
                    this.mskPrecio.Text = oElectronicoBodegaDTO.Precio.ToString();
                    // Seleccionar el combo
                    this.cmbBodega.SelectedIndex = cmbBodega.FindString(oElectronicoBodegaDTO.IdBodega.ToString());
                    this.pbDocumentacion.Tag = oElectronicoBodegaDTO.Documentacion;
                    this.pbImagen.Image = new Bitmap(new MemoryStream(oElectronicoBodegaDTO.Imagen));
                    this.pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pbImagen.Tag = oElectronicoBodegaDTO.Imagen;
                    this.pbDocumentacion.Image = Electronics.Properties.Resources.MSWordAcepted;

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

        private void pbImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opt = new OpenFileDialog();
                opt.Title = "Seleccione la Imagen ";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.jpg";
                opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                {

                    //ruta = opt.FileName.Trim();
                    this.pbImagen.ImageLocation = opt.FileName;
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                    // Guarla la imagenen Bytes en el Tag de la imagen.
                    pbImagen.Tag = (byte[])cadenaBytes;

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

        private void pbDocumentacion_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opt = new OpenFileDialog();
                opt.Title = "Seleccione el Documento ";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.docx";
                opt.Filter = "Archivos de Documentos (*.docx)|*.docx| All files (*.*)|*.*";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                { 

                    // Leer todo el archivo de bytes
                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);
                    this.pbDocumentacion.Tag = cadenaBytes;
                    this.pbDocumentacion.Image = Electronics.Properties.Resources.MSWordAcepted;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CambiarEstado(EstadoMantenimiento.Ninguno);
        }

        private void verImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pbImagen.Tag != null)
                {

                    if (!Directory.Exists(@"C:\temp"))
                        Directory.CreateDirectory(@"C:\temp");

                    File.WriteAllBytes(@"C:\temp\imagen.jpg", (byte[])this.pbImagen.Tag);
                    Process.Start(@"C:\temp\imagen.jpg");
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

        private void verDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.pbDocumentacion.Tag != null)
                {

                    if (!Directory.Exists(@"C:\temp"))
                        Directory.CreateDirectory(@"C:\temp");


                    File.WriteAllBytes(@"C:\temp\documentacion.docx", (byte[])this.pbDocumentacion.Tag);
                    Process.Start(@"C:\temp\documentacion.docx");
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
        #endregion

        #region Methods
        private void CargarDatos()
        {
            IBLLElectronico _IBLLElectronico = new BLLElectronico();
            IBLLBodega _BLLBodega = new BLLBodega();
            List<Bodega> lista = null;

            // Cambiar el estado
            this.CambiarEstado(EstadoMantenimiento.Ninguno);

            // Configuracion del DataGridView para que se vea bien la imagen.
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 100;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.pbDocumentacion.Enabled = false;
            this.pbImagen.Enabled = false;

            // Cargar el DataGridView
            this.dgvDatos.DataSource = _IBLLElectronico.GetAllElectronico();

            // Cargar el combo
            this.cmbBodega.Items.Clear();
            lista = _BLLBodega.GetAllBodega();
            foreach (Bodega oBodega in lista)
            {
                this.cmbBodega.Items.Add(oBodega);
            }
            // Colocar el primero como default
            this.cmbBodega.SelectedIndex = 0;
     
            // Colocar la imagen de Word por defecto
            this.pbDocumentacion.Image = Electronics.Properties.Resources.MS_Word2;
            this.pbImagen.Image = Electronics.Properties.Resources.camera_web_2;
            this.pbImagen.SizeMode = PictureBoxSizeMode.CenterImage;
 
        }

        private void CambiarEstado(EstadoMantenimiento estado)
        {
            this.txtDescripcion.Clear();
            this.mskCantidad.Clear();
            this.mskCodigo.Clear();
            this.mskPrecio.Clear();
            this.pbDocumentacion.Tag = null;
            this.pbImagen.Tag = null;

            this.mskCodigo.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.mskCantidad.Enabled = false;
            this.mskPrecio.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.cmbBodega.Enabled = false;
            this.pbDocumentacion.Enabled = false;
            this.pbImagen.Enabled = false;

            // Colocar la imagen de Word por defecto
            this.pbDocumentacion.Image = Electronics.Properties.Resources.MS_Word2;
            this.pbImagen.Image = Electronics.Properties.Resources.camera_web_2;
            this.pbImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            if (cmbBodega.Items.Count > 0)
                this.cmbBodega.SelectedIndex = 0;

            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    this.txtDescripcion.Enabled = true;
                    this.mskCantidad.Enabled = true;
                    this.mskCodigo.Enabled = true;
                    this.mskPrecio.Enabled = true;
                    this.mskCodigo.Enabled = true;
                    this.pbDocumentacion.Enabled = true;
                    this.pbImagen.Enabled = true;
                    this.cmbBodega.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    mskCodigo.Focus();
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtDescripcion.Enabled = true;
                    this.mskCantidad.Enabled = true;
                    this.mskCodigo.Enabled = false;
                    this.mskPrecio.Enabled = true;
                    this.pbDocumentacion.Enabled = true;
                    this.pbImagen.Enabled = true;
                    this.cmbBodega.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    txtDescripcion.Focus();
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    break;
            }
        }


        #endregion



    }
}
