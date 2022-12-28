using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturilla
{
  public class Compra
  {
    public decimal cantidad;
    public string detalle;
    public decimal kilo;
    public decimal preciokg;
    public DateTime fecha;

    public Compra(decimal cantidad, string detalle, decimal kilo, decimal preciokg, DateTime fecha)
    {
      this.cantidad = cantidad;
      this.detalle = detalle;
      this.kilo = kilo;
      this.preciokg = preciokg;
      this.fecha = fecha;
    }

    public string[] compraEnString()
    {
      string[] fila = {
          this.cantidad.ToString(),
          this.detalle,
          this.kilo.ToString(),
          this.preciokg.ToString(),
          (this.kilo * this.preciokg).ToString(),
          this.fecha.ToString()
        };

      return fila;
    }
  }

}
