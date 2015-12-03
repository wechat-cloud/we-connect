using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;
using Microsoft.Framework.DependencyInjection;

namespace WeConnect.Components.Material
{
    public static class MaterialComponentExtension
    {
        public static IMaterialComponent GetMediaManagementComponent(this IWechat kernel) {
            var component = kernel.ServiceResolver.GetRequiredService<IMaterialComponent>();
            return component;
        }
    }
}
