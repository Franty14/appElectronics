﻿using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.BLL;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Properties;

namespace UTN.Winform.Electronics.Layers.UI
{
    public partial class frmLogin : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            // Debe validar los datos requeridos
            IBLLLogin _BLLLogin = new BLLLogin();
            epError.Clear();

            try
            {

                if (string.IsNullOrEmpty(this.txtUsuario.Text))
                {
                    epError.SetError(txtUsuario, "Usuario requerido");
                    this.txtUsuario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtContrasena.Text))
                {
                    epError.SetError(txtContrasena, "Contraseá requerida");
                    this.txtContrasena.Focus();
                    return;
                }

                Settings.Default.Login = this.txtUsuario.Text.Trim();
                Settings.Default.Password = this.txtContrasena.Text.Trim();

                _BLLLogin.Login(Settings.Default.Login,
                                Settings.Default.Password);

                //Efecto en la barra de entrada.
                toolStripPbBarra.Visible = true;
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(100);
                    this.toolStripPbBarra.Value += 10;
                    this.sttBarraInferior.Refresh();
                }

                // Log de errores
                _MyLogControlEventos.InfoFormat("Entró a la aplicación");
                this.DialogResult = DialogResult.OK;
            }
            catch (SqlException sqlError)
            {
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: \n" + Utilitarios.GetCustomErrorByNumber(sqlError), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Si el contador es 3 cierre la aplicación
                if (contador == 3)
                {
                    // se devuelve Cancel
                    MessageBox.Show("Se equivocó en 3 ocasiones, el Sistema se Cerrará por seguridad","Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    Application.Exit();
                }
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //catch (Sql er)
            //{

            //    StringBuilder msg = new StringBuilder();
            //    msg.AppendFormat("Message        {0}\n", er.Message);
            //    msg.AppendFormat("Source         {0}\n", er.Source);
            //    msg.AppendFormat("InnerException {0}\n", er.InnerException);
            //    msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
            //    msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
            //    msg.AppendFormat("Usuario        {0}\n", Settings.Default.Login);

            //    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());


            //    // Incrementar el contador
            //    contador++;

            //    // Si el mensaje es "Error de inicio de sesión del usuario" es un error de usuario inválido 
            //    if (er.Message.Trim().Contains("Error de inicio de sesión del usuario") == true || er.Message.Trim().Contains("Login failed") == true)
            //        MessageBox.Show("Usuario inválido, intento No " + contador, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else
            //        // otro Error
            //        MessageBox.Show("Error ->" + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    // Si el contador es 3 cierre la aplicación
            //    if (contador == 3)
            //    {
            //        // se devuelve Cancel
            //        this.DialogResult = DialogResult.Cancel;
            //        Application.Exit();
            //    }

            //}

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            try
            {
                this.Text = Application.ProductName + " Versión:  " + Application.ProductVersion;

                _MyLogControlEventos.InfoFormat("Inicio Login");
            }
            catch (Exception er)
            { 

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
