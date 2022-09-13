using System;
using System.Windows.Forms;

namespace AppEscritorioForms
{
  public partial class ContactDetails : Form
  {
    private BusinessLogicLayer _businessLogicLayer;
    public ContactDetails()
    {
      InitializeComponent();
      _businessLogicLayer = new BusinessLogicLayer();
    }
    private void label4_Click(object sender, EventArgs e)
    {

    }
    private void label3_Click(object sender, EventArgs e)
    {

    }
    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void txtFirstName_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtLastName_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void txtPhone_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtAddress_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      Contact contact = new Contact();
      contact.FirstName = txtFirstName.Text;
      contact.LastName = txtLastName.Text;
      contact.Phone = txtPhone.Text;
      contact.Address = txtAddress.Text;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
