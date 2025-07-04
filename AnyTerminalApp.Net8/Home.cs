using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyTerminalApp.Net8
{
  public partial class Home : Form
  {
    public Home()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Text = AppInfo.Name;
      LblAppVersion.Text = $"Version {AppInfo.ReleaseVersion} ({AppInfo.ReleaseDate})";
    }

    private void BtnComPort_Click(object sender, EventArgs e)
    {
      this.Hide();

      // Check if already open
      foreach (Form form in Application.OpenForms)
      {
        if (form is FrmComPort)
        {
          form.WindowState = FormWindowState.Normal;
          form.BringToFront();
          form.Focus();
          return;
        }
      }

      // Not open → create and show new instance
      var frmComPort = new FrmComPort();
      frmComPort.ShowDialog();

      this.Show();
    }

    private void BtnTcpClientPort_Click(object sender, EventArgs e)
    {

    }

    private void BtnTcpServerPort_Click(object sender, EventArgs e)
    {

    }
  }
}
