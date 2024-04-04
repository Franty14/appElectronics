namespace UTN.Winform.Electronics.Layers.UI
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sttBarraInferior = new System.Windows.Forms.StatusStrip();
            this.toolStripPbBarra = new System.Windows.Forms.ToolStripProgressBar();
            this.tlpPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.sttBarraInferior.SuspendLayout();
            this.tlpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // sttBarraInferior
            // 
            this.sttBarraInferior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sttBarraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPbBarra});
            this.sttBarraInferior.Location = new System.Drawing.Point(0, 211);
            this.sttBarraInferior.Name = "sttBarraInferior";
            this.sttBarraInferior.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sttBarraInferior.Size = new System.Drawing.Size(393, 22);
            this.sttBarraInferior.TabIndex = 0;
            this.sttBarraInferior.Text = "statusStrip1";
            // 
            // toolStripPbBarra
            // 
            this.toolStripPbBarra.Name = "toolStripPbBarra";
            this.toolStripPbBarra.Size = new System.Drawing.Size(133, 17);
            this.toolStripPbBarra.Visible = false;
            // 
            // tlpPanel
            // 
            this.tlpPanel.ColumnCount = 2;
            this.tlpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.69863F));
            this.tlpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.30137F));
            this.tlpPanel.Controls.Add(this.label1, 0, 0);
            this.tlpPanel.Controls.Add(this.label2, 0, 1);
            this.tlpPanel.Controls.Add(this.txtUsuario, 1, 0);
            this.tlpPanel.Controls.Add(this.txtContrasena, 1, 1);
            this.tlpPanel.Location = new System.Drawing.Point(19, 28);
            this.tlpPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpPanel.Name = "tlpPanel";
            this.tlpPanel.RowCount = 2;
            this.tlpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPanel.Size = new System.Drawing.Size(359, 87);
            this.tlpPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(142, 4);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(169, 22);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "sa";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(142, 47);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(169, 22);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.Text = "123456";
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = global::UTN.Winform.Electronics.Properties.Resources.window_close_2;
            this.btnSalir.Location = new System.Drawing.Point(197, 128);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 65);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::UTN.Winform.Electronics.Properties.Resources.dialog_ok;
            this.btnAceptar.Location = new System.Drawing.Point(19, 129);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(159, 65);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(393, 233);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tlpPanel);
            this.Controls.Add(this.sttBarraInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.sttBarraInferior.ResumeLayout(false);
            this.sttBarraInferior.PerformLayout();
            this.tlpPanel.ResumeLayout(false);
            this.tlpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttBarraInferior;
        private System.Windows.Forms.TableLayoutPanel tlpPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripProgressBar toolStripPbBarra;
        private System.Windows.Forms.ErrorProvider epError;
    }
}