using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AppEscritorioForms
{
  public class DataAccessLayer
  {
    private SqlConnection _connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=POWER-RED");
    public void InsertContact(Contact contact)
    {
      try
      {
        _connection.Open();
        string query = @"
          INSERT INTO Contacts ([FirstName], [LastName], [Phone], [Address]) 
          VALUES (@FirstName, @LastName, @Phone, @Address);
        ";

        SqlParameter firstName = new SqlParameter();
        firstName.ParameterName = "@FirstName";
        firstName.Value = contact.FirstName;
        firstName.DbType = System.Data.DbType.String;
        SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
        SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
        SqlParameter address = new SqlParameter("@Address", contact.Address);

        SqlCommand command = new SqlCommand(query, _connection);
        command.Parameters.Add(firstName);
        command.Parameters.Add(lastName);
        command.Parameters.Add(phone);
        command.Parameters.Add(address);

        command.ExecuteNonQuery();
      }
      catch (Exception)
      {

        throw;
      }
      finally
      {
        _connection.Close();
      }
    }

    public void UpdateContact(Contact contact)
    {
      try
      {
        _connection.Open();
        string query = @"
          UPDATE Contacts 
          SET 
            FirstName = @FirstName, 
            LastName = @LastName, 
            Phone = @Phone, 
            Address = @Address
          WHERE id = @Id;
        ";
        SqlParameter id = new SqlParameter("@Id", contact.Id);
        SqlParameter firstName = new SqlParameter();
        firstName.ParameterName = "@FirstName";
        firstName.Value = contact.FirstName;
        firstName.DbType = System.Data.DbType.String;
        SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
        SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
        SqlParameter address = new SqlParameter("@Address", contact.Address);

        SqlCommand command = new SqlCommand(query, _connection);
        command.Parameters.Add(id);
        command.Parameters.Add(firstName);
        command.Parameters.Add(lastName);
        command.Parameters.Add(phone);
        command.Parameters.Add(address);

        command.ExecuteNonQuery();
      }
      catch (Exception)
      {

        throw;
      }
      finally
      {
        _connection.Close();
      }
    }

    public List<Contact> GetContacts()
    {
      List<Contact> contacts = new List<Contact>();
      try
      {
        _connection.Open();
        string query = @" SELECT * FROM Contacts";
        SqlCommand command = new SqlCommand(query, _connection);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          contacts.Add(new Contact
          {
            Id = int.Parse(reader["id"].ToString()),
            FirstName = reader["FirstName"].ToString(),
            LastName = reader["LastName"].ToString(),
            Phone = reader["Phone"].ToString(),
            Address = reader["Address"].ToString(),
          });
        }

      }
      catch (Exception)
      {

        throw;
      }
      finally
      {
        _connection.Close();
      }
      return contacts;
    } 

    //MySqlConnection conex = new MySqlConnection();
    //static string servidor = "localhost";
    //static string bd = "winformscontact";
    //static string usuario = "root";
    //static string password = "3242";
    //static string puerto = "3306";

    //string cadenaConexion = $"server={servidor};port={puerto};user id={usuario};password={password};database={bd}";
    //public MySqlConnection setconnection()
    //{
    //  try
    //  {
    //    conex.ConnectionString = cadenaConexion;
    //    conex.Open();
    //    MessageBox.Show("Conexion exitosa");
    //  }
    //  catch (MySqlException e)
    //  {
    //    MessageBox.Show("Error " + e.ToString());
    //  }
    //  return conex;
    //}
  }
}
