using Microsoft.Graph;
using System.Collections.Generic;
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
}
