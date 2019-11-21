using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AzureLoginProxy
{
    class Program
    {
        
        public static IPublicClientApplication PublicClientApp;
        private static string ClientId = "8898135d-4300-4ef2-b007-c62d827a2743";
        private static string Tenant = "1830360c-5d89-409b-8fa4-27204b64c85e";
        static void Main(string[] args)
        {
            var handle = new IntPtr(int.Parse(args[0]));
            Login(handle).Wait();
        }
 


        static async Task Login(IntPtr handle)
        {
            PublicClientApp = PublicClientApplicationBuilder.Create(ClientId)
               .WithRedirectUri("http://localhost")
               .WithDefaultRedirectUri()
               .WithAuthority(AzureCloudInstance.AzurePublic, Tenant)
               .WithParentActivityOrWindow(()=>handle)
               .Build();

            var _scopes = new string[] { "user.read" }.AsEnumerable();
            var authResult = await PublicClientApp
                .AcquireTokenInteractive(_scopes)
                .WithUseEmbeddedWebView(true)
                .ExecuteAsync();

            Console.WriteLine(authResult.AccessToken);
           
        }
    }
}
