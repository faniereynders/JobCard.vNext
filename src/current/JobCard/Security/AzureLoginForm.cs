using Microsoft.Toolkit.Forms.UI.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Windows.UI.Xaml;

namespace JobCard.Security
{
    public partial class AzureLoginForm : Form
    {
        private readonly WebView webview = new WebView();
        public AzureLoginForm()
        {
            InitializeComponent();

            ((ISupportInitialize)webview).BeginInit();
            webview.Dock = DockStyle.Fill;
            webview.ControlAdded += Webview_ControlAdded;
             Controls.Add(webview);
            //  ((ISupportInitialize)webview).EndInit();

            Controls.Add(new Button { Name = "sss", Location = new Point(10, 10) });
        }

        private void Webview_ControlAdded(object sender, ControlEventArgs e)
        {
            WebView.Navigate("https://www.google.com");
        }

        public WebView WebView => webview;

        private void WebView_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
