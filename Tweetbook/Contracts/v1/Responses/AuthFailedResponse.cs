using System;
using System.Collections.Generic;

namespace Tweetbook.Contracts.v1.Responses
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors {get; set; }
    }
}
