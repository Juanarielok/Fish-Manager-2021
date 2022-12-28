using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturilla.ModeloDeDatos
{
  public class PagoEfectivo : Pago
  {
    public override bool cobrado { get { return true; } set { } }

    public PagoEfectivo(decimal cantidad, DateTime fecha)
    {
      this.cantidad = cantidad;
      this.fecha = fecha;
      descripcion = "Deuda pagada o reducida en efectivo";
    }

    public PagoEfectivo() { }
  }
}
