using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace facturilla.ModeloDeDatos
{
  [XmlInclude(typeof(PagoCheque)), XmlInclude(typeof(PagoEfectivo))]
  public abstract class Pago
  {
    public string descripcion { get; set; }
    public decimal cantidad { get; set; }
    public abstract bool cobrado { get; set; }
    public DateTime fecha { get; set; }

  }
}
