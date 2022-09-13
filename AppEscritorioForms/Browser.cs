using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorioForms
{
  public partial class Browser : Form
  {
    public Browser()
    {
      InitializeComponent();
      InitBrowser();
    }

    #region webView2
    private void webView21_Click(object sender, System.EventArgs e)
    {

    }

    private async Task initializated()
    {
      await webView21.EnsureCoreWebView2Async(null);
    }
    private async void InitBrowser()
    {
      await initializated();
      webView21.CoreWebView2.Navigate("https://www.google.com/");
    }
    #endregion
  }
}
