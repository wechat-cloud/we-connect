using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Components.Material;
using WeConnect.Core;

namespace WeConnect.Components.Material
{
    internal partial class MaterialComponent : IMaterialComponent
    {
        public Task<TemporaryMediaCreationResut> CreateTemporaryMediaAsync(FileDescription file)
        {
            return _apiClient.ExecuteAndGetResultAsync<TemporaryMediaCreationResut>(b =>
                b.UseResource("/cgi-bin/media/upload")
                 .UseHttps()
                 .AddFile("media", file)
            );
        }

        public Task<NewsMaterialCreationResult> CreateNewsMaterialAsync(NewsMaterialDescription newsMaterial)
        {
            return _apiClient.ExecuteAndGetResultAsync<NewsMaterialCreationResult>(b =>
                b.UseResource("/cgi-bin/material/add_news")
                 .UseHttps()
                 .Json(newsMaterial));
        }

        public Task<NewsMaterialImageCreationResult> CreateNewsMaterialImageAsync(FileDescription file)
        {
            return _apiClient.ExecuteAndGetResultAsync<NewsMaterialImageCreationResult>(b =>
                b.UseResource("/cgi-bin/media/uploadimg")
                 .UseHttps()
                 .AddFile("media", file)
            );
        }

        public Task<MaterialCreationResult> CreateVideoMaterialAsync(FileDescription file, string title, string introduction)
        {
            var description = _jsonSerializer.Serialize(new {
                title = title,
                introduction = introduction
            });

            return _apiClient.ExecuteAndGetResultAsync<MaterialCreationResult>(b =>
                b.UseResource("/cgi-bin/material/add_material")
                 .UseHttps()
                 .UseParameter("type", "video")
                 .Form("description", description)
                 .AddFile("media", file)
            );
        }

        public Task<MaterialCreationResult> CreateVoiceMaterialAsync(FileDescription file)
        {
            return _apiClient.ExecuteAndGetResultAsync<MaterialCreationResult>(b =>
                b.UseResource("/cgi-bin/material/add_material")
                 .UseHttps()
                 .UseParameter("type", "voice")
                 .AddFile("media", file)
            );
        }

        public Task<MaterialCreationResult> CreateImageMaterialAsync(FileDescription file)
        {
            return _apiClient.ExecuteAndGetResultAsync<MaterialCreationResult>(b =>
                b.UseResource("/cgi-bin/media/upload")
                 .UseHttps()
                 .UseParameter("type", "image")
                 .AddFile("media", file)
            );
        }
    }
}
