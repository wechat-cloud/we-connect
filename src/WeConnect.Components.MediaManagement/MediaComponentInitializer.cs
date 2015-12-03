﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.DependencyInjection;
using WeConnect.Core;

namespace WeConnect.Components.MediaManagement
{
    public class MediaComponentInitializer : IComponentInitializer
    {
        public Task InitializeWith(IServiceCollection serviceCollection)
        {
            return Task.Factory.StartNew(() =>
            {
                serviceCollection.AddScoped<IMediaComponent, MediaComponent>();
            });
        }
    }
}
