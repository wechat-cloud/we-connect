using System.IO;
using System.Threading.Tasks;
using WeConnect.Core;

namespace WeConnect.Components.MediaManagement
{
    public interface IMediaComponent
    {
        Task<TemporaryMediaCreationResut> CreateTemporaryMediaAsync(FileDescription file);
        Task<FileDescription> GetTemporaryMediaAsync(string mediaId);

        Task<NewsMaterialCreationResult> CreateNewsMaterialAsync(NewsMaterialDescription newsMaterial);
        Task<NewsMaterialImageCreationResult> CreateNewsMaterialImageAsync(FileDescription file);
        Task<MaterialCreationResult> CreateVideoMaterialAsync(FileDescription file, string title, string description);
        Task<MaterialCreationResult> CreateVoiceMaterialAsync(FileDescription file);
        Task<MaterialCreationResult> CreateImageMaterialAsync(FileDescription file);

        Task<NewsMaterial> GetNewMaterialAsync(string mediaId);
        Task<VideoMaterial> GetVideoMaterialAsync(string mediaId);
        Task<FileDescription> GetMaterialAsync(string mediaId);

        Task DeleteMaterial(string mediaId);

        Task ModifyNewsMaterialAsync(ModifyNewsMaterialDescription modifyNewsMaterial);

        Task<MaterialStatistics> GetMaterialStatisticsAsync();

        Task<NewsMaterialList> GetNewsMaterialListAsync(int offset = 0, int count = 20);
        Task<MaterialList> GetMaterialListAsync(int offset = 0, int count = 20);
    }
}