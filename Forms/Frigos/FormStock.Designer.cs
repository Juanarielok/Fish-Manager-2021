namespace facturilla
{
  partial class FormStock
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
      this.labelfrigos = new System.Windows.Forms.Label();
      this.comboBoxFrigos = new System.Windows.Forms.ComboBox();
      this.buttonAddFrigo = new System.Windows.Forms.Button();
      this.selectorFecha = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownKilo = new System.Windows.Forms.NumericUpDown();
      this.cantidad = new System.Windows.Forms.Label();
      this.precio = new System.Windows.Forms.Label();
      this.detallecartel = new System.Windows.Forms.Label();
      this.desplegablePescados = new System.Windows.Forms.ComboBox();
      this.numericUpDownPrecio = new System.Windows.Forms.NumericUpDown();
      this.buttonGuardar = new System.Windows.Forms.Button();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKilo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).BeginInit();
      this.tabControl.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      this.SuspendLayout();
      // 
      // labelfrigos
      // 
      this.labelfrigos.AutoSize = true;
      this.labelfrigos.Location = new System.Drawing.Point(13, 13);
      this.labelfrigos.Name = "labelfrigos";
      this.labelfrigos.Size = new System.Drawing.Size(59, 13);
      this.labelfrigos.TabIndex = 0;
      this.labelfrigos.Text = "Frigoríficos";
      // 
      // comboBoxFrigos
      // 
      this.comboBoxFrigos.FormattingEnabled = true;
      this.comboBoxFrigos.Location = new System.Drawing.Point(78, 10);
      this.comboBoxFrigos.Name = "comboBoxFrigos";
      this.comboBoxFrigos.Size = new System.Drawing.Size(186, 21);
      this.comboBoxFrigos.TabIndex = 1;
      this.comboBoxFrigos.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrigos_SelectedIndexChanged);
      // 
      // buttonAddFrigo
      // 
      this.buttonAddFrigo.Location = new System.Drawing.Point(270, 10);
      this.buttonAddFrigo.Name = "buttonAddFrigo";
      this.buttonAddFrigo.Size = new System.Drawing.Size(95, 21);
      this.buttonAddFrigo.TabIndex = 2;
      this.buttonAddFrigo.Text = "Nuevo frigorífico";
      this.buttonAddFrigo.UseVisualStyleBackColor = true;
      this.buttonAddFrigo.Click += new System.EventHandler(this.buttonAddFrigo_Click);
      // 
      // selectorFecha
      // 
      this.selectorFecha.Location = new System.Drawing.Point(437, 19);
      this.selectorFecha.Name = "selectorFecha";
      this.selectorFecha.Size = new System.Drawing.Size(138, 20);
      this.selectorFecha.TabIndex = 54;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(344, 4);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 13);
      this.label4.TabIndex = 53;
      this.label4.Text = "Precio / kg";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(434, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 13);
      this.label1.TabIndex = 52;
      this.label1.Text = "Fecha";
      // 
      // numericUpDownCantidad
      // 
      this.numericUpDownCantidad.Location = new System.Drawing.Point(6, 19);
      this.numericUpDownCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numericUpDownCantidad.Name = "numericUpDownCantidad";
      this.numericUpDownCantidad.Size = new System.Drawing.Size(78, 20);
      this.numericUpDownCantidad.TabIndex = 50;
      // 
      // numericUpDownKilo
      // 
      this.numericUpDownKilo.DecimalPlaces = 3;
      this.numericUpDownKilo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.numericUpDownKilo.Location = new System.Drawing.Point(239, 19);
      this.numericUpDownKilo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numericUpDownKilo.Name = "numericUpDownKilo";
      this.numericUpDownKilo.Size = new System.Drawing.Size(102, 20);
      this.numericUpDownKilo.TabIndex = 49;
      // 
      // cantidad
      // 
      this.cantidad.AutoSize = true;
      this.cantidad.Location = new System.Drawing.Point(6, 3);
      this.cantidad.Name = "cantidad";
      this.cantidad.Size = new System.Drawing.Size(49, 13);
      this.cantidad.TabIndex = 48;
      this.cantidad.Text = "Cantidad";
      // 
      // precio
      // 
      this.precio.AutoSize = true;
      this.precio.Location = new System.Drawing.Point(236, 3);
      this.precio.Name = "precio";
      this.precio.Size = new System.Drawing.Size(52, 13);
      this.precio.TabIndex = 47;
      this.precio.Text = "Peso (kg)";
      // 
      // detallecartel
      // 
      this.detallecartel.AutoSize = true;
      this.detallecartel.Location = new System.Drawing.Point(87, 3);
      this.detallecartel.Name = "detallecartel";
      this.detallecartel.Size = new System.Drawing.Size(50, 13);
      this.detallecartel.TabIndex = 46;
      this.detallecartel.Text = "Producto";
      // 
      // desplegablePescados
      // 
      this.desplegablePescados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.desplegablePescados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.desplegablePescados.FormattingEnabled = true;
      this.desplegablePescados.Location = new System.Drawing.Point(90, 19);
      this.desplegablePescados.MaxDropDownItems = 100;
      this.desplegablePescados.Name = "desplegablePescados";
      this.desplegablePescados.Size = new System.Drawing.Size(143, 21);
      this.desplegablePescados.TabIndex = 45;
      // 
      // numericUpDownPrecio
      // 
      this.numericUpDownPrecio.DecimalPlaces = 2;
      this.numericUpDownPrecio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.numericUpDownPrecio.Location = new System.Drawing.Point(347, 19);
      this.numericUpDownPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.numericUpDownPrecio.Name = "numericUpDownPrecio";
      this.numericUpDownPrecio.Size = new System.Drawing.Size(84, 20);
      this.numericUpDownPrecio.TabIndex = 55;
      // 
      // buttonGuardar
      // 
      this.buttonGuardar.Location = new System.Drawing.Point(581, 19);
      this.buttonGuardar.Name = "buttonGuardar";
      this.buttonGuardar.Size = new System.Drawing.Size(109, 21);
      this.buttonGuardar.TabIndex = 56;
      this.buttonGuardar.Text = "Guardar Operación";
      this.buttonGuardar.UseVisualStyleBackColor = true;
      this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.tabPage2);
      this.tabControl.Controls.Add(this.tabPage1);
      this.tabControl.Location = new System.Drawing.Point(12, 49);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(704, 326);
      this.tabControl.TabIndex = 57;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGridView1);
      this.tabPage1.Controls.Add(this.cantidad);
      this.tabPage1.Controls.Add(this.buttonGuardar);
      this.tabPage1.Controls.Add(this.desplegablePescados);
      this.tabPage1.Controls.Add(this.numericUpDownPrecio);
      this.tabPage1.Controls.Add(this.detallecartel);
      this.tabPage1.Controls.Add(this.selectorFecha);
      this.tabPage1.Controls.Add(this.precio);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.numericUpDownKilo);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.numericUpDownCantidad);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(696, 300);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Compras de Stock";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(7, 46);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(683, 248);
      this.dataGridView1.TabIndex = 57;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.dataGridView2);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(696, 300);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Stock total";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // dataGridView2
      // 
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new System.Drawing.Point(7, 7);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.Size = new System.Drawing.Size(683, 287);
      this.dataGridView2.TabIndex = 0;
      this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
      // 
      // FormStock
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(728, 387);
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.buttonAddFrigo);
      this.Controls.Add(this.comboBoxFrigos);
      this.Controls.Add(this.labelfrigos);
      this.Name = "FormStock";
      this.Text = "FormStock";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKilo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).EndInit();
      this.tabControl.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelfrigos;
    private System.Windows.Forms.ComboBox comboBoxFrigos;
    private System.Windows.Forms.Button buttonAddFrigo;
    private System.Windows.Forms.DateTimePicker selectorFecha;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
    private System.Windows.Forms.NumericUpDown numericUpDownKilo;
    private System.Windows.Forms.Label cantidad;
    private System.Windows.Forms.Label precio;
    private System.Windows.Forms.Label detallecartel;
    private System.Windows.Forms.ComboBox desplegablePescados;
    private System.Windows.Forms.NumericUpDown numericUpDownPrecio;
    private System.Windows.Forms.Button buttonGuardar;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridView dataGridView2;
  }
}