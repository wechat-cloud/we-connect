using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.DependencyInjection;
using WeConnect.Core;
using WeConnect.Tokens;

namespace WeConnect
{
    public class WeConnectInitializer : IComponentInitializer
    {
        public Task InitializeWith(IServiceCollection serviceCollection)
        {
            return Task.Factory.StartNew(() =>
            {
                serviceCollection
                    .AddScoped<IApiClient, DefaultApiClient>()
                    .AddScoped<IJsonSerializer, DefaultJsonSerializer>()
                    .AddScoped<ITokenRetriever, TokenRetriever>()
                    .AddScoped<IInnerHttpClient, InnerHttpClient>()
                    .AddSingleton<ITokenManager, InMemoryTokenManager>()
                    .AddInstance<ICredentialProvider>(new InstanceCredentialProvider());
            });
        }
    }
}
