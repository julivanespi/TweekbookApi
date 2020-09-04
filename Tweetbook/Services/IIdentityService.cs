using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetbook.Contracts.v1.Requests;
using Tweetbook.Domain;

namespace Tweetbook.Services
{
    public interface IIdentityService
    {
        public Task<AuthenticationResult> RegisterAsync(string email, string password);
        public Task LoginAsync(string email, string password);
    }
}
