using Microsoft.Toolkit.Forms.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace JobCard.Security
{
    

    public partial class AzureLoginForm : Form
    {
        private readonly WebView webview = new WebView();

       
        public AzureLoginForm()
        {
            InitializeComponent();

            Init();

            webview.Navigate("https://google.com");
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
