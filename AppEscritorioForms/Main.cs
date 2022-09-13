using System.Windows.Forms;

namespace AppEscritorioForms
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();
    }

    #region EVENTS
    private void Form1_Load(object sender, System.EventArgs e)
    {

    }

    private void gridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnAdd_Click(object sender, System.EventArgs e)
    {
      OpenContactDetailsDialog();
    }

    private void btnSearch_Click(object sender, System.EventArgs e)
    {
      DataAccessLayer dataAccessLayer = new DataAccessLayer();
      dataAccessLayer.setconnection();
    }

    private void txtSearch_TextChanged(object sender, System.EventArgs e)
    {

    }
    #endregion

    #region PRIVATE METHODS
    private void OpenContactDetailsDialog()
    {
      ContactDetails contactDetails = new ContactDetails();
      contactDetails.ShowDialog();
    }
    #endregion

  }
}
