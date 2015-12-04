using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;
using WeConnect.Tokens;

namespace WeConnect
{
    internal class InMemoryTokenManager : ITokenManager
    {
        private readonly ITokenRetriever _tokenRetriever;
        private readonly ApplicationCredential _credential;

        private readonly IDictionary<ApplicationCredential, ApplicationToken> _memoryTokens;

        public InMemoryTokenManager(ITokenRetriever tokenRetriever, ICredentialProvider credentialProvider)
        {
            _tokenRetriever = tokenRetriever;
            _credential = credentialProvider.GenerateCredential();
            
            _memoryTokens = new ConcurrentDictionary<ApplicationCredential, ApplicationToken>();
        }

        public async Task<ApplicationToken> RetrieveToken()
        {
            ApplicationToken token = null;
            if (_memoryTokens.TryGetValue(_credential, out token))
            {
                if (!token.IsExpired())
                {
                    return token;
                }
                _memoryTokens.Remove(_credential);
            }

            await RefreshTokenAsync();
            return await RetrieveToken();
        }

        public async Task RefreshTokenAsync()
        {
            var token = await _tokenRetriever.RetrieveTokenRemotely(_credential);
            _memoryTokens.Add(_credential, token);
        }
    }
}
