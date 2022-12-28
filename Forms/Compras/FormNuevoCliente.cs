using facturilla.DAO;
using facturilla.ModeloDeDatos;
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
    public FormNuevoCliente()
    {
      InitializeComponent();
    }

    private void crearCliente(object sender, EventArgs e)
    {
      if (textBoxNombre.Text.Length > 0)
      {
        Cliente cliente = new Cliente(textBoxNombre.Text);

        DAOClientes.dameDAO().addCliente(cliente);
        
        this.Close();
      } else
      {
        MessageBox.Show(MensajesError.NombreCliente, MensajesError.Titulo, MessageBoxButtons.OK);
      }
    }
  }
}
