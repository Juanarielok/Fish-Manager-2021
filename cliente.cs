using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturilla
{
  public class Cliente
  {
    List<Compra> compras;
    public string nombre;
    public string DNI;

    public Cliente(string nombre, string DNI, List<Compra> compras)
    {
      this.nombre = nombre;
      this.DNI = DNI;
      this.compras = compras;
    }

    public void pasarComprasATabla(DataGridViewRowCollection filasDeLaTabla)
    {
      foreach(Compra compra in compras)
      {
        filasDeLaTabla.Add(compra.compraEnString());
      }
    }

    public void addCompra(Compra compra)
    {
      compras.Add(compra);
    }
  }
}
