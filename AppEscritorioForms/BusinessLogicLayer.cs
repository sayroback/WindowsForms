using System.Collections.Generic;

namespace AppEscritorioForms
{
  public class BusinessLogicLayer
  {
    private DataAccessLayer _dataAccessLayer;
    public BusinessLogicLayer()
    {
      _dataAccessLayer = new DataAccessLayer();
    }
    public Contact SaveContact(Contact contact)
    {
      if (contact.Id == 0)
        _dataAccessLayer.InsertContact(contact);
      else
        _dataAccessLayer.UpdateContact(contact);
      return contact;
    }

    public List<Contact> GetContacts(string searchText = null)
    {
      return _dataAccessLayer.GetContacts(searchText);
    }
    
    public void DeleteContact(int id)
    {
      _dataAccessLayer.DeleteContact(id);
    }
  }
}
