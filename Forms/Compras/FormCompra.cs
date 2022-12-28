using facturilla.DAO;
using facturilla.ModeloDeDatos;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace facturilla
{
  public partial class FormCompra : Form
  {
    internal BindingList<Pescado> pescados;
    internal BindingList<Cliente> clientes;
    internal BindingList<Frigorifico> frigos;

    public FormCompra()
    {
      InitializeComponent();

      pescados = DAOPescados.dameDAO().pescados;
      clientes = DAOClientes.dameDAO().clientes;
      frigos = DAOFrigos.dameDAO().frigos;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      dataGridView1.AutoGenerateColumns = true;

      desplegablePescados.DataSource = pescados;
      desplegableClientes.DataSource = clientes;
      desplegableFrigos.DataSource = frigos;
    }

    private void crearCompra(object sender, EventArgs e)
    {
      Cliente cliente;
      Compra nuevaCompra;
      Frigorifico frigo = desplegableFrigos.SelectedItem as Frigorifico;
      Pescado detalle = (Pescado)desplegablePescados.SelectedItem;

      if (esFormularioValido())
      {
        cliente = (Cliente)desplegableClientes.SelectedItem;
        nuevaCompra = new Compra(
                txtcantidad.Value,
                detalle,
                txtkilo.Value,
                selectorFecha.Value);

        cliente.compras.Insert(0, nuevaCompra);

        if (!checkBoxPagado.Checked)
        {
          crearDeuda(getTotalCompra(), selectorFecha.Value);
        }

        if (frigo != null)
        {
          frigo.quitarStock(detalle, txtkilo.Value, txtcantidad.Value);
          DAOFrigos.dameDAO().guardarDatos();
        }
      }
      else
      {
        MessageBox.Show(MensajesError.ErrorCompra, MensajesError.Titulo, MessageBoxButtons.OK);
      }
    }

    private Boolean esFormularioValido()
    {
      return (clientes.Count > 0
          && pescados.Count > 0
          && desplegableClientes.SelectedItem != null
          && desplegablePescados.SelectedItem != null
          && txtkilo.Value > 0);
    }

    private void crearDeuda(decimal cantidad, DateTime fecha)
    {
      Cliente cliente = (Cliente)desplegableClientes.SelectedItem;

      cliente.deudas.Insert(0, new Deuda(cantidad, fecha));
    }

    private void cargarTablaDeClienteSeleccionado(object sender, EventArgs e)
    {
      Cliente cliente;

      if (clientes.Count > 0
          && desplegableClientes.SelectedItem != null)
      {
        cliente = (Cliente)desplegableClientes.SelectedItem;

        dataGridView1.DataSource = cliente.compras;
        labelClienteSeleccionado.Text = cliente.nombre;
      }
    }

    private decimal getTotalCompra()
    {
      Pescado pescadoSeleccionado;
      decimal total = 0;

      if (pescados.Count > 0 && desplegablePescados.SelectedItem != null)
      {
        pescadoSeleccionado = (Pescado)desplegablePescados.SelectedItem;

        total = pescadoSeleccionado.precio * txtkilo.Value;
      }

      return total;
    }

    private void desplegablePescados_SelectedIndexChanged(object sender, EventArgs e)
    {
      actualizarPrecioKgLabel();
      actualizarTotal();
    }

    private void txtkilo_ValueChanged(object sender, EventArgs e)
    {
      actualizarTotal();
    }

    private void actualizarTotal()
    {
      labelTotalCompra.Text = getTotalCompra().ToString();
    }

    private void irAClienteNuevo(object sender, EventArgs e)
    {
      (new FormNuevoCliente()).ShowDialog();
    }

    private void irADefinirPrecios(object sender, EventArgs e)
    {
      FormPrecios formularioPrecios = new FormPrecios();
      formularioPrecios.FormClosed += actualizarPrecioKgLabel;

      formularioPrecios.ShowDialog();
    }

    internal void actualizarPrecioKgLabel(object sender, FormClosedEventArgs e)
    {
      actualizarPrecioKgLabel();
    }

    internal void actualizarPrecioKgLabel()
    {
      if (desplegablePescados.SelectedItem != null)
      {
        labelPreciokg.Text = ((Pescado)desplegablePescados.SelectedItem).precio.ToString();
      }
    }

    private void irAPagos(object sender, EventArgs e)
    {
      FormPagosDeudas formPagos = new FormPagosDeudas(
        desplegableClientes.SelectedItem as Cliente);

      formPagos.FormClosed += DAOClientes.dameDAO().guardarDatos;

      formPagos.ShowDialog();
    }

    private void irAStock(object sender, EventArgs e)
    {
      (new FormStock()).ShowDialog();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      DAOClientes.dameDAO().guardarDatos();
    }
  }
}
