namespace facturilla
{
    partial class FormCompra
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
      this.label3 = new System.Windows.Forms.Label();
      this.desplegablePescados = new System.Windows.Forms.ComboBox();
      this.detallecartel = new System.Windows.Forms.Label();
      this.precio = new System.Windows.Forms.Label();
      this.cantidad = new System.Windows.Forms.Label();
      this.txtkilo = new System.Windows.Forms.NumericUpDown();
      this.txtcantidad = new System.Windows.Forms.NumericUpDown();
      this.desplegableClientes = new System.Windows.Forms.ComboBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.labelClienteSeleccionado = new System.Windows.Forms.Label();
      this.selectorFecha = new System.Windows.Forms.DateTimePicker();
      this.buttonPagos = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.labelPreciokg = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.checkBoxPagado = new System.Windows.Forms.CheckBox();
      this.label7 = new System.Windows.Forms.Label();
      this.labelTotalCompra = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.buttonStock = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.desplegableFrigos = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.txtkilo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(706, 99);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(0, 13);
      this.label3.TabIndex = 8;
      // 
      // desplegablePescados
      // 
      this.desplegablePescados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.desplegablePescados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.desplegablePescados.FormattingEnabled = true;
      this.desplegablePescados.Location = new System.Drawing.Point(96, 106);
      this.desplegablePescados.MaxDropDownItems = 100;
      this.desplegablePescados.Name = "desplegablePescados";
      this.desplegablePescados.Size = new System.Drawing.Size(143, 21);
      this.desplegablePescados.TabIndex = 9;
      this.desplegablePescados.SelectedIndexChanged += new System.EventHandler(this.desplegablePescados_SelectedIndexChanged);
      // 
      // detallecartel
      // 
      this.detallecartel.AutoSize = true;
      this.detallecartel.Location = new System.Drawing.Point(93, 90);
      this.detallecartel.Name = "detallecartel";
      this.detallecartel.Size = new System.Drawing.Size(40, 13);
      this.detallecartel.TabIndex = 10;
      this.detallecartel.Text = "Detalle";
      // 
      // precio
      // 
      this.precio.AutoSize = true;
      this.precio.Location = new System.Drawing.Point(245, 91);
      this.precio.Name = "precio";
      this.precio.Size = new System.Drawing.Size(24, 13);
      this.precio.TabIndex = 11;
      this.precio.Text = "Kilo";
      // 
      // cantidad
      // 
      this.cantidad.AutoSize = true;
      this.cantidad.Location = new System.Drawing.Point(12, 90);
      this.cantidad.Name = "cantidad";
      this.cantidad.Size = new System.Drawing.Size(49, 13);
      this.cantidad.TabIndex = 14;
      this.cantidad.Text = "Cantidad";
      // 
      // txtkilo
      // 
      this.txtkilo.DecimalPlaces = 3;
      this.txtkilo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.txtkilo.Location = new System.Drawing.Point(245, 106);
      this.txtkilo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.txtkilo.Name = "txtkilo";
      this.txtkilo.Size = new System.Drawing.Size(120, 20);
      this.txtkilo.TabIndex = 19;
      this.txtkilo.ValueChanged += new System.EventHandler(this.txtkilo_ValueChanged);
      // 
      // txtcantidad
      // 
      this.txtcantidad.Location = new System.Drawing.Point(12, 106);
      this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.txtcantidad.Name = "txtcantidad";
      this.txtcantidad.Size = new System.Drawing.Size(78, 20);
      this.txtcantidad.TabIndex = 20;
      // 
      // desplegableClientes
      // 
      this.desplegableClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.desplegableClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.desplegableClientes.FormattingEnabled = true;
      this.desplegableClientes.Location = new System.Drawing.Point(12, 25);
      this.desplegableClientes.MaxDropDownItems = 100;
      this.desplegableClientes.Name = "desplegableClientes";
      this.desplegableClientes.Size = new System.Drawing.Size(331, 21);
      this.desplegableClientes.TabIndex = 22;
      this.desplegableClientes.SelectedValueChanged += new System.EventHandler(this.cargarTablaDeClienteSeleccionado);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(349, 24);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(107, 22);
      this.button2.TabIndex = 23;
      this.button2.Text = "Añadir cliente";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.irAClienteNuevo);
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.Location = new System.Drawing.Point(569, 24);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(119, 22);
      this.button3.TabIndex = 24;
      this.button3.Text = "Definir precios";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.irADefinirPrecios);
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.Location = new System.Drawing.Point(245, 132);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(440, 34);
      this.button4.TabIndex = 26;
      this.button4.Text = "Guardar operación";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.crearCompra);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(492, 90);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 13);
      this.label1.TabIndex = 29;
      this.label1.Text = "Fecha";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 13);
      this.label2.TabIndex = 30;
      this.label2.Text = "Clientes";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(371, 91);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 13);
      this.label4.TabIndex = 32;
      this.label4.Text = "Precio / kg";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(9, 176);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(102, 13);
      this.label5.TabIndex = 34;
      this.label5.Text = "Compras del cliente:";
      // 
      // labelClienteSeleccionado
      // 
      this.labelClienteSeleccionado.AutoSize = true;
      this.labelClienteSeleccionado.Location = new System.Drawing.Point(114, 176);
      this.labelClienteSeleccionado.Name = "labelClienteSeleccionado";
      this.labelClienteSeleccionado.Size = new System.Drawing.Size(10, 13);
      this.labelClienteSeleccionado.TabIndex = 35;
      this.labelClienteSeleccionado.Text = "-";
      // 
      // selectorFecha
      // 
      this.selectorFecha.Location = new System.Drawing.Point(495, 106);
      this.selectorFecha.Name = "selectorFecha";
      this.selectorFecha.Size = new System.Drawing.Size(190, 20);
      this.selectorFecha.TabIndex = 36;
      // 
      // buttonPagos
      // 
      this.buttonPagos.Location = new System.Drawing.Point(462, 24);
      this.buttonPagos.Name = "buttonPagos";
      this.buttonPagos.Size = new System.Drawing.Size(101, 22);
      this.buttonPagos.TabIndex = 37;
      this.buttonPagos.Text = "Pagos y deudas";
      this.buttonPagos.UseVisualStyleBackColor = true;
      this.buttonPagos.Click += new System.EventHandler(this.irAPagos);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 195);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(676, 197);
      this.dataGridView1.TabIndex = 38;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // labelPreciokg
      // 
      this.labelPreciokg.AutoSize = true;
      this.labelPreciokg.Location = new System.Drawing.Point(371, 109);
      this.labelPreciokg.Name = "labelPreciokg";
      this.labelPreciokg.Size = new System.Drawing.Size(10, 13);
      this.labelPreciokg.TabIndex = 39;
      this.labelPreciokg.Text = "-";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(418, 109);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(13, 13);
      this.label6.TabIndex = 40;
      this.label6.Text = "$";
      // 
      // checkBoxPagado
      // 
      this.checkBoxPagado.AutoSize = true;
      this.checkBoxPagado.Checked = true;
      this.checkBoxPagado.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxPagado.Location = new System.Drawing.Point(587, 172);
      this.checkBoxPagado.Name = "checkBoxPagado";
      this.checkBoxPagado.Size = new System.Drawing.Size(101, 17);
      this.checkBoxPagado.TabIndex = 41;
      this.checkBoxPagado.Text = "Compra pagada";
      this.checkBoxPagado.UseVisualStyleBackColor = true;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(437, 90);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(34, 13);
      this.label7.TabIndex = 42;
      this.label7.Text = "Total:";
      // 
      // labelTotalCompra
      // 
      this.labelTotalCompra.AutoSize = true;
      this.labelTotalCompra.Location = new System.Drawing.Point(445, 109);
      this.labelTotalCompra.Name = "labelTotalCompra";
      this.labelTotalCompra.Size = new System.Drawing.Size(10, 13);
      this.labelTotalCompra.TabIndex = 43;
      this.labelTotalCompra.Text = "-";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(476, 108);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(13, 13);
      this.label8.TabIndex = 44;
      this.label8.Text = "$";
      // 
      // buttonStock
      // 
      this.buttonStock.Location = new System.Drawing.Point(349, 52);
      this.buttonStock.Name = "buttonStock";
      this.buttonStock.Size = new System.Drawing.Size(339, 23);
      this.buttonStock.TabIndex = 45;
      this.buttonStock.Text = "Gestionar stock";
      this.buttonStock.UseVisualStyleBackColor = true;
      this.buttonStock.Click += new System.EventHandler(this.irAStock);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(12, 129);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(54, 13);
      this.label9.TabIndex = 46;
      this.label9.Text = "Frigorífico";
      // 
      // desplegableFrigos
      // 
      this.desplegableFrigos.FormattingEnabled = true;
      this.desplegableFrigos.Location = new System.Drawing.Point(12, 145);
      this.desplegableFrigos.Name = "desplegableFrigos";
      this.desplegableFrigos.Size = new System.Drawing.Size(223, 21);
      this.desplegableFrigos.TabIndex = 47;
      // 
      // FormCompra
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.ClientSize = new System.Drawing.Size(706, 417);
      this.Controls.Add(this.desplegableFrigos);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.buttonStock);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.labelTotalCompra);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.checkBoxPagado);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.labelPreciokg);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.buttonPagos);
      this.Controls.Add(this.selectorFecha);
      this.Controls.Add(this.labelClienteSeleccionado);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.desplegableClientes);
      this.Controls.Add(this.txtcantidad);
      this.Controls.Add(this.txtkilo);
      this.Controls.Add(this.cantidad);
      this.Controls.Add(this.precio);
      this.Controls.Add(this.detallecartel);
      this.Controls.Add(this.desplegablePescados);
      this.Controls.Add(this.label3);
      this.Name = "FormCompra";
      this.Text = "ventas";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.txtkilo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox desplegablePescados;
        private System.Windows.Forms.Label detallecartel;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.NumericUpDown txtkilo;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.ComboBox desplegableClientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label labelClienteSeleccionado;
    private System.Windows.Forms.DateTimePicker selectorFecha;
    private System.Windows.Forms.Button buttonPagos;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label labelPreciokg;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.CheckBox checkBoxPagado;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label labelTotalCompra;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button buttonStock;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox desplegableFrigos;
  }
}

