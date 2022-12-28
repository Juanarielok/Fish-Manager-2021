using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturilla.ModeloDeDatos
{
  public class Pescado
  {
    public string nombre { get; set; }
    public decimal precio { get; set; }

    public Pescado(string nombre, decimal precio)
    {
      this.nombre = nombre;
      this.precio = precio;
    }

    public Pescado() { }

    public override string ToString()
    {
      return nombre;
    }
  }
}
