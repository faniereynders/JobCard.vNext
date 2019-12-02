using Microsoft.Graph;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobCard.Security
{
    public interface IAuthenticationFlow
    {
        string AuthorizationHeader { get; }
        Task<AuthenticationResult> SignInAsync();
        Task SignOutAsync();
    }

    
}
