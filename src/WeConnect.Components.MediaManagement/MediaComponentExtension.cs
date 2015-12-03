using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;
using Microsoft.Framework.DependencyInjection;

namespace WeConnect.Components.MediaManagement
{
    public static class MediaComponentExtension
    {
        public static IMediaComponent GetMediaManagementComponent(this IWechat kernel) {
            var component = kernel.ServiceResolver.GetRequiredService<IMediaComponent>();
            return component;
        }
    }
}
