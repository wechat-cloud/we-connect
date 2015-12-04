using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeConnect.Core
{
    public interface ICredentialProvider
    {
        ApplicationCredential GenerateCredential();
    }
}
