namespace UTN.Winform.Electronics.Layers.UI.Reportes
{
    partial class frmReporteFactura
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
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSReportes = new UTN.Winform.Electronics.Layers.UI.Reportes.DSReportes();
            this.sttBarraInferior = new System.Windows.Forms.StatusStrip();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnExportarPDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.rptVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaTableAdapter = new UTN.Winform.Electronics.Layers.UI.Reportes.DSReportesTableAdapters.FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).BeginInit();
            this.tspBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataMember = "Factura";
            this.FacturaBindingSource.DataSource = this.DSReportes;
            // 
            // DSReportes
            // 
            this.DSReportes.DataSetName = "DSReportes";
            this.DSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sttBarraInferior
            // 
            this.sttBarraInferior.Location = new System.Drawing.Point(0, 464);
            this.sttBarraInferior.Name = "sttBarraInferior";
            this.sttBarraInferior.Size = new System.Drawing.Size(800, 22);
            this.sttBarraInferior.TabIndex = 0;
            this.sttBarraInferior.Text = "statusStrip1";
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnExportarPDF,
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(800, 55);
            this.tspBarraSuperior.TabIndex = 1;
            this.tspBarraSuperior.Text = "toolStrip1";
            // 
            // toolStripBtnExportarPDF
            // 
            this.toolStripBtnExportarPDF.Image = global::UTN.Winform.Electronics.Properties.Resources.pdfforge;
            this.toolStripBtnExportarPDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnExportarPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExportarPDF.Name = "toolStripBtnExportarPDF";
            this.toolStripBtnExportarPDF.Size = new System.Drawing.Size(126, 52);
            this.toolStripBtnExportarPDF.Text = "Exportar PDF";
            this.toolStripBtnExportarPDF.Click += new System.EventHandler(this.toolStripBtnExportarPDF_Click);
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
            reportDataSource1.Name = "ReporteFactura";
            reportDataSource1.Value = this.FacturaBindingSource;
            this.rptVisor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVisor.LocalReport.ReportEmbeddedResource = "UTN.Winform.Electronics.Layers.UI.Reportes.rptReporteFactura.rdlc";
            this.rptVisor.Location = new System.Drawing.Point(0, 55);
            this.rptVisor.Name = "rptVisor";
            this.rptVisor.Size = new System.Drawing.Size(800, 409);
            this.rptVisor.TabIndex = 2;
            // 
            // FacturaTableAdapter
            // 
            this.FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.rptVisor);
            this.Controls.Add(this.tspBarraSuperior);
            this.Controls.Add(this.sttBarraInferior);
            this.Name = "frmReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).EndInit();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttBarraInferior;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnExportarPDF;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer rptVisor;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
        private DSReportes DSReportes;
        private DSReportesTableAdapters.FacturaTableAdapter FacturaTableAdapter;
    }
}