using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;

namespace WeConnect.Tokens
{
    public class TokenRetriever : ITokenRetriever
    {
        private readonly IInnerHttpClient _innerHttpClient;
        public TokenRetriever(IInnerHttpClient innerHttpClient)
        {
            _innerHttpClient = innerHttpClient;
        }

        public Task<ApplicationToken> RetrieveTokenRemotely(ApplicationCredential credential)
        {
            throw new NotImplementedException();
        }
    }
}
