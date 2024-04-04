namespace UTN.Winform.Electronics.Layers.UI.Procesos
{
    partial class frmFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sttBarraInferior = new System.Windows.Forms.StatusStrip();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnFacturar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tlpAgrupamiento = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.rdbContado = new System.Windows.Forms.RadioButton();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCodigoProduto = new System.Windows.Forms.MaskedTextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.mskCantidad = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcionElectronico = new System.Windows.Forms.TextBox();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tspBarraSuperior.SuspendLayout();
            this.tlpAgrupamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // sttBarraInferior
            // 
            this.sttBarraInferior.Location = new System.Drawing.Point(0, 467);
            this.sttBarraInferior.Name = "sttBarraInferior";
            this.sttBarraInferior.Size = new System.Drawing.Size(1020, 22);
            this.sttBarraInferior.TabIndex = 0;
            this.sttBarraInferior.Text = "statusStrip1";
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNuevo,
            this.toolStripBtnFacturar,
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(1020, 55);
            this.tspBarraSuperior.TabIndex = 1;
            this.tspBarraSuperior.Text = "toolStrip1";
            this.tspBarraSuperior.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tspBarraSuperior_ItemClicked);
            // 
            // toolStripBtnNuevo
            // 
            this.toolStripBtnNuevo.Image = global::UTN.Winform.Electronics.Properties.Resources.document_new_4;
            this.toolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNuevo.Name = "toolStripBtnNuevo";
            this.toolStripBtnNuevo.Size = new System.Drawing.Size(94, 52);
            this.toolStripBtnNuevo.Text = "Nuevo";
            this.toolStripBtnNuevo.Click += new System.EventHandler(this.toolStripBtnNuevo_Click);
            // 
            // toolStripBtnFacturar
            // 
            this.toolStripBtnFacturar.Image = global::UTN.Winform.Electronics.Properties.Resources.accessories_calculator_3;
            this.toolStripBtnFacturar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFacturar.Name = "toolStripBtnFacturar";
            this.toolStripBtnFacturar.Size = new System.Drawing.Size(102, 52);
            this.toolStripBtnFacturar.Text = "Facturar";
            this.toolStripBtnFacturar.Click += new System.EventHandler(this.toolStripBtnFacturar_Click);
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
            // tlpAgrupamiento
            // 
            this.tlpAgrupamiento.BackColor = System.Drawing.SystemColors.Control;
            this.tlpAgrupamiento.ColumnCount = 3;
            this.tlpAgrupamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tlpAgrupamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tlpAgrupamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 306F));
            this.tlpAgrupamiento.Controls.Add(this.label3, 0, 4);
            this.tlpAgrupamiento.Controls.Add(this.label2, 0, 3);
            this.tlpAgrupamiento.Controls.Add(this.label4, 0, 2);
            this.tlpAgrupamiento.Controls.Add(this.txtNumeroTarjeta, 1, 3);
            this.tlpAgrupamiento.Controls.Add(this.txtClienteId, 1, 4);
            this.tlpAgrupamiento.Controls.Add(this.rdbContado, 1, 1);
            this.tlpAgrupamiento.Controls.Add(this.cmbTarjeta, 1, 2);
            this.tlpAgrupamiento.Controls.Add(this.btnBuscarCliente, 2, 3);
            this.tlpAgrupamiento.Controls.Add(this.label1, 0, 1);
            this.tlpAgrupamiento.Controls.Add(this.label11, 0, 0);
            this.tlpAgrupamiento.Controls.Add(this.txtNumeroFactura, 1, 0);
            this.tlpAgrupamiento.Controls.Add(this.txtNombreCliente, 1, 5);
            this.tlpAgrupamiento.Controls.Add(this.label12, 0, 5);
            this.tlpAgrupamiento.Controls.Add(this.rdbCredito, 2, 1);
            this.tlpAgrupamiento.Location = new System.Drawing.Point(16, 29);
            this.tlpAgrupamiento.Name = "tlpAgrupamiento";
            this.tlpAgrupamiento.RowCount = 6;
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgrupamiento.Size = new System.Drawing.Size(493, 175);
            this.tlpAgrupamiento.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No Tarjeta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarjeta";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(132, 79);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(192, 20);
            this.txtNumeroTarjeta.TabIndex = 6;
            this.txtNumeroTarjeta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroTarjeta_KeyDown);
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(132, 105);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(192, 20);
            this.txtClienteId.TabIndex = 8;
            // 
            // rdbContado
            // 
            this.rdbContado.AutoSize = true;
            this.rdbContado.Location = new System.Drawing.Point(132, 29);
            this.rdbContado.Name = "rdbContado";
            this.rdbContado.Size = new System.Drawing.Size(65, 17);
            this.rdbContado.TabIndex = 4;
            this.rdbContado.Text = "Contado";
            this.rdbContado.UseVisualStyleBackColor = true;
            this.rdbContado.CheckedChanged += new System.EventHandler(this.rdbContado_CheckedChanged);
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(132, 52);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(192, 21);
            this.cmbTarjeta.TabIndex = 7;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::UTN.Winform.Electronics.Properties.Resources.edit_find;
            this.btnBuscarCliente.Location = new System.Drawing.Point(340, 79);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.tlpAgrupamiento.SetRowSpan(this.btnBuscarCliente, 2);
            this.btnBuscarCliente.Size = new System.Drawing.Size(110, 56);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "No. Factura";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(132, 3);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroFactura.TabIndex = 12;
            // 
            // txtNombreCliente
            // 
            this.tlpAgrupamiento.SetColumnSpan(this.txtNombreCliente, 2);
            this.txtNombreCliente.Location = new System.Drawing.Point(132, 141);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(347, 20);
            this.txtNombreCliente.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nombre Cliente";
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Checked = true;
            this.rdbCredito.Location = new System.Drawing.Point(340, 29);
            this.rdbCredito.Name = "rdbCredito";
            this.tlpAgrupamiento.SetRowSpan(this.rdbCredito, 2);
            this.rdbCredito.Size = new System.Drawing.Size(58, 17);
            this.rdbCredito.TabIndex = 5;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            this.rdbCredito.CheckedChanged += new System.EventHandler(this.rdbCredito_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código Producto";
            // 
            // mskCodigoProduto
            // 
            this.mskCodigoProduto.Location = new System.Drawing.Point(134, 3);
            this.mskCodigoProduto.Mask = "99999999999";
            this.mskCodigoProduto.Name = "mskCodigoProduto";
            this.mskCodigoProduto.Size = new System.Drawing.Size(193, 20);
            this.mskCodigoProduto.TabIndex = 4;
            this.mskCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCodigoProduto_KeyDown);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(3, 99);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // mskCantidad
            // 
            this.mskCantidad.Location = new System.Drawing.Point(134, 102);
            this.mskCantidad.Mask = "999999999999";
            this.mskCantidad.Name = "mskCantidad";
            this.mskCantidad.Size = new System.Drawing.Size(193, 20);
            this.mskCantidad.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(134, 128);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(193, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtDescripcionElectronico
            // 
            this.txtDescripcionElectronico.Location = new System.Drawing.Point(134, 29);
            this.txtDescripcionElectronico.Name = "txtDescripcionElectronico";
            this.txtDescripcionElectronico.ReadOnly = true;
            this.txtDescripcionElectronico.Size = new System.Drawing.Size(193, 20);
            this.txtDescripcionElectronico.TabIndex = 11;
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AllowUserToAddRows = false;
            this.dgvDetalleFactura.AllowUserToDeleteRows = false;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDetalleFactura.Location = new System.Drawing.Point(549, 80);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.ReadOnly = true;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(537, 284);
            this.dgvDetalleFactura.TabIndex = 4;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdElectronico";
            this.Column1.HeaderText = "IdElectronico";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DescripcionElectronico";
            this.Column2.HeaderText = "Descripcion Electronico";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.ToolTipText = "0";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.68208F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.31792F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtSubtotal, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtImpuesto, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTotal, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(913, 370);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(173, 81);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Subtotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Impuesto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(62, 3);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(108, 20);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(62, 29);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(108, 20);
            this.txtImpuesto.TabIndex = 4;
            this.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(62, 55);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(108, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlpAgrupamiento);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(7, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 398);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturación";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.9822F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.0178F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblCantidad, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtPrecio, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnBuscarProducto, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.mskCantidad, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.mskCodigoProduto, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAgregar, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtDescripcionElectronico, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtExistencia, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 278);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(493, 169);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::UTN.Winform.Electronics.Properties.Resources.edit_find;
            this.btnBuscarProducto.Location = new System.Drawing.Point(347, 3);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.tableLayoutPanel3.SetRowSpan(this.btnBuscarProducto, 2);
            this.btnBuscarProducto.Size = new System.Drawing.Size(110, 67);
            this.btnBuscarProducto.TabIndex = 1;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::UTN.Winform.Electronics.Properties.Resources.db_add;
            this.btnAgregar.Location = new System.Drawing.Point(347, 102);
            this.btnAgregar.Name = "btnAgregar";
            this.tableLayoutPanel3.SetRowSpan(this.btnAgregar, 2);
            this.btnAgregar.Size = new System.Drawing.Size(110, 57);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Existencia";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(134, 76);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.ReadOnly = true;
            this.txtExistencia.Size = new System.Drawing.Size(193, 20);
            this.txtExistencia.TabIndex = 13;
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(535, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 397);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 489);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dgvDetalleFactura);
            this.Controls.Add(this.tspBarraSuperior);
            this.Controls.Add(this.sttBarraInferior);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.tlpAgrupamiento.ResumeLayout(false);
            this.tlpAgrupamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttBarraInferior;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBtnFacturar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.TableLayoutPanel tlpAgrupamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbContado;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.MaskedTextBox mskCodigoProduto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.MaskedTextBox mskCantidad;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcionElectronico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}