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
        public Task<MaterialCreationResult> CreateImageMaterialAsync(FileDescription file)
        {
            return _apiClient.ExecuteAndGetResultAsync<MaterialCreationResult>(b =>
                b.UseResource("/cgi-bin/media/upload")
                 .UseHttps()
                 .UseParameter("type", "image")
                 .File("media", file.FileName, file.FileStream)
            );
        }

        public Task<NewsMaterialCreationResult> CreateNewsMaterialAsync(NewsMaterialDescription newsMaterial)
        {
            throw new NotImplementedException();
        }

        public Task<NewsMaterialImageCreationResult> CreateNewsMaterialImageAsync(FileDescription file)
        {
            throw new NotImplementedException();
        }

        public Task<TemporaryMediaCreationResut> CreateTemporaryMediaAsync(FileDescription file)
        {
            throw new NotImplementedException();
        }

        public Task<MaterialCreationResult> CreateVideoMaterialAsync(FileDescription file, string title, string description)
        {
            throw new NotImplementedException();
        }

        public Task<MaterialCreationResult> CreateVoiceMaterialAsync(FileDescription file)
        {
            throw new NotImplementedException();
        }
    }
}
