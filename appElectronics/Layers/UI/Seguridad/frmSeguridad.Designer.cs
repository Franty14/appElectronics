namespace UTN.Winform.Electronics.Layers.UI.Seguridad
{
    partial class frmSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguridad));
            this.sttBarraInferior = new System.Windows.Forms.StatusStrip();
            this.tspBarraPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalvarUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.spcContenedor = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.cmbBaseDatos = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.trvUsuarios = new System.Windows.Forms.TreeView();
            this.imgListaTreeView = new System.Windows.Forms.ImageList(this.components);
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ntfMensaje = new System.Windows.Forms.NotifyIcon(this.components);
            this.tspBarraPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcContenedor)).BeginInit();
            this.spcContenedor.Panel1.SuspendLayout();
            this.spcContenedor.Panel2.SuspendLayout();
            this.spcContenedor.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // sttBarraInferior
            // 
            this.sttBarraInferior.Location = new System.Drawing.Point(0, 327);
            this.sttBarraInferior.Name = "sttBarraInferior";
            this.sttBarraInferior.Size = new System.Drawing.Size(675, 22);
            this.sttBarraInferior.TabIndex = 0;
            this.sttBarraInferior.Text = "statusStrip1";
            // 
            // tspBarraPrincipal
            // 
            this.tspBarraPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNuevo,
            this.toolStripBtnSalvarUsuario,
            this.toolStripBtnSalir});
            this.tspBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspBarraPrincipal.Name = "tspBarraPrincipal";
            this.tspBarraPrincipal.Size = new System.Drawing.Size(675, 55);
            this.tspBarraPrincipal.TabIndex = 1;
            this.tspBarraPrincipal.Text = "toolStrip1";
            // 
            // toolStripBtnNuevo
            // 
            this.toolStripBtnNuevo.Image = global::UTN.Winform.Electronics.Properties.Resources.document_new_4;
            this.toolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNuevo.Name = "toolStripBtnNuevo";
            this.toolStripBtnNuevo.Size = new System.Drawing.Size(94, 52);
            this.toolStripBtnNuevo.Text = "&Nuevo";
            this.toolStripBtnNuevo.Click += new System.EventHandler(this.toolStripBtnNuevo_Click);
            // 
            // toolStripBtnSalvarUsuario
            // 
            this.toolStripBtnSalvarUsuario.Image = global::UTN.Winform.Electronics.Properties.Resources.user_new_3;
            this.toolStripBtnSalvarUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalvarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalvarUsuario.Name = "toolStripBtnSalvarUsuario";
            this.toolStripBtnSalvarUsuario.Size = new System.Drawing.Size(90, 52);
            this.toolStripBtnSalvarUsuario.Text = "&Salvar";
            this.toolStripBtnSalvarUsuario.Click += new System.EventHandler(this.toolStripBtnSalvarUsuario_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = global::UTN.Winform.Electronics.Properties.Resources.window_close_2;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(81, 52);
            this.toolStripBtnSalir.Text = "Sa&lir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // spcContenedor
            // 
            this.spcContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcContenedor.Location = new System.Drawing.Point(0, 55);
            this.spcContenedor.Name = "spcContenedor";
            // 
            // spcContenedor.Panel1
            // 
            this.spcContenedor.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // spcContenedor.Panel2
            // 
            this.spcContenedor.Panel2.Controls.Add(this.trvUsuarios);
            this.spcContenedor.Size = new System.Drawing.Size(675, 272);
            this.spcContenedor.SplitterDistance = 282;
            this.spcContenedor.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.6F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtContrasena, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBaseDatos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUsuario, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 109);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrasena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Base Datos";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(86, 37);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(157, 20);
            this.txtContrasena.TabIndex = 4;
            // 
            // cmbBaseDatos
            // 
            this.cmbBaseDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaseDatos.FormattingEnabled = true;
            this.cmbBaseDatos.Location = new System.Drawing.Point(86, 69);
            this.cmbBaseDatos.Name = "cmbBaseDatos";
            this.cmbBaseDatos.Size = new System.Drawing.Size(160, 21);
            this.cmbBaseDatos.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(86, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(157, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // trvUsuarios
            // 
            this.trvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvUsuarios.ImageIndex = 0;
            this.trvUsuarios.ImageList = this.imgListaTreeView;
            this.trvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.trvUsuarios.Name = "trvUsuarios";
            this.trvUsuarios.SelectedImageIndex = 0;
            this.trvUsuarios.Size = new System.Drawing.Size(385, 268);
            this.trvUsuarios.TabIndex = 0;
            // 
            // imgListaTreeView
            // 
            this.imgListaTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListaTreeView.ImageStream")));
            this.imgListaTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListaTreeView.Images.SetKeyName(0, "database.jpg");
            this.imgListaTreeView.Images.SetKeyName(1, "userdatabase.png");
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 349);
            this.Controls.Add(this.spcContenedor);
            this.Controls.Add(this.tspBarraPrincipal);
            this.Controls.Add(this.sttBarraInferior);
            this.Name = "frmSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad";
            this.Load += new System.EventHandler(this.frmSeguridad_Load);
            this.tspBarraPrincipal.ResumeLayout(false);
            this.tspBarraPrincipal.PerformLayout();
            this.spcContenedor.Panel1.ResumeLayout(false);
            this.spcContenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcContenedor)).EndInit();
            this.spcContenedor.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttBarraInferior;
        private System.Windows.Forms.ToolStrip tspBarraPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalvarUsuario;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.SplitContainer spcContenedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.ComboBox cmbBaseDatos;
        private System.Windows.Forms.TreeView trvUsuarios;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ImageList imgListaTreeView;
        private System.Windows.Forms.NotifyIcon ntfMensaje;
    }
}