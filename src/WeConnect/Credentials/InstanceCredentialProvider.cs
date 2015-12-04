using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;

namespace WeConnect
{
    public class InstanceCredentialProvider : ICredentialProvider
    {
        private string _appId;
        private string _appSecret;
        public InstanceCredentialProvider()
        {
            
        }

        public InstanceCredentialProvider(string appId, string appSecret)
        {
            _appId = appId;
            _appSecret = appSecret;
        }

        public ApplicationCredential GenerateCredential()
        {
            return new ApplicationCredential(_appId, _appSecret);
        }
    }
}
