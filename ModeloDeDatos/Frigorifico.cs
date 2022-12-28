using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturilla.ModeloDeDatos
{
  public class Frigorifico
  {
    public string nombre;
    public BindingList<Compra> compras;
    public BindingList<Stock> stocks;

    public Frigorifico(string nombre)
    {
      this.nombre = nombre;
      compras = new BindingList<Compra>();
      stocks = new BindingList<Stock>();
    }

    public Frigorifico() { }

    public void addStock(Pescado detalle, decimal pesoKg, decimal cantidad)
    {
      Stock stock = buscarStock(detalle);

      if (stock != null)
      {
        stock.pesoKg += pesoKg;
        stock.cantidad += cantidad;
      }
      else
      {
        stock = new Stock(detalle, pesoKg, cantidad);
        stocks.Add(stock);
      }
    }

    public void quitarStock(Pescado detalle, decimal pesoKg, decimal cantidad)
    {
      addStock(detalle, -pesoKg, -cantidad);
    }

    public Stock buscarStock(Pescado detalle)
    {
      Stock stock = null;

      foreach (Stock stockAux in stocks)
      {
        if (stockAux.pescado.nombre == detalle.nombre)
        {
          stock = stockAux;
        }
      }

      return stock;
    }

    public override string ToString()
    {
      return nombre;
    }
  }
}
