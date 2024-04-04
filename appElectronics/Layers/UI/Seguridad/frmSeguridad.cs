using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.BLL;

namespace UTN.Winform.Electronics.Layers.UI.Seguridad
{
    public partial class frmSeguridad : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmSeguridad()
        {
            InitializeComponent();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        { 
            Close();
        }

        private void toolStripBtnSalvarUsuario_Click(object sender, EventArgs e)
        {
            IBLLSeguridad _BLLSeguridad = new BLLSeguridad();
            string basedatos = "";

            try
            {

                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    epError.SetError(txtUsuario, "Usuario  Requerido");
                    txtUsuario.Focus();
                    return;
                }

                // Validar datos requeridos 
                if (string.IsNullOrEmpty(txtContrasena.Text))
                {
                    epError.SetError(txtContrasena, "Contrasena Requerida");
                    txtContrasena.Focus();
                    return;
                }



                basedatos = this.cmbBaseDatos.SelectedItem.ToString();


                DialogResult respuesta = MessageBox.Show($"Crear usuario el {txtUsuario.Text} en la base de datos {basedatos}?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                    _BLLSeguridad.CreateUser(this.txtUsuario.Text.Trim(), this.txtContrasena.Text.Trim(), basedatos.Trim());
                else
                    return;

                // Mostrar el mensaje
                TaskBarMensaje();
                LlenarUsuarios();

                this.txtContrasena.Clear();
                this.txtUsuario.Clear();
                txtUsuario.Focus();


            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TaskBarMensaje()
        {
            ntfMensaje.Visible = true;
            ntfMensaje.BalloonTipIcon = ToolTipIcon.Info;
            ntfMensaje.BalloonTipText = "Usuario creado correctamente";
            ntfMensaje.BalloonTipTitle = "Atención";
            ntfMensaje.Icon = Properties.Resources.icono;
            ntfMensaje.Text = "";
            ntfMensaje.ShowBalloonTip(1000);
            Thread.Sleep(3000);
            ntfMensaje.Visible = false;
        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            this.txtContrasena.Clear();
            this.txtUsuario.Clear();
            txtUsuario.Focus();
        }

        private void frmSeguridad_Load(object sender, EventArgs e)
        {
            IBLLSeguridad _BLLSeguridad;
            IEnumerable<string> lista;
            try
            {

                _BLLSeguridad = new BLLSeguridad();

                lista = _BLLSeguridad.GetDataBases();

                foreach (string basedatos in lista)
                    this.cmbBaseDatos.Items.Add(basedatos);

                if (cmbBaseDatos.Items.Count > 0)
                    this.cmbBaseDatos.SelectedIndex = 0;

                LlenarUsuarios();

            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LlenarUsuarios()
        {
            this.trvUsuarios.Nodes.Clear();

            IBLLSeguridad _BLLSeguridad = new BLLSeguridad();
            IEnumerable<string> lista;
            TreeNode raiz;

            //    lista = _BLLSeguridad.GetLoginsXDataBase(this.cmbBaseDatos.SelectedItem.ToString());
            lista = _BLLSeguridad.GetLogins( );

            raiz = trvUsuarios.Nodes.Add("Login", "Login", 0, 0);


            foreach (var usuario in lista)
            {
                TreeNode nodo = new TreeNode(usuario, 1, 1);

                trvUsuarios.Nodes[0].Nodes.Add(nodo);
            }


            trvUsuarios.ExpandAll();

        }


    }
}
