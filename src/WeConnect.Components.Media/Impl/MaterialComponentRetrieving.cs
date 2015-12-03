using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;

namespace WeConnect.Components.Material
{
    internal partial class MaterialComponent : IMaterialComponent
    {

        public Task<FileDescription> GetImageMaterialAsync(string mediaId)
        {
            throw new NotImplementedException();
        }

        public Task<MaterialList> GetImageMaterialListAsync(int offset = 0, int count = 20)
        {
            throw new NotImplementedException();
        }

        public Task<MaterialStatistics> GetMaterialStatisticsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NewsMaterial> GetNewsMaterialAsync(string mediaId)
        {
            throw new NotImplementedException();
        }

        public Task<NewsMaterialList> GetNewsMaterialListAsync(int offset = 0, int count = 20)
        {
            throw new NotImplementedException();
        }

        public Task<FileDescription> GetTemporaryMediaAsync(string mediaId)
        {
            throw new NotImplementedException();
        }

        public Task<VideoMaterial> GetVideoMaterialAsync(string mediaId)
        {
            throw new NotImplementedException();
        }

        public Task<MaterialList> GetVideoMaterialListAsync(int offset = 0, int count = 20)
        {
            throw new NotImplementedException();
        }

        public Task<FileDescription> GetVoiceMaterialAsync(string mediaId)
        {
            throw new NotImplementedException();
        }

        public Task<MaterialList> GetVoiceMaterialListAsync(int offset = 0, int count = 20)
        {
            throw new NotImplementedException();
        }
    }
}
