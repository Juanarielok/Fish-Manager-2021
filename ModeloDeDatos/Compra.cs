using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturilla.ModeloDeDatos
{
  public class Compra
  {
    public decimal cantidad { get; set; }
    public Pescado detalle { get; set; }
    public decimal kilo { get; set; }
    public decimal preciokg { get; set; }
    public decimal total { get; set; }
    public DateTime fecha { get; set; }

    public Compra()
    {

    }

    public Compra(decimal cantidad, Pescado detalle, decimal kilo, DateTime fecha)
    {
      this.cantidad = cantidad;
      this.detalle = detalle;
      this.kilo = kilo;
      preciokg = detalle.precio;
      total = preciokg * this.kilo;
      this.fecha = fecha;
    }

    public Compra(decimal cantidad, Pescado detalle, decimal kilo, decimal preciokg, DateTime fecha)
    {
      this.cantidad = cantidad;
      this.detalle = detalle;
      this.kilo = kilo;
      this.preciokg = preciokg;
      total = this.preciokg * this.kilo;
      this.fecha = fecha;
    }
  }

}
