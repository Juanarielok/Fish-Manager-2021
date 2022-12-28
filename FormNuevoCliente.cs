using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturilla
{
  public partial class FormNuevoCliente : Form
  {
    FormCompra formCompra;

    public FormNuevoCliente()
    {
      InitializeComponent();
    }

    public FormNuevoCliente(FormCompra formCompra)
    {
      InitializeComponent();

      this.formCompra = formCompra;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void crearCliente(object sender, EventArgs e)
    {
      if (textBoxNombre.Text.Length > 0)
      {
        Cliente cliente = new Cliente(
        textBoxNombre.Text,
        textBoxDNI.Text,
        new List<Compra>());

        formCompra.crearCliente(cliente);

        this.Close();
      }
    }
  }
}
