using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;
using Microsoft.Extensions.DependencyInjection;

namespace WeConnect
{
    public class DefaultWechatKernelFactory : IWechatKernelFactory
    {
        private static IServiceCollection InnerServiceCollection;
        static DefaultWechatKernelFactory() {
            InnerServiceCollection = new ServiceCollection();
            RegisterFrameworkServices(InnerServiceCollection);
        }

        private static void RegisterFrameworkServices(IServiceCollection innerServiceCollection)
        {
            throw new NotImplementedException();
        }

        public IWechatKernel CreateKernel(string appId, string appSecret)
        {
            throw new NotImplementedException();
        }
    }
}
