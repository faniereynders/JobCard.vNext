using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Extensibility;
using Microsoft.IdentityModel.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace JobCard.Security
{
    public class AzureADAuthenticationFlow: IAuthenticationFlow
    {
        private AuthenticationResult authenticationResult = default(AuthenticationResult);
        private readonly AzureLoginCustomWebUi azureLoginCustomWebUi;

        public string AuthorizationHeader => authenticationResult?.CreateAuthorizationHeader();

        public AzureADAuthenticationFlow(AzureLoginCustomWebUi azureLoginCustomWebUi)
        {
            this.azureLoginCustomWebUi = azureLoginCustomWebUi;
        }
        public async Task<AuthenticationResult> SignInAsync()
        {
            var clientId = "6a25024d-949b-43f3-b60c-3518fc1350ff";
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
                                      // .WithPrompt(Microsoft.Identity.Client.Prompt.SelectAccount)
                                       //.WithPrompt(Microsoft.Identity.Client.Prompt.Consent)
                                       .WithCustomWebUi(azureLoginCustomWebUi);

                //   JobFunctions.ShowBodyForm(this.pnlBody, new AzureLoginForm(), this.lblTitle);
                authenticationResult = await builder.ExecuteAsync();
            }
            return authenticationResult;
        }

        public Task SignOutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
