using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;

namespace WeConnect
{
    public class InstanceCredentialProvider : ICredentialProvider
    {
        private readonly ApplicationCredential _credential;

        public InstanceCredentialProvider(string appId, string appSecret)
        {
            _credential = new ApplicationCredential(appId, appSecret);
        }

        public ApplicationCredential GenerateCredential()
        {
            return _credential;
        }
    }
}
