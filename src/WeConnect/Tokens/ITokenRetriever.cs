using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;

namespace WeConnect.Tokens
{
    internal interface ITokenRetriever
    {
        Task<ApplicationToken> RetrieveTokenRemotely(ApplicationCredential credential);
    }
}
