using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.DependencyInjection.Extensions;
using WeConnect.Core;

namespace WeConnect.PushingHub
{
    internal class PushingHubInitializer : IComponentInitializer
    {
        public Task InitializeWith(IServiceCollection serviceCollection)
        {
            throw new NotImplementedException();
        }
    }
}
