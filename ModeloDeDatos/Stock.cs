using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturilla.ModeloDeDatos
{
  public class Stock
  {
    public Pescado pescado { get; set; }
    public decimal pesoKg { get; set; }
    public decimal cantidad { get; set; }

    public Stock(Pescado pescado, decimal pesoKg, decimal cantidad)
    {
      this.pescado = pescado;
      this.pesoKg = pesoKg;
      this.cantidad = cantidad;
    }

    public Stock() { }
  }
}
