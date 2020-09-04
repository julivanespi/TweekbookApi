using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweetbook.Contracts.v1.Requests
{
    /// <summary>
    /// so this class represents the object the incoming request from a client of our
    /// api
    /// </summary>
    public class CreatePostRequest
    {

        public string Name { get; set; }
    }
}
