using System.Collections.Generic;
using System.Windows.Forms;

namespace AppEscritorioForms
{
  public partial class Main : Form
  {
    private BusinessLogicLayer _businessLogicLayer;
    public Main()
    {
      InitializeComponent();
      _businessLogicLayer = new BusinessLogicLayer();
    }

    #region EVENTS
    private void Form1_Load(object sender, System.EventArgs e)
    {
      PopulateContacts();
    }

    public void PopulateContacts()
    {
      List<Contact> contacts = _businessLogicLayer.GetContacts();
      gridContacts.DataSource = contacts;
    }

    private void gridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      DataGridViewLinkCell cell = (DataGridViewLinkCell)gridContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];
      if (cell.Value.ToString() == "Edit")
      {
        ContactDetails contactDetails = new ContactDetails();
        contactDetails.LoadContact(new Contact
        {
          Id = int.Parse(gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()),
          FirstName = gridContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
          LastName = gridContacts.Rows[e.RowIndex].Cells[2].Value.ToString(),
          Phone = gridContacts.Rows[e.RowIndex].Cells[3].Value.ToString(),
          Address = gridContacts.Rows[e.RowIndex].Cells[4].Value.ToString()
        });
        contactDetails.ShowDialog(this);
      }
      else if (cell.Value.ToString() == "Delete")
      {
        DeleteContact(int.Parse(gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()));
        PopulateContacts();
      }
    }

    private void DeleteContact(int id)
    {
      _businessLogicLayer.DeleteContact(id);
    }

    private void btnAdd_Click(object sender, System.EventArgs e)
    {
      OpenContactDetailsDialog();
    }

    private void btnSearch_Click(object sender, System.EventArgs e)
    {
      //DataAccessLayer dataAccessLayer = new DataAccessLayer();
      //dataAccessLayer.setconnection();
    }

    private void txtSearch_TextChanged(object sender, System.EventArgs e)
    {

    }
    private void btnBrowser_Click(object sender, System.EventArgs e)
    {
      OpenBrowser();
    }

    #endregion

    #region PRIVATE METHODS
    private void OpenContactDetailsDialog()
    {
      ContactDetails contactDetails = new ContactDetails();
      contactDetails.ShowDialog(this);
    }
    private void OpenBrowser()
    {
      Browser browser = new Browser();
      browser.ShowDialog();
    }

    #endregion

  }
}
