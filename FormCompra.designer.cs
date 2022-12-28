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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label3 = new System.Windows.Forms.Label();
      this.detalle = new System.Windows.Forms.ComboBox();
      this.detallecartel = new System.Windows.Forms.Label();
      this.precio = new System.Windows.Forms.Label();
      this.cantidad = new System.Windows.Forms.Label();
      this.txtresultado = new System.Windows.Forms.Label();
      this.resultado = new System.Windows.Forms.Label();
      this.txtkilo = new System.Windows.Forms.NumericUpDown();
      this.txtcantidad = new System.Windows.Forms.NumericUpDown();
      this.botonResultado = new System.Windows.Forms.Button();
      this.desplegableClientes = new System.Windows.Forms.ComboBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.button4 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.preciokg = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      this.labelClienteSeleccionado = new System.Windows.Forms.Label();
      this.selectorFecha = new System.Windows.Forms.DateTimePicker();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.txtkilo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.preciokg)).BeginInit();
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
      // detalle
      // 
      this.detalle.FormattingEnabled = true;
      this.detalle.Items.AddRange(new object[] {
            "langostinos",
            "merluza",
            "calamar"});
      this.detalle.Location = new System.Drawing.Point(120, 106);
      this.detalle.Name = "detalle";
      this.detalle.Size = new System.Drawing.Size(210, 21);
      this.detalle.TabIndex = 9;
      this.detalle.SelectedIndexChanged += new System.EventHandler(this.detalle_SelectedIndexChanged);
      // 
      // detallecartel
      // 
      this.detallecartel.AutoSize = true;
      this.detallecartel.Location = new System.Drawing.Point(117, 90);
      this.detallecartel.Name = "detallecartel";
      this.detallecartel.Size = new System.Drawing.Size(40, 13);
      this.detallecartel.TabIndex = 10;
      this.detallecartel.Text = "Detalle";
      // 
      // precio
      // 
      this.precio.AutoSize = true;
      this.precio.Location = new System.Drawing.Point(333, 91);
      this.precio.Name = "precio";
      this.precio.Size = new System.Drawing.Size(24, 13);
      this.precio.TabIndex = 11;
      this.precio.Text = "Kilo";
      this.precio.Click += new System.EventHandler(this.precio_Click);
      // 
      // cantidad
      // 
      this.cantidad.AutoSize = true;
      this.cantidad.Location = new System.Drawing.Point(12, 90);
      this.cantidad.Name = "cantidad";
      this.cantidad.Size = new System.Drawing.Size(49, 13);
      this.cantidad.TabIndex = 14;
      this.cantidad.Text = "Cantidad";
      this.cantidad.Click += new System.EventHandler(this.cantidad_Click);
      // 
      // txtresultado
      // 
      this.txtresultado.AutoSize = true;
      this.txtresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.txtresultado.Location = new System.Drawing.Point(4, 9);
      this.txtresultado.Name = "txtresultado";
      this.txtresultado.Size = new System.Drawing.Size(57, 13);
      this.txtresultado.TabIndex = 17;
      this.txtresultado.Text = "TOTAL   $";
      this.txtresultado.Click += new System.EventHandler(this.txtresultado_Click);
      // 
      // resultado
      // 
      this.resultado.AutoSize = true;
      this.resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.resultado.Location = new System.Drawing.Point(590, 179);
      this.resultado.Name = "resultado";
      this.resultado.Size = new System.Drawing.Size(10, 13);
      this.resultado.TabIndex = 18;
      this.resultado.Text = "-";
      // 
      // txtkilo
      // 
      this.txtkilo.Location = new System.Drawing.Point(336, 107);
      this.txtkilo.Name = "txtkilo";
      this.txtkilo.Size = new System.Drawing.Size(120, 20);
      this.txtkilo.TabIndex = 19;
      this.txtkilo.ValueChanged += new System.EventHandler(this.txtprecio_ValueChanged);
      // 
      // txtcantidad
      // 
      this.txtcantidad.Location = new System.Drawing.Point(12, 106);
      this.txtcantidad.Name = "txtcantidad";
      this.txtcantidad.Size = new System.Drawing.Size(102, 20);
      this.txtcantidad.TabIndex = 20;
      this.txtcantidad.ValueChanged += new System.EventHandler(this.txtcantidad_ValueChanged);
      // 
      // botonResultado
      // 
      this.botonResultado.Location = new System.Drawing.Point(709, 171);
      this.botonResultado.Name = "botonResultado";
      this.botonResultado.Size = new System.Drawing.Size(79, 32);
      this.botonResultado.TabIndex = 21;
      this.botonResultado.Text = "Calcular";
      this.botonResultado.UseVisualStyleBackColor = true;
      this.botonResultado.Click += new System.EventHandler(this.botonResultado_Click);
      // 
      // desplegableClientes
      // 
      this.desplegableClientes.FormattingEnabled = true;
      this.desplegableClientes.Items.AddRange(new object[] {
            "pepe",
            "pablo",
            "fulano"});
      this.desplegableClientes.Location = new System.Drawing.Point(12, 25);
      this.desplegableClientes.Name = "desplegableClientes";
      this.desplegableClientes.Size = new System.Drawing.Size(331, 21);
      this.desplegableClientes.TabIndex = 22;
      this.desplegableClientes.SelectedValueChanged += new System.EventHandler(this.desplegableClientes_SelectedValueChanged);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(349, 25);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(107, 21);
      this.button2.TabIndex = 23;
      this.button2.Text = "Cliente nuevo";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.irAClienteNuevo);
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.Location = new System.Drawing.Point(670, 25);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(121, 21);
      this.button3.TabIndex = 24;
      this.button3.Text = "Definir precios";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // bindingSource1
      // 
      this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.Location = new System.Drawing.Point(12, 171);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(423, 32);
      this.button4.TabIndex = 26;
      this.button4.Text = "Guardar operación";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.crearCompra);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column4,
            this.Column6});
      this.dataGridView1.Location = new System.Drawing.Point(12, 242);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(779, 227);
      this.dataGridView1.TabIndex = 27;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // Column3
      // 
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
      this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
      this.Column3.HeaderText = "Cantidad";
      this.Column3.MinimumWidth = 9;
      this.Column3.Name = "Column3";
      this.Column3.Width = 130;
      // 
      // Column1
      // 
      this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
      this.Column1.DividerWidth = 1;
      this.Column1.HeaderText = "Detalle";
      this.Column1.MinimumWidth = 9;
      this.Column1.Name = "Column1";
      this.Column1.Width = 125;
      // 
      // Column2
      // 
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F);
      this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
      this.Column2.HeaderText = "Kilo";
      this.Column2.MinimumWidth = 9;
      this.Column2.Name = "Column2";
      this.Column2.Width = 125;
      // 
      // Column7
      // 
      this.Column7.HeaderText = "Precio kg";
      this.Column7.Name = "Column7";
      this.Column7.Width = 105;
      // 
      // Column4
      // 
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F);
      this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
      this.Column4.HeaderText = "Total $";
      this.Column4.MinimumWidth = 9;
      this.Column4.Name = "Column4";
      this.Column4.Width = 125;
      // 
      // Column6
      // 
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 8.25F);
      this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
      this.Column6.HeaderText = "Fecha";
      this.Column6.MinimumWidth = 9;
      this.Column6.Name = "Column6";
      this.Column6.Width = 125;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.panel1.Controls.Add(this.txtresultado);
      this.panel1.Location = new System.Drawing.Point(523, 171);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(180, 32);
      this.panel1.TabIndex = 28;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(585, 91);
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
      this.label4.Location = new System.Drawing.Point(459, 91);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 13);
      this.label4.TabIndex = 32;
      this.label4.Text = "Precio / kg";
      // 
      // preciokg
      // 
      this.preciokg.Location = new System.Drawing.Point(462, 107);
      this.preciokg.Name = "preciokg";
      this.preciokg.Size = new System.Drawing.Size(120, 20);
      this.preciokg.TabIndex = 33;
      this.preciokg.ValueChanged += new System.EventHandler(this.preciokg_ValueChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 226);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(102, 13);
      this.label5.TabIndex = 34;
      this.label5.Text = "Compras del cliente:";
      // 
      // labelClienteSeleccionado
      // 
      this.labelClienteSeleccionado.AutoSize = true;
      this.labelClienteSeleccionado.Location = new System.Drawing.Point(117, 226);
      this.labelClienteSeleccionado.Name = "labelClienteSeleccionado";
      this.labelClienteSeleccionado.Size = new System.Drawing.Size(10, 13);
      this.labelClienteSeleccionado.TabIndex = 35;
      this.labelClienteSeleccionado.Text = "-";
      // 
      // selectorFecha
      // 
      this.selectorFecha.Location = new System.Drawing.Point(588, 107);
      this.selectorFecha.Name = "selectorFecha";
      this.selectorFecha.Size = new System.Drawing.Size(200, 20);
      this.selectorFecha.TabIndex = 36;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(462, 24);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(101, 22);
      this.button1.TabIndex = 37;
      this.button1.Text = "Pagos y deudas";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // FormCompra
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.ClientSize = new System.Drawing.Size(803, 481);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.selectorFecha);
      this.Controls.Add(this.labelClienteSeleccionado);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.preciokg);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.desplegableClientes);
      this.Controls.Add(this.botonResultado);
      this.Controls.Add(this.txtcantidad);
      this.Controls.Add(this.txtkilo);
      this.Controls.Add(this.resultado);
      this.Controls.Add(this.cantidad);
      this.Controls.Add(this.precio);
      this.Controls.Add(this.detallecartel);
      this.Controls.Add(this.detalle);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.panel1);
      this.Name = "FormCompra";
      this.Text = "ventas";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.txtkilo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.preciokg)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox detalle;
        private System.Windows.Forms.Label detallecartel;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.Label txtresultado;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.NumericUpDown txtkilo;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Button botonResultado;
        private System.Windows.Forms.ComboBox desplegableClientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown preciokg;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label labelClienteSeleccionado;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    private System.Windows.Forms.DateTimePicker selectorFecha;
    private System.Windows.Forms.Button button1;
  }
}

