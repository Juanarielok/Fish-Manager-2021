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
  public sealed class DAOFrigos : DAO
  {
    private static DAOFrigos instancia = null;
    public BindingList<Frigorifico> frigos;

    private DAOFrigos()
    {
      try
      {
        cargarDatos();
      }
      catch (FileNotFoundException)
      {
        frigos = new BindingList<Frigorifico>();
      }
      
      frigos.ListChanged += guardarDatos;
    }

    public static DAOFrigos dameDAO()
    {
      if (instancia == null)
      {
        instancia = new DAOFrigos();
      }

      return instancia;
    }

    public void addFrigo(Frigorifico frigo)
    {
      frigos.Add(frigo);

      frigo.compras.ListChanged += guardarDatos;
      frigo.stocks.ListChanged += guardarDatos;
    }

    public void cargarDatos()
    {
      XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Frigorifico>));
      TextReader reader = new StreamReader(Filenames.FILENAME_FRIGOS);

      frigos = (BindingList<Frigorifico>) serializer.Deserialize(reader);
    }

    public void guardarDatos(object sender, EventArgs e)
    {
      guardarDatos();
    }

    public void guardarDatos()
    {
      XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Frigorifico>));
      TextWriter writer = new StreamWriter(Filenames.FILENAME_FRIGOS);

      serializer.Serialize(writer, frigos);
      writer.Close();
    }
  }
}
