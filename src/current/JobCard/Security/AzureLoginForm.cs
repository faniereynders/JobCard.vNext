using Microsoft.Toolkit.Forms.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace JobCard.Security
{
    

    public partial class AzureLoginForm : Form
    {
        private readonly WebView webview = new WebView();
        private bool done = false;


        public AzureLoginForm()
        {
            InitializeComponent();

            Init();

            webview.NavigationStarting += Webview_NavigationStarting;
        }

        private void Webview_NavigationStarting(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs e)
        {
            if (e.Uri.ToString().StartsWith("http://localhost:5000/auth", StringComparison.OrdinalIgnoreCase))
            {
                ApplicationState.AuthorizationCallbackUri = e.Uri;
                done = true;
            }
        }

        public Task WaitUntilDone()
        {
            while (!done)
            {

            }
            return Task.CompletedTask;
        }

        private void Init()
        {
            ((ISupportInitialize)webview).BeginInit();
            webview.Dock = DockStyle.Fill;
            
            Controls.Add(webview);
            ((ISupportInitialize)webview).EndInit();
        }

        public void Navigate(string url)
        {
            WebView.Navigate(url);
        }

        public WebView WebView => webview;

        private void WebView_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
