using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweetbook.Contracts.v1.Responses
{
    /// <summary>
    /// this class represents the object of our response of to the request that our
    /// api received.
    /// </summary>
    public class PostResponse
    {
        public Guid Id { get; set; }
    }
}
