using Microsoft.Framework.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeConnect.Core
{
    public interface IWechat
    {
        ITokenManager TokenManager { get; }
        IServiceProvider ServiceResolver { get; }
        ILoggerFactory LogFactory { get; }
    }
}
