using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;

namespace WeConnect.Components.MediaManagement
{
    internal class MediaComponent : IMediaComponent
    {
        private readonly IApiClient _apiClient;
        public MediaComponent(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Task<MaterialCreationResult> CreateImageMaterialAsync(FileDescription file)
        {
            throw new NotImplementedException();
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

        public Task DeleteMaterial(string mediaId)
        {
            throw new NotImplementedException();
        }

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

        public Task ModifyNewsMaterialAsync(ModifyNewsMaterialDescription modifyNewsMaterial)
        {
            throw new NotImplementedException();
        }
    }
}
