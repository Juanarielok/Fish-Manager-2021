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
  public partial class FormPrecios : Form
  {
    
    public FormPrecios()
    {
      InitializeComponent();

      dataGridViewPescados.AutoGenerateColumns = true;
      dataGridViewPescados.DataSource = DAOPescados.dameDAO().pescados;
    }

    private void guardarClick(object sender, EventArgs e)
    {
      Pescado pescado;

      if (textBoxNombre.Text.Length > 0)
      {
        pescado = new Pescado(textBoxNombre.Text, numericUpDownPrecio.Value);

        DAOPescados.dameDAO().addPescado(pescado);
      } else
      {
        MessageBox.Show(MensajesError.NombrePescado, MensajesError.Titulo, MessageBoxButtons.OK);
      }
    }

    private void buttonSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void dataGridViewPescados_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      DAOPescados.dameDAO().guardarDatos();
    }
  }
}
