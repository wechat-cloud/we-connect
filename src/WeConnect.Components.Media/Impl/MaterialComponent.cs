using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeConnect.Core;

namespace WeConnect.Components.Material
{
    internal partial class MaterialComponent : IMaterialComponent
    {
        private readonly IApiClient _apiClient;
        private readonly IJsonSerializer _jsonSerializer;

        public MaterialComponent(IApiClient apiClient, IJsonSerializer jsonSerializer)
        {
            _apiClient = apiClient;
            _jsonSerializer = jsonSerializer;
        }

        public Task DeleteMaterial(string mediaId)
        {
            return _apiClient.ExecuteAsync(b =>
                b.UseResource("/cgi-bin/material/del_material")
                 .UseHttps()
                 .UseMethod(HttpMethod.Post)
                 .Json(new { media_id = mediaId })
            );
        }

        public Task ModifyNewsMaterialAsync(ModifyNewsMaterialDescription modifyNewsMaterial)
        {
            return _apiClient.ExecuteAsync(b =>
                b.UseResource("/cgi-bin/material/update_news")
                 .UseHttps()
                 .UseMethod(HttpMethod.Post)
                 .Json(modifyNewsMaterial)
            );
        }
    }
}
