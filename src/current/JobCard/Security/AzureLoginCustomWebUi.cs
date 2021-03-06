﻿using Microsoft.Identity.Client.Extensibility;
using Reytec.JobCard.Core;
using Reytec.JobCard.Functions.GUITransformation;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebWindows;

namespace JobCard.Security
{
    public class AzureLoginCustomWebUi : ICustomWebUi
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        private const UInt32 WM_CLOSE = 0x0010;
       // private readonly Main mainForm;
        private readonly AzureLoginForm azureLoginForm;

        public static void CloseWindow(IntPtr hwnd)
        {
            SendMessage(hwnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        public AzureLoginCustomWebUi(AzureLoginForm azureLoginForm)
        {
          //  this.mainForm = mainForm;
            this.azureLoginForm = azureLoginForm;
        }

        public async Task<Uri> AcquireAuthorizationCodeAsync(Uri authorizationUri, Uri redirectUri, CancellationToken cancellationToken)
        {
            JobFunctions.ShowBodyForm(ApplicationState.MainForm.pnlBody, azureLoginForm, ApplicationState.MainForm.lblTitle);
            azureLoginForm.Navigate(authorizationUri.ToString());
            await azureLoginForm.WaitUntilDone();
            return ApplicationState.AuthorizationCallbackUri;
        }
    }
}
