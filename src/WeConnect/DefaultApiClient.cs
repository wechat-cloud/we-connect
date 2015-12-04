using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeConnect.Core
{
    internal class DefaultApiClient : IApiClient
    {
        private readonly ITokenManager _tokenManager;
        public DefaultApiClient(ITokenManager tokenManager)
        {
            _tokenManager = tokenManager;
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
