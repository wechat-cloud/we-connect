using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeConnect.Core
{
    public interface IWechatKernel
    {
        ITokenManager TokenManager { get; }
        IServiceProvider ServiceResolver { get; }
        ILogFactory LogFactory { get; set; }
    }
}
