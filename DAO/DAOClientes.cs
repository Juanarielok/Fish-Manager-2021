using facturilla.ModeloDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace facturilla.DAO
{
  internal sealed class DAOClientes : DAO
  {
    private static DAOClientes instancia = null;
    public BindingList<Cliente> clientes;

    private DAOClientes()
    {
      try
      {
        cargarDatos();
      } catch (FileNotFoundException)
      {
        clientes = new BindingList<Cliente>();
      }
      
      clientes.ListChanged += guardarDatos;
    }

    public static DAOClientes dameDAO()
    {
      if (instancia == null)
      {
        instancia = new DAOClientes();
      }

      return instancia;
    }

    public void addCliente(Cliente cliente)
    {
      clientes.Add(cliente);

      cliente.compras.ListChanged += guardarDatos;
      cliente.deudas.ListChanged += guardarDatos;
      cliente.pagos.ListChanged += guardarDatos;
    }

    public void guardarDatos(object sender, EventArgs e)
    {
      guardarDatos();
    }

    public void guardarDatos()
    {
      XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Cliente>));
      TextWriter writer = new StreamWriter(Filenames.FILENAME_CLIENTES);

      serializer.Serialize(writer, clientes);
      writer.Close();
    }

    public void cargarDatos()
    {
      XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Cliente>));
      TextReader reader = new StreamReader(Filenames.FILENAME_CLIENTES);

      clientes = (BindingList<Cliente>) serializer.Deserialize(reader);
    }
  }
}
