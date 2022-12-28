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
  public partial class FormStock : Form
  {
    BindingList<Frigorifico> _frigos;
    BindingList<Pescado> _pescados;

    public FormStock()
    {
      InitializeComponent();

      _frigos = DAOFrigos.dameDAO().frigos;
      _pescados = DAOPescados.dameDAO().pescados;

      dataGridView1.AutoGenerateColumns = true;
      dataGridView2.AutoGenerateColumns = true;

      initDesplegableFrigos();
      initDesplegablePescados();
    }

    private void initDesplegableFrigos()
    {
      comboBoxFrigos.DataSource = _frigos;

      if (_frigos.Count > 0)
      {
        comboBoxFrigos.SelectedIndex = 0;
      }
    }

    private void initDesplegablePescados()
    {
      desplegablePescados.DataSource = _pescados;

      if (_pescados.Count > 0)
      {
        desplegablePescados.SelectedIndex = 0;
      }
    }

    private void comboBoxFrigos_SelectedIndexChanged(object sender, EventArgs e)
    {
      Frigorifico frigoSeleccionado = comboBoxFrigos.SelectedItem as Frigorifico;

      dataGridView1.DataSource = frigoSeleccionado.compras;
      dataGridView2.DataSource = frigoSeleccionado.stocks;
    }

    private void buttonGuardar_Click(object sender, EventArgs e)
    {
      Frigorifico frigo = comboBoxFrigos.SelectedItem as Frigorifico;
      Pescado detalle = desplegablePescados.SelectedItem as Pescado;
      Compra nuevaCompra;

      if (esFormularioValido())
      {
        nuevaCompra = new Compra(
                numericUpDownCantidad.Value,
                detalle,
                numericUpDownKilo.Value,
                numericUpDownPrecio.Value,
                selectorFecha.Value);

        frigo.compras.Insert(0, nuevaCompra);
        frigo.addStock(detalle, numericUpDownKilo.Value, numericUpDownCantidad.Value);
      }
      else
      {
        MessageBox.Show(MensajesError.ErrorStock, MensajesError.Titulo, MessageBoxButtons.OK);
      }
    }

    private Boolean esFormularioValido()
    {
      return (_frigos.Count > 0
          && _pescados.Count > 0
          && comboBoxFrigos.SelectedItem != null
          && desplegablePescados.SelectedItem != null
          && numericUpDownPrecio.Value > 0
          && numericUpDownKilo.Value > 0);
    }

    private void buttonAddFrigo_Click(object sender, EventArgs e)
    {
      FormNuevoFrigo formNuevoFrigo = new FormNuevoFrigo();

      formNuevoFrigo.ShowDialog();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      DAOFrigos.dameDAO().guardarDatos();
    }

    private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      DAOFrigos.dameDAO().guardarDatos();
    }
  }
}
