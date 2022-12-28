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
  public partial class FormPagosDeudas : Form
  {
    public FormPagosDeudas()
    {
      InitializeComponent();
    }

    internal FormPagosDeudas(Cliente cliente)
    {
      InitializeComponent();

      dataGridViewDeudas.AutoGenerateColumns = true;
      dataGridViewPagos.AutoGenerateColumns = true;
      desplegableClientesPagos.DataSource = DAOClientes.dameDAO().clientes;
      desplegableClientesPagos.SelectedItem = cliente;
    }

    private void desplegableClientesPagos_SelectedIndexChanged(object sender, EventArgs e)
    {
      Cliente clienteSeleccionado = desplegableClientesPagos.SelectedItem as Cliente;

      dataGridViewDeudas.DataSource = clienteSeleccionado.deudas;
      dataGridViewPagos.DataSource = clienteSeleccionado.pagos;

      actualizarDeuda();
      actualizarChequesSinCobrar();
    }

    private void crearPago(object sender, EventArgs e)
    {
      Cliente cliente = desplegableClientesPagos.SelectedItem as Cliente;

      if (cantidadPago.Value > 0) 
      {
        if (!checkBoxEfectivo.Checked)
        {
          cliente.pagos.Insert(0, new PagoCheque(cantidadPago.Value, dateTimePicker.Value));
          actualizarChequesSinCobrar();
        }
        else
        {
          cliente.pagos.Insert(0, new PagoEfectivo(cantidadPago.Value, dateTimePicker.Value));
        }

        actualizarDeuda();
      } else
      {
        MessageBox.Show(MensajesError.ErrorCheque, MensajesError.Titulo, MessageBoxButtons.OK);
      }
    }

    private void actualizarDeuda()
    {
      labelDeudaTotal.Text = getDeudaTotal().ToString();
    }

    private void actualizarChequesSinCobrar()
    {
      labelChequesSinCobrar.Text = getTotalChequesSinCobrar().ToString();
    }

    private decimal getTotalChequesSinCobrar()
    {
      Cliente cliente = desplegableClientesPagos.SelectedItem as Cliente;
      Decimal total = 0;

      foreach (Pago pago in cliente.pagos)
      {
        if (!pago.cobrado) 
        {
          total += pago.cantidad;
        }
      }

      return total;
    }

    private decimal getDeudaTotal()
    {
      Cliente cliente = desplegableClientesPagos.SelectedItem as Cliente;
      decimal total = sumarDeudas(cliente.deudas) - sumarPagos(cliente.pagos);

      return Math.Max(total, 0);
    }

    private decimal sumarDeudas(BindingList<Deuda> deudas)
    {
      decimal total = 0;

      foreach (Deuda deuda in deudas)
      {
        total += deuda.cantidad;
      }

      return total;
    }

    private decimal sumarPagos (BindingList<Pago> pagos)
    {
      Decimal total = 0;

      foreach (Pago pago in pagos)
      {
        total += pago.cantidad;
      }

      return total;
    }

    private void dataGridViewPagos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      actualizarDeuda();
      actualizarChequesSinCobrar();
    }

    private void dataGridViewDeudas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      actualizarDeuda();
    }

    private void dataGridViewDeudas_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      DAOClientes.dameDAO().guardarDatos();
    }

    private void dataGridViewPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      DAOClientes.dameDAO().guardarDatos();
    }
  }
}
