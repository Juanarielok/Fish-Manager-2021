using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace facturilla
{
  public partial class FormCompra : Form
  {
    List<Cliente> clientes = new List<Cliente>();
    Cliente clienteSeleccionado;

    public FormCompra()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Cliente pepe = new Cliente("pepe", "", new List<Compra>());
      Cliente pablo = new Cliente("pablo", "", new List<Compra>());

      clientes.Add(pepe);
      clientes.Add(pablo);

      cargarClientes();
      seleccionarCliente(pepe);

      desplegableClientes.SelectedIndex = 0;
    }

    private void crearCompra(object sender, EventArgs e)
    {
      Compra nuevaCompra = new Compra(
        txtcantidad.Value,
        detalle.Text,
        txtkilo.Value,
        preciokg.Value,
        selectorFecha.Value);

      if (clienteSeleccionado != null)
      {
        clienteSeleccionado.addCompra(nuevaCompra);

        dataGridView1.Rows.Add(nuevaCompra.compraEnString());
      }
    }

    private void seleccionarClientePorNombre(string nombre)
    {
      foreach (var cliente in clientes)
      {
        if (cliente.nombre == nombre)
        {
          seleccionarCliente(cliente);
        }
      }
    }

    private void seleccionarCliente(Cliente cliente)
    {
      clienteSeleccionado = cliente;
      cargarTablaDeClienteSeleccionado();

      labelClienteSeleccionado.Text = cliente.nombre;
    }

    private void cargarTablaDeClienteSeleccionado()
    {
      if (clienteSeleccionado != null)
      {
        dataGridView1.Rows.Clear();
        clienteSeleccionado.pasarComprasATabla(dataGridView1.Rows);
      }
    }

    private void cargarClientes()
    {
      desplegableClientes.Items.Clear();

      foreach (var cliente in clientes)
      {
        desplegableClientes.Items.Add(cliente.nombre);
      }
    }

    private void botonResultado_Click(object sender, EventArgs e)
    {
      resultado.Text = (preciokg.Value * txtkilo.Value).ToString();
    }

    private void desplegableClientes_SelectedValueChanged(object sender, EventArgs e)
    {
      seleccionarClientePorNombre(desplegableClientes.Text);
    }

    public void crearCliente(Cliente cliente)
    {
      clientes.Add(cliente);

      desplegableClientes.Items.Add(cliente.nombre);

      desplegableClientes.SelectedIndex = desplegableClientes.Items.Count - 1;
    }

    private void irAClienteNuevo(object sender, EventArgs e)
    {
      FormNuevoCliente formNuevoCliente = new FormNuevoCliente(this);

      formNuevoCliente.ShowDialog();
    }

    private void detalle_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void preciokg_ValueChanged(object sender, EventArgs e)
    {

    }
    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
    private void txtresultado_Click(object sender, EventArgs e)
    {

    }
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
    private void bindingSource1_CurrentChanged(object sender, EventArgs e)
    {

    }
    private void txtprecio_ValueChanged(object sender, EventArgs e)
    {

    }
    private void precio_Click(object sender, EventArgs e)
    {

    }
    private void txtcantidad_ValueChanged(object sender, EventArgs e)
    {

    }
    private void cantidad_Click(object sender, EventArgs e)
    {

    }

  }
}
