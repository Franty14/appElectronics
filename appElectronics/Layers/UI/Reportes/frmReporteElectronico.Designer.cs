namespace UTN.Winform.Electronics.Layers.UI.Reportes
{
    partial class frmReporteElectronico
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ElectronicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSReportes = new UTN.Winform.Electronics.Layers.UI.Reportes.DSReportes();
            this.sttBarraInferior = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripTxtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.rptVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ElectronicoTableAdapter = new UTN.Winform.Electronics.Layers.UI.Reportes.DSReportesTableAdapters.ElectronicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ElectronicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElectronicoBindingSource
            // 
            this.ElectronicoBindingSource.DataMember = "Electronico";
            this.ElectronicoBindingSource.DataSource = this.DSReportes;
            // 
            // DSReportes
            // 
            this.DSReportes.DataSetName = "DSReportes";
            this.DSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sttBarraInferior
            // 
            this.sttBarraInferior.Location = new System.Drawing.Point(0, 368);
            this.sttBarraInferior.Name = "sttBarraInferior";
            this.sttBarraInferior.Size = new System.Drawing.Size(841, 22);
            this.sttBarraInferior.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnBuscar,
            this.toolStripTxtFiltro,
            this.toolStripBtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(841, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnBuscar
            // 
            this.toolStripBtnBuscar.Image = global::UTN.Winform.Electronics.Properties.Resources.edit_find;
            this.toolStripBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBuscar.Name = "toolStripBtnBuscar";
            this.toolStripBtnBuscar.Size = new System.Drawing.Size(94, 52);
            this.toolStripBtnBuscar.Text = "Buscar";
            this.toolStripBtnBuscar.Click += new System.EventHandler(this.toolStripBtnBuscar_Click);
            // 
            // toolStripTxtFiltro
            // 
            this.toolStripTxtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTxtFiltro.Name = "toolStripTxtFiltro";
            this.toolStripTxtFiltro.Size = new System.Drawing.Size(100, 55);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = global::UTN.Winform.Electronics.Properties.Resources.window_close_2;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(81, 52);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // rptVisor
            // 
            this.rptVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSElectronico";
            reportDataSource1.Value = this.ElectronicoBindingSource;
            this.rptVisor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVisor.LocalReport.ReportEmbeddedResource = "UTN.Winform.Electronics.Layers.UI.Reportes.rptReporteElectronico.rdlc";
            this.rptVisor.Location = new System.Drawing.Point(0, 55);
            this.rptVisor.Name = "rptVisor";
            this.rptVisor.Size = new System.Drawing.Size(841, 313);
            this.rptVisor.TabIndex = 2;
            // 
            // ElectronicoTableAdapter
            // 
            this.ElectronicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteElectronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 390);
            this.Controls.Add(this.rptVisor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.sttBarraInferior);
            this.Name = "frmReporteElectronico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Electronico";
            this.Load += new System.EventHandler(this.frmReporteElectronico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElectronicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttBarraInferior;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Microsoft.Reporting.WinForms.ReportViewer rptVisor;
        private System.Windows.Forms.BindingSource ElectronicoBindingSource;
        private DSReportes DSReportes;
        private DSReportesTableAdapters.ElectronicoTableAdapter ElectronicoTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripBtnBuscar;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtFiltro;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
    }
}