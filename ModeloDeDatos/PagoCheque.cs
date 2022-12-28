using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturilla.ModeloDeDatos
{
  public class PagoCheque : Pago
  {
    public override bool cobrado { get; set; }

    public PagoCheque(decimal cantidad, DateTime fecha)
    {
      this.cantidad = cantidad;
      this.fecha = fecha;
      descripcion = "Deuda pagada o reducida con cheque";
      cobrado = false;
    }

    public PagoCheque() { }
  }
}
