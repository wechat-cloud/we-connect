using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.DependencyInjection;
using WeConnect.Core;

namespace WeConnect.Components.Material
{
    public class MaterialComponentInitializer : IComponentInitializer
    {
        public Task InitializeWith(IServiceCollection serviceCollection)
        {
            return Task.Factory.StartNew(() =>
            {
                serviceCollection.AddScoped<IMaterialComponent, MaterialComponent>();
            });
        }
    }
}
