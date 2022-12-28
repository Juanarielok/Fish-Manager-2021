namespace facturilla
{
  partial class FormPagosDeudas
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
      this.label1 = new System.Windows.Forms.Label();
      this.desplegableClientesPagos = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cantidadPago = new System.Windows.Forms.NumericUpDown();
      this.dataGridViewDeudas = new System.Windows.Forms.DataGridView();
      this.button1 = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.dataGridViewPagos = new System.Windows.Forms.DataGridView();
      this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.checkBoxEfectivo = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.labelDeudaTotal = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.labelChequesSinCobrar = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.cantidadPago)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeudas)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Clientes:";
      // 
      // desplegableClientesPagos
      // 
      this.desplegableClientesPagos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.desplegableClientesPagos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.desplegableClientesPagos.FormattingEnabled = true;
      this.desplegableClientesPagos.Location = new System.Drawing.Point(85, 12);
      this.desplegableClientesPagos.MaxDropDownItems = 100;
      this.desplegableClientesPagos.Name = "desplegableClientesPagos";
      this.desplegableClientesPagos.Size = new System.Drawing.Size(519, 21);
      this.desplegableClientesPagos.TabIndex = 23;
      this.desplegableClientesPagos.SelectedIndexChanged += new System.EventHandler(this.desplegableClientesPagos_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 13);
      this.label2.TabIndex = 24;
      this.label2.Text = "Añadir pago:";
      // 
      // cantidadPago
      // 
      this.cantidadPago.DecimalPlaces = 2;
      this.cantidadPago.Location = new System.Drawing.Point(85, 46);
      this.cantidadPago.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.cantidadPago.Name = "cantidadPago";
      this.cantidadPago.Size = new System.Drawing.Size(120, 20);
      this.cantidadPago.TabIndex = 25;
      // 
      // dataGridViewDeudas
      // 
      this.dataGridViewDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDeudas.Location = new System.Drawing.Point(6, 6);
      this.dataGridViewDeudas.Name = "dataGridViewDeudas";
      this.dataGridViewDeudas.Size = new System.Drawing.Size(588, 256);
      this.dataGridViewDeudas.TabIndex = 26;
      this.dataGridViewDeudas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeudas_CellContentClick);
      this.dataGridViewDeudas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeudas_CellValueChanged);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(516, 46);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(88, 20);
      this.button1.TabIndex = 27;
      this.button1.Text = "Añadir pago";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.crearPago);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 98);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(605, 294);
      this.tabControl1.TabIndex = 31;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGridViewDeudas);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(597, 268);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Deudas";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.dataGridViewPagos);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(597, 268);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Pagos";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // dataGridViewPagos
      // 
      this.dataGridViewPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewPagos.Location = new System.Drawing.Point(6, 6);
      this.dataGridViewPagos.Name = "dataGridViewPagos";
      this.dataGridViewPagos.Size = new System.Drawing.Size(588, 256);
      this.dataGridViewPagos.TabIndex = 0;
      this.dataGridViewPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPagos_CellContentClick);
      this.dataGridViewPagos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPagos_CellValueChanged);
      // 
      // dateTimePicker
      // 
      this.dateTimePicker.Location = new System.Drawing.Point(212, 46);
      this.dateTimePicker.Name = "dateTimePicker";
      this.dateTimePicker.Size = new System.Drawing.Size(212, 20);
      this.dateTimePicker.TabIndex = 32;
      // 
      // checkBoxEfectivo
      // 
      this.checkBoxEfectivo.AutoSize = true;
      this.checkBoxEfectivo.Location = new System.Drawing.Point(430, 48);
      this.checkBoxEfectivo.Name = "checkBoxEfectivo";
      this.checkBoxEfectivo.Size = new System.Drawing.Size(80, 17);
      this.checkBoxEfectivo.TabIndex = 33;
      this.checkBoxEfectivo.Text = "En efectivo";
      this.checkBoxEfectivo.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(594, 81);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(13, 13);
      this.label5.TabIndex = 36;
      this.label5.Text = "$";
      // 
      // labelDeudaTotal
      // 
      this.labelDeudaTotal.AutoSize = true;
      this.labelDeudaTotal.Location = new System.Drawing.Point(516, 82);
      this.labelDeudaTotal.Name = "labelDeudaTotal";
      this.labelDeudaTotal.Size = new System.Drawing.Size(10, 13);
      this.labelDeudaTotal.TabIndex = 34;
      this.labelDeudaTotal.Text = "-";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(430, 82);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(80, 13);
      this.label4.TabIndex = 35;
      this.label4.Text = "El cliente debe:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(161, 82);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(173, 13);
      this.label3.TabIndex = 37;
      this.label3.Text = "Cheques sin cobrar de este cliente:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(391, 82);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(13, 13);
      this.label6.TabIndex = 38;
      this.label6.Text = "$";
      // 
      // labelChequesSinCobrar
      // 
      this.labelChequesSinCobrar.AutoSize = true;
      this.labelChequesSinCobrar.Location = new System.Drawing.Point(340, 82);
      this.labelChequesSinCobrar.Name = "labelChequesSinCobrar";
      this.labelChequesSinCobrar.Size = new System.Drawing.Size(10, 13);
      this.labelChequesSinCobrar.TabIndex = 39;
      this.labelChequesSinCobrar.Text = "-";
      // 
      // FormPagosDeudas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(629, 404);
      this.Controls.Add(this.labelChequesSinCobrar);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.labelDeudaTotal);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.checkBoxEfectivo);
      this.Controls.Add(this.dateTimePicker);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.cantidadPago);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.desplegableClientesPagos);
      this.Controls.Add(this.label1);
      this.Name = "FormPagosDeudas";
      this.Text = "PagosDeudas";
      ((System.ComponentModel.ISupportInitialize)(this.cantidadPago)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeudas)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox desplegableClientesPagos;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown cantidadPago;
    private System.Windows.Forms.DataGridView dataGridViewDeudas;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView dataGridViewPagos;
    private System.Windows.Forms.DateTimePicker dateTimePicker;
    private System.Windows.Forms.CheckBox checkBoxEfectivo;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label labelDeudaTotal;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label labelChequesSinCobrar;
  }
}