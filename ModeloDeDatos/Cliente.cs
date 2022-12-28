using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturilla.ModeloDeDatos
{
  public class Cliente
  {
    public BindingList<Compra> compras;
    public BindingList<Deuda> deudas;
    public BindingList<Pago> pagos;
    public string nombre;

    public Cliente(string nombre)
    {
      this.nombre = nombre;
      compras = new BindingList<Compra>();
      deudas = new BindingList<Deuda>();
      pagos = new BindingList<Pago>();
    }

    public Cliente() { }

    public override string ToString()
    {
      return nombre;
    }
  }
}
