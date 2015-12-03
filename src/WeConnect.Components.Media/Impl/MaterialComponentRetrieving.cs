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
        public Task<FileDescription> GetTemporaryMediaAsync(string mediaId)
        {
            return _apiClient.ExecuteAndGetFileAsync(b =>
                b.UseResource("/cgi-bin/media/get")
                 .UseHttps()
                 .UseMethod(HttpMethod.Get)
                 .UseParameter("media_id", "mediaId")
            );
        }

        public Task<NewsMaterial> GetNewsMaterialAsync(string mediaId)
        {
            return _apiClient.ExecuteAndGetResultAsync<NewsMaterial>(b =>
                b.UseResource("/cgi-bin/material/get_material")
                 .UseHttps()
                 .UseMethod(HttpMethod.Post)
                 .Json(new { media_id = mediaId })
            );
        }

        public Task<VideoMaterial> GetVideoMaterialAsync(string mediaId)
        {
            return _apiClient.ExecuteAndGetResultAsync<VideoMaterial>(b =>
                b.UseResource("/cgi-bin/material/get_material")
                 .UseHttps()
                 .UseMethod(HttpMethod.Post)
                 .Json(new { media_id = mediaId })
            );
        }

        public Task<FileDescription> GetVoiceMaterialAsync(string mediaId)
        {
            return _apiClient.ExecuteAndGetFileAsync(b =>
                b.UseResource("/cgi-bin/material/get_material")
                 .UseHttps()
                 .UseMethod(HttpMethod.Post)
                 .UseParameter("media_id", "mediaId")
            );
        }

        public Task<FileDescription> GetImageMaterialAsync(string mediaId)
        {
            return _apiClient.ExecuteAndGetFileAsync(b =>
                b.UseResource("/cgi-bin/material/get_material")
                 .UseHttps()
                 .UseMethod(HttpMethod.Post)
                 .UseParameter("media_id", "mediaId")
            );
        }

        public Task<MaterialStatistics> GetMaterialStatisticsAsync()
        {
            return _apiClient.ExecuteAndGetResultAsync<MaterialStatistics>(b =>
                b.UseResource("/cgi-bin/material/get_materialcount")
                 .UseHttps()
                 .UseMethod(HttpMethod.Get)
            );
        }


        public Task<NewsMaterialList> GetNewsMaterialListAsync(int offset = 0, int count = 20)
        {
            return _apiClient.ExecuteAndGetResultAsync<NewsMaterialList>(b =>
                b.UseResource("/cgi-bin/material/batchget_material")
                 .UseHttps()
                 .UseMethod(HttpMethod.Post)
                 .Json(new { type = "news", offset = offset, count = count })
            );
        }

        public Task<MaterialList> GetVideoMaterialListAsync(int offset = 0, int count = 20)
        {
            return _apiClient.ExecuteAndGetResultAsync<MaterialList>(b =>
                b.UseResource("/cgi-bin/material/batchget_material")
                 .UseHttps()
                 .UseMethod(HttpMethod.Post)
                 .Json(new { type = "video", offset = offset, count = count })
            );
        }

        public Task<MaterialList> GetVoiceMaterialListAsync(int offset = 0, int count = 20)
        {
            return _apiClient.ExecuteAndGetResultAsync<MaterialList>(b =>
                b.UseResource("/cgi-bin/material/batchget_material")
                 .UseHttps()
                 .UseMethod(HttpMethod.Post)
                 .Json(new { type = "voice", offset = offset, count = count })
            );
        }

        public Task<MaterialList> GetImageMaterialListAsync(int offset = 0, int count = 20)
        {
            return _apiClient.ExecuteAndGetResultAsync<MaterialList>(b =>
                b.UseResource("/cgi-bin/material/batchget_material")
                 .UseHttps()
                 .UseMethod(HttpMethod.Post)
                 .Json(new { type = "image", offset = offset, count = count })
            );
        }
    }
}
