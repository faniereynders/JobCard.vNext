using Microsoft.Graph;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Extensibility;
using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JobCard.Security
{
    public class AzureADAuthenticationProvider : IAuthenticationProvider
    {
        private readonly IAuthenticationFlow authenticationFlow;

        public AzureADAuthenticationProvider(IAuthenticationFlow authenticationFlow)
        {
            this.authenticationFlow = authenticationFlow;
        }
        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            request.Headers.Add("Authorization", authenticationFlow.AuthorizationHeader);
        }

        
    }

    public class AzureADAuthenticationFlow: IAuthenticationFlow
    {
        private AuthenticationResult authenticationResult = default(AuthenticationResult);
        private readonly AzureLoginCustomWebUi azureLoginCustomWebUi;

        public string AuthorizationHeader => authenticationResult?.CreateAuthorizationHeader();

        public AzureADAuthenticationFlow(AzureLoginCustomWebUi azureLoginCustomWebUi)
        {
            this.azureLoginCustomWebUi = azureLoginCustomWebUi;
        }
        public async Task SignInAsync()
        {
            var clientId = "8898135d-4300-4ef2-b007-c62d827a2743";
            var tenant = "organizations";
            var scopes = new string[] { "user.read", "GroupMember.Read.All" };

            var clientApp = PublicClientApplicationBuilder.Create(clientId)
                .WithRedirectUri("http://localhost:5000/auth")
                .WithAuthority(AzureCloudInstance.AzurePublic, tenant)
                .Build();

            TokenCacheHelper.EnableSerialization(clientApp.UserTokenCache);

            IdentityModelEventSource.ShowPII = true;

            var accounts = await clientApp.GetAccountsAsync();
            try
            {
                authenticationResult = await clientApp.AcquireTokenSilent(scopes, accounts.FirstOrDefault())
                       .ExecuteAsync();
            }
            catch (MsalUiRequiredException ex)
            {
                //var login = serviceProvider.GetService<AzureLoginCustomWebUi>();
                var builder = clientApp.AcquireTokenInteractive(scopes)
                                       .WithPrompt(Microsoft.Identity.Client.Prompt.SelectAccount)
                                       .WithCustomWebUi(azureLoginCustomWebUi);

                //   JobFunctions.ShowBodyForm(this.pnlBody, new AzureLoginForm(), this.lblTitle);
                authenticationResult = await builder.ExecuteAsync();
            }
        }

        public Task SignOutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
