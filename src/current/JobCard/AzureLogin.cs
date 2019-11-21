using CefSharp.WinForms;
using Microsoft.IdentityModel.Clients.ActiveDirectory.Extensibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobCard
{
    public partial class AzureLogin : Form, ICustomWebUi
    {
        private ChromiumWebBrowser browser;
        public AzureLogin()
        {
            InitializeComponent();
            browser = new ChromiumWebBrowser();

            browser.Size = this.Size;
            browser.Location = new Point(0, 0);
            this.Controls.Add(browser);

            this.Show();
        }

        public Task<Uri> AcquireAuthorizationCodeAsync(Uri authorizationUri, Uri redirectUri)
        {
            browser.Load(authorizationUri.ToString());
            return Task.FromResult(redirectUri);
        }

        private void AzureLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
