using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturilla.ModeloDeDatos
{
  public class Deuda
  {
    public DateTime fecha { get; set; }
    public decimal cantidad { get; set; }

    public Deuda(decimal cantidad, DateTime fecha)
    {
      this.cantidad = cantidad;
      this.fecha = fecha;
    }

    public Deuda() { }
  }
}
