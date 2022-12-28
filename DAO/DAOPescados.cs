using facturilla.ModeloDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace facturilla.DAO
{
  internal sealed class DAOPescados : DAO
  {
    private static DAOPescados instancia = null;
    public BindingList<Pescado> pescados;

    private DAOPescados()
    {
      try
      {
        cargarDatos();
      } catch (FileNotFoundException)
      {
        pescados = new BindingList<Pescado>();
      }
      
      pescados.ListChanged += guardarDatos;
    }

    public static DAOPescados dameDAO()
    {
      if (instancia == null)
      {
        instancia = new DAOPescados();
      }

      return instancia;
    }

    public void addPescado(Pescado pescado)
    {
      pescados.Add(pescado);
    }

    public void cargarDatos()
    {
      XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Pescado>));
      TextReader reader = new StreamReader(Filenames.FILENAME_PESCADOS);

      pescados = (BindingList<Pescado>) serializer.Deserialize(reader);
    }

    public void guardarDatos(object sender, EventArgs e)
    {
      guardarDatos();
    }

    public void guardarDatos()
    {
      XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Pescado>));
      TextWriter writer = new StreamWriter(Filenames.FILENAME_PESCADOS);

      serializer.Serialize(writer, pescados);
      writer.Close();
    }
  }
}
