using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobCard.Security
{
    public interface IAuthenticationFlow
    {
        string AuthorizationHeader { get; }
        Task SignInAsync();
        Task SignOutAsync();
    }

    
}
