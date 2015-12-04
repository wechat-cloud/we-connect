using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeConnect.Core;

namespace WeConnect
{
    internal class DefaultApiClient : IApiClient
    {
        private readonly ITokenManager _tokenManager;
        private readonly IInnerHttpClient _innerHttpClient;
        public DefaultApiClient(ITokenManager tokenManager, IInnerHttpClient innerHttpClient)
        {
            _tokenManager = tokenManager;
            _innerHttpClient = innerHttpClient;
        }

        public bool AutoAppendToken { get; set; } = true;

        public Task ExecuteAsync(ApiDescription apiDescription)
        {
            throw new NotImplementedException();
        }

        public Task<FileDescription> ExecuteAndGetFileAsync(ApiDescription apiDescription)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteAndGetResultAsync<T>(ApiDescription apiDescription) {
            throw new NotImplementedException();
        }
    }
}
