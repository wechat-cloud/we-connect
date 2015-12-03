using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeConnect.Core
{
    public interface IWechatFactory
    {
        IWechat CreateKernel(string appId, string appSecret);
    }
}
