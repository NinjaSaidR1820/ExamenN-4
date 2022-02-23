namespace Imagen1.Formularios
{
    partial class AgregarDatos
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rbFactura = new System.Windows.Forms.RadioButton();
            this.rbExistenciaYNombre = new System.Windows.Forms.RadioButton();
            this.txtCONSULTA = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnIngresarProductos = new System.Windows.Forms.Button();
            this.txtUnidadExistencia = new System.Windows.Forms.TextBox();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.txtCodigoProduct = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnIngresarPedido = new System.Windows.Forms.Button();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente2 = new System.Windows.Forms.TextBox();
            this.txtCodigoVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.rbClientes = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.radioButton1);
            this.tabPage4.Controls.Add(this.rbClientes);
            this.tabPage4.Controls.Add(this.rbFactura);
            this.tabPage4.Controls.Add(this.rbExistenciaYNombre);
            this.tabPage4.Controls.Add(this.txtCONSULTA);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(617, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consultas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rbFactura
            // 
            this.rbFactura.AutoSize = true;
            this.rbFactura.Location = new System.Drawing.Point(232, 44);
            this.rbFactura.Name = "rbFactura";
            this.rbFactura.Size = new System.Drawing.Size(132, 17);
            this.rbFactura.TabIndex = 4;
            this.rbFactura.TabStop = true;
            this.rbFactura.Text = "Factura de los Clientes";
            this.rbFactura.UseVisualStyleBackColor = true;
            this.rbFactura.CheckedChanged += new System.EventHandler(this.rbFactura_CheckedChanged);
            // 
            // rbExistenciaYNombre
            // 
            this.rbExistenciaYNombre.AutoSize = true;
            this.rbExistenciaYNombre.Location = new System.Drawing.Point(44, 44);
            this.rbExistenciaYNombre.Name = "rbExistenciaYNombre";
            this.rbExistenciaYNombre.Size = new System.Drawing.Size(182, 17);
            this.rbExistenciaYNombre.TabIndex = 1;
            this.rbExistenciaYNombre.TabStop = true;
            this.rbExistenciaYNombre.Text = "Nombre de Producto y Existencia";
            this.rbExistenciaYNombre.UseVisualStyleBackColor = true;
            this.rbExistenciaYNombre.CheckedChanged += new System.EventHandler(this.rbExistenciaYNombre_CheckedChanged);
            // 
            // txtCONSULTA
            // 
            this.txtCONSULTA.Location = new System.Drawing.Point(44, 122);
            this.txtCONSULTA.Multiline = true;
            this.txtCONSULTA.Name = "txtCONSULTA";
            this.txtCONSULTA.ReadOnly = true;
            this.txtCONSULTA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCONSULTA.Size = new System.Drawing.Size(423, 140);
            this.txtCONSULTA.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.progressBar2);
            this.tabPage3.Controls.Add(this.dgvProductos);
            this.tabPage3.Controls.Add(this.btnIngresarProductos);
            this.tabPage3.Controls.Add(this.txtUnidadExistencia);
            this.tabPage3.Controls.Add(this.txtPrecioUnidad);
            this.tabPage3.Controls.Add(this.txtCodigoProduct);
            this.tabPage3.Controls.Add(this.txtNombreProducto);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(617, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(0, 242);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(525, 150);
            this.dgvProductos.TabIndex = 11;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellContentClick);
            // 
            // btnIngresarProductos
            // 
            this.btnIngresarProductos.Location = new System.Drawing.Point(380, 75);
            this.btnIngresarProductos.Name = "btnIngresarProductos";
            this.btnIngresarProductos.Size = new System.Drawing.Size(98, 42);
            this.btnIngresarProductos.TabIndex = 10;
            this.btnIngresarProductos.Text = "Ingresar";
            this.btnIngresarProductos.UseVisualStyleBackColor = true;
            this.btnIngresarProductos.Click += new System.EventHandler(this.btnIngresarProductos_Click);
            // 
            // txtUnidadExistencia
            // 
            this.txtUnidadExistencia.Location = new System.Drawing.Point(155, 156);
            this.txtUnidadExistencia.Name = "txtUnidadExistencia";
            this.txtUnidadExistencia.Size = new System.Drawing.Size(182, 20);
            this.txtUnidadExistencia.TabIndex = 9;
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(155, 117);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(182, 20);
            this.txtPrecioUnidad.TabIndex = 8;
            // 
            // txtCodigoProduct
            // 
            this.txtCodigoProduct.Location = new System.Drawing.Point(155, 61);
            this.txtCodigoProduct.Name = "txtCodigoProduct";
            this.txtCodigoProduct.Size = new System.Drawing.Size(182, 20);
            this.txtCodigoProduct.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(155, 87);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(182, 20);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Unidad en Existencia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Precio Unidad";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Codigo Producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nombre Producto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar3);
            this.tabPage2.Controls.Add(this.btnIngresarPedido);
            this.tabPage2.Controls.Add(this.DtpFecha);
            this.tabPage2.Controls.Add(this.txtCantidad);
            this.tabPage2.Controls.Add(this.txtCodigoProducto);
            this.tabPage2.Controls.Add(this.txtCodigoCliente2);
            this.tabPage2.Controls.Add(this.txtCodigoVenta);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dgvPedidos);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(617, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pedidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnIngresarPedido
            // 
            this.btnIngresarPedido.Location = new System.Drawing.Point(28, 177);
            this.btnIngresarPedido.Name = "btnIngresarPedido";
            this.btnIngresarPedido.Size = new System.Drawing.Size(98, 42);
            this.btnIngresarPedido.TabIndex = 14;
            this.btnIngresarPedido.Text = "Ingresar";
            this.btnIngresarPedido.UseVisualStyleBackColor = true;
            this.btnIngresarPedido.Click += new System.EventHandler(this.btnIngresarPedido_Click);
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(390, 70);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 20);
            this.DtpFecha.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(393, 37);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(197, 20);
            this.txtCantidad.TabIndex = 12;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(118, 37);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(173, 20);
            this.txtCodigoProducto.TabIndex = 6;
            // 
            // txtCodigoCliente2
            // 
            this.txtCodigoCliente2.Location = new System.Drawing.Point(118, 105);
            this.txtCodigoCliente2.Name = "txtCodigoCliente2";
            this.txtCodigoCliente2.Size = new System.Drawing.Size(173, 20);
            this.txtCodigoCliente2.TabIndex = 5;
            this.txtCodigoCliente2.TextChanged += new System.EventHandler(this.txtNumeroPedido_TextChanged);
            // 
            // txtCodigoVenta
            // 
            this.txtCodigoVenta.Location = new System.Drawing.Point(118, 69);
            this.txtCodigoVenta.Name = "txtCodigoVenta";
            this.txtCodigoVenta.Size = new System.Drawing.Size(173, 20);
            this.txtCodigoVenta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(45, 225);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(525, 150);
            this.dgvPedidos.TabIndex = 8;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPedidos_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Codigo Producto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "CodigoCliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo de Venta";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.btnGuardarCliente);
            this.tabPage1.Controls.Add(this.dgvClientes);
            this.tabPage1.Controls.Add(this.txtApellidoCliente);
            this.tabPage1.Controls.Add(this.txtNombreCliente);
            this.tabPage1.Controls.Add(this.txtCodigoCliente);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(438, 108);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 23;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(325, 89);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(107, 42);
            this.btnGuardarCliente.TabIndex = 22;
            this.btnGuardarCliente.Text = "Registrar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(45, 170);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(525, 150);
            this.dgvClientes.TabIndex = 21;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(145, 111);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoCliente.TabIndex = 13;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(145, 77);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 12;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(145, 35);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCliente.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Cliente";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(60, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 449);
            this.tabControl1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBar2.ForeColor = System.Drawing.Color.Red;
            this.progressBar2.Location = new System.Drawing.Point(380, 123);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 24;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBar3.ForeColor = System.Drawing.Color.Red;
            this.progressBar3.Location = new System.Drawing.Point(132, 199);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 20);
            this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar3.TabIndex = 24;
            this.progressBar3.Click += new System.EventHandler(this.progressBar3_Click);
            // 
            // rbClientes
            // 
            this.rbClientes.AutoSize = true;
            this.rbClientes.Location = new System.Drawing.Point(385, 44);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(62, 17);
            this.rbClientes.TabIndex = 5;
            this.rbClientes.TabStop = true;
            this.rbClientes.Text = "Clientes";
            this.rbClientes.UseVisualStyleBackColor = true;
            this.rbClientes.CheckedChanged += new System.EventHandler(this.rbClientes_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(54, 82);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TotalFacturas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // AgregarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "AgregarDatos";
            this.Text = "AgregarDatos";
            this.Load += new System.EventHandler(this.AgregarDatos_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton rbExistenciaYNombre;
        private System.Windows.Forms.TextBox txtCONSULTA;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnIngresarProductos;
        protected System.Windows.Forms.TextBox txtUnidadExistencia;
        protected System.Windows.Forms.TextBox txtPrecioUnidad;
        protected System.Windows.Forms.TextBox txtCodigoProduct;
        protected System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnIngresarPedido;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        protected System.Windows.Forms.TextBox txtCantidad;
        protected System.Windows.Forms.TextBox txtCodigoProducto;
        protected System.Windows.Forms.TextBox txtCodigoCliente2;
        protected System.Windows.Forms.TextBox txtCodigoVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        protected System.Windows.Forms.TextBox txtApellidoCliente;
        protected System.Windows.Forms.TextBox txtNombreCliente;
        protected System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.RadioButton rbFactura;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.RadioButton rbClientes;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}