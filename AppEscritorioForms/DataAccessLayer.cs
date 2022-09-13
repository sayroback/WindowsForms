using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorioForms
{
  public class DataAccessLayer
  {
    MySqlConnection conex = new MySqlConnection();
    static string servidor = "localhost";
    static string bd = "winformscontact";
    static string usuario = "root";
    static string password = "3242";
    static string puerto = "3306";

    string cadenaConexion = $"server={servidor};port={puerto};user id={usuario};password={password};database={bd}";
    public MySqlConnection setconnection()
    {
      try
      {
        conex.ConnectionString = cadenaConexion;
        conex.Open();
        MessageBox.Show("Conexion exitosa");
      }
      catch (MySqlException e)
      {
        MessageBox.Show("Error " + e.ToString());
      }
      return conex;
    }
  }
}
