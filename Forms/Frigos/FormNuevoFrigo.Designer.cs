namespace facturilla
{
  partial class FormNuevoFrigo
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
      this.textBoxNombre = new System.Windows.Forms.TextBox();
      this.buttonGuardar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nombre";
      // 
      // textBoxNombre
      // 
      this.textBoxNombre.Location = new System.Drawing.Point(63, 10);
      this.textBoxNombre.Name = "textBoxNombre";
      this.textBoxNombre.Size = new System.Drawing.Size(136, 20);
      this.textBoxNombre.TabIndex = 1;
      // 
      // buttonGuardar
      // 
      this.buttonGuardar.Location = new System.Drawing.Point(16, 36);
      this.buttonGuardar.Name = "buttonGuardar";
      this.buttonGuardar.Size = new System.Drawing.Size(183, 23);
      this.buttonGuardar.TabIndex = 2;
      this.buttonGuardar.Text = "Guardar";
      this.buttonGuardar.UseVisualStyleBackColor = true;
      this.buttonGuardar.Click += new System.EventHandler(this.crearFrigo);
      // 
      // FormNuevoFrigo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(211, 71);
      this.Controls.Add(this.buttonGuardar);
      this.Controls.Add(this.textBoxNombre);
      this.Controls.Add(this.label1);
      this.Name = "FormNuevoFrigo";
      this.Text = "FormNuevoFrigo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxNombre;
    private System.Windows.Forms.Button buttonGuardar;
  }
}