using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorioForms
{
  public class BusinessLogicLayer
  {
    private DataAccessLayer _dataAccessLayer;
    public BusinessLogicLayer()
    {
      _dataAccessLayer = new DataAccessLayer();
    }
    public Contact SaveContact(Contact contact) {
      if (contact.Id == 0)
        return null;
      else
        //_dataAccessLayer.UpdateContact
        return null;
    }
  }
}
