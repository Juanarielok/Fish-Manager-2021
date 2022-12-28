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
  public partial class FormNuevoFrigo : Form
  {
    public FormNuevoFrigo()
    {
      InitializeComponent();
    }

    private void crearFrigo(object sender, EventArgs e)
    {
      if (textBoxNombre.Text.Length > 0)
      {
        Frigorifico frigo = new Frigorifico(textBoxNombre.Text);

        DAOFrigos.dameDAO().addFrigo(frigo);
        this.Close();
      }
      else
      {
        MessageBox.Show(MensajesError.NombreFrigo, MensajesError.Titulo, MessageBoxButtons.OK);
      }
    }
  }
}
