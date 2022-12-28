namespace facturilla
{
  partial class FormPrecios
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
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxNombre = new System.Windows.Forms.TextBox();
      this.dataGridViewPescados = new System.Windows.Forms.DataGridView();
      this.numericUpDownPrecio = new System.Windows.Forms.NumericUpDown();
      this.buttonGuardar = new System.Windows.Forms.Button();
      this.buttonSalir = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPescados)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(106, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nombre del producto";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(82, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Precio";
      // 
      // textBoxNombre
      // 
      this.textBoxNombre.Location = new System.Drawing.Point(125, 10);
      this.textBoxNombre.Name = "textBoxNombre";
      this.textBoxNombre.Size = new System.Drawing.Size(183, 20);
      this.textBoxNombre.TabIndex = 2;
      // 
      // dataGridViewPescados
      // 
      this.dataGridViewPescados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewPescados.Location = new System.Drawing.Point(11, 103);
      this.dataGridViewPescados.Name = "dataGridViewPescados";
      this.dataGridViewPescados.Size = new System.Drawing.Size(296, 188);
      this.dataGridViewPescados.TabIndex = 4;
      this.dataGridViewPescados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPescados_CellContentClick);
      // 
      // numericUpDownPrecio
      // 
      this.numericUpDownPrecio.DecimalPlaces = 2;
      this.numericUpDownPrecio.Location = new System.Drawing.Point(125, 36);
      this.numericUpDownPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownPrecio.Name = "numericUpDownPrecio";
      this.numericUpDownPrecio.Size = new System.Drawing.Size(183, 20);
      this.numericUpDownPrecio.TabIndex = 5;
      // 
      // buttonGuardar
      // 
      this.buttonGuardar.Location = new System.Drawing.Point(216, 62);
      this.buttonGuardar.Name = "buttonGuardar";
      this.buttonGuardar.Size = new System.Drawing.Size(91, 23);
      this.buttonGuardar.TabIndex = 6;
      this.buttonGuardar.Text = "Guardar";
      this.buttonGuardar.UseVisualStyleBackColor = true;
      this.buttonGuardar.Click += new System.EventHandler(this.guardarClick);
      // 
      // buttonSalir
      // 
      this.buttonSalir.Location = new System.Drawing.Point(232, 297);
      this.buttonSalir.Name = "buttonSalir";
      this.buttonSalir.Size = new System.Drawing.Size(75, 23);
      this.buttonSalir.TabIndex = 7;
      this.buttonSalir.Text = "Salir";
      this.buttonSalir.UseVisualStyleBackColor = true;
      this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
      // 
      // FormPrecios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(319, 332);
      this.Controls.Add(this.buttonSalir);
      this.Controls.Add(this.buttonGuardar);
      this.Controls.Add(this.numericUpDownPrecio);
      this.Controls.Add(this.dataGridViewPescados);
      this.Controls.Add(this.textBoxNombre);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "FormPrecios";
      this.Text = "FormPrecios";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPescados)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxNombre;
    private System.Windows.Forms.DataGridView dataGridViewPescados;
    private System.Windows.Forms.NumericUpDown numericUpDownPrecio;
    private System.Windows.Forms.Button buttonGuardar;
    private System.Windows.Forms.Button buttonSalir;
  }
}