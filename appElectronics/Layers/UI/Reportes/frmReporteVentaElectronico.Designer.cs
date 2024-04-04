namespace UTN.Winform.Electronics.Layers.UI.Reportes
{
    partial class frmReporteVentaElectronico
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
            this.ventaElectronicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReportes = new UTN.Winform.Electronics.Layers.UI.Reportes.DSReportes();
            this.sttBarraInferior = new System.Windows.Forms.StatusStrip();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.rptVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventaElectronicoTableAdapter = new UTN.Winform.Electronics.Layers.UI.Reportes.DSReportesTableAdapters.VentaElectronicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventaElectronicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).BeginInit();
            this.tspBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // ventaElectronicoBindingSource
            // 
            this.ventaElectronicoBindingSource.DataMember = "VentaElectronico";
            this.ventaElectronicoBindingSource.DataSource = this.dSReportes;
            // 
            // dSReportes
            // 
            this.dSReportes.DataSetName = "DSReportes";
            this.dSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sttBarraInferior
            // 
            this.sttBarraInferior.Location = new System.Drawing.Point(0, 497);
            this.sttBarraInferior.Name = "sttBarraInferior";
            this.sttBarraInferior.Size = new System.Drawing.Size(882, 22);
            this.sttBarraInferior.TabIndex = 0;
            this.sttBarraInferior.Text = "statusStrip1";
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(882, 55);
            this.tspBarraSuperior.TabIndex = 1;
            this.tspBarraSuperior.Text = "toolStrip1";
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = global::UTN.Winform.Electronics.Properties.Resources.window_close_2;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(81, 52);
            this.toolStripBtnSalir.Text = "&Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // rptVisor
            // 
            this.rptVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSVentaElectronico";
            reportDataSource1.Value = this.ventaElectronicoBindingSource;
            this.rptVisor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVisor.LocalReport.ReportEmbeddedResource = "UTN.Winform.Electronics.Layers.UI.Reportes.rptReporteVentaElectronico.rdlc";
            this.rptVisor.Location = new System.Drawing.Point(0, 55);
            this.rptVisor.Name = "rptVisor";
            this.rptVisor.Size = new System.Drawing.Size(882, 442);
            this.rptVisor.TabIndex = 2;
            // 
            // ventaElectronicoTableAdapter
            // 
            this.ventaElectronicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteVentaElectronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 519);
            this.Controls.Add(this.rptVisor);
            this.Controls.Add(this.tspBarraSuperior);
            this.Controls.Add(this.sttBarraInferior);
            this.Name = "frmReporteVentaElectronico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Ventas Electronicos";
            this.Load += new System.EventHandler(this.frmReporteVentaElectronico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventaElectronicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).EndInit();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttBarraInferior;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer rptVisor;
        private DSReportes dSReportes;
        private System.Windows.Forms.BindingSource ventaElectronicoBindingSource;
        private DSReportesTableAdapters.VentaElectronicoTableAdapter ventaElectronicoTableAdapter;
    }
}