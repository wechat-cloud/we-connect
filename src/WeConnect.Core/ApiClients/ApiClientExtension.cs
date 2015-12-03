using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeConnect.Core
{
    public static class ApiClientExtension
    {
        public static Task ExecuteAsync(this IApiClient client, Action<ApiDescriptionBuilder> builder)
        {
            var apiDescriptionbuilder = new ApiDescriptionBuilder();
            builder(apiDescriptionbuilder);

            return client.ExecuteAsync(apiDescriptionbuilder.Build());
        }

        public static Task<T> ExecuteAndGetResultAsync<T>(this IApiClient client, Action<ApiDescriptionBuilder> builder) {
            var apiDescriptionbuilder = new ApiDescriptionBuilder();
            builder(apiDescriptionbuilder);

            return client.ExecuteAndGetResultAsync<T>(apiDescriptionbuilder.Build());
        }

        public static Task<FileDescription> ExecuteAndGetFileAsync(this IApiClient client, Action<ApiDescriptionBuilder> builder) {
            var apiDescriptionbuilder = new ApiDescriptionBuilder();
            builder(apiDescriptionbuilder);

            return client.ExecuteAndGetFileAsync(apiDescriptionbuilder.Build());
        }
    }
}
