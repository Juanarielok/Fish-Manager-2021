using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturilla.DAO
{
  public interface DAO
  {
    void guardarDatos(object sender, EventArgs e);

    void guardarDatos();

    void cargarDatos();
  }
}
