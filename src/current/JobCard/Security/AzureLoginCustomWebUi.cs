using Microsoft.Identity.Client.Extensibility;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using WebWindows;

namespace JobCard.Security
{
    public class AzureLoginCustomWebUi : ICustomWebUi
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        private const UInt32 WM_CLOSE = 0x0010;

        public static void CloseWindow(IntPtr hwnd)
        {
            SendMessage(hwnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }
        public Task<Uri> AcquireAuthorizationCodeAsync(Uri authorizationUri, Uri redirectUri, CancellationToken cancellationToken)
        {
            var window = new WebWindow("Login");

            ApplicationState.LoginWindowHandle = window.Hwnd;
            window.NavigateToUrl(authorizationUri.ToString());
            window.WaitForExit();

            return Task.FromResult(ApplicationState.AuthorizationCallbackUri);
        }
    }
}
