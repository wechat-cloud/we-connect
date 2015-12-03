using System.IO;
using System.Threading.Tasks;
using WeConnect.Core;

namespace WeConnect.Components.Material
{
    public interface IMaterialComponent
    {
        #region creation interfaces

        Task<TemporaryMediaCreationResut>       CreateTemporaryMediaAsync(FileDescription file);
        Task<NewsMaterialCreationResult>        CreateNewsMaterialAsync(NewsMaterialDescription newsMaterial);
        Task<NewsMaterialImageCreationResult>   CreateNewsMaterialImageAsync(FileDescription file);
        Task<MaterialCreationResult>            CreateVideoMaterialAsync(FileDescription file, string title, string description);
        Task<MaterialCreationResult>            CreateVoiceMaterialAsync(FileDescription file);
        Task<MaterialCreationResult>            CreateImageMaterialAsync(FileDescription file);

        #endregion

        #region retrieve interfaces

        Task<FileDescription>       GetTemporaryMediaAsync(string mediaId);        
        Task<NewsMaterial>          GetNewsMaterialAsync(string mediaId);
        Task<VideoMaterial>         GetVideoMaterialAsync(string mediaId);
        Task<FileDescription>       GetVoiceMaterialAsync(string mediaId);
        Task<FileDescription>       GetImageMaterialAsync(string mediaId);

        Task<MaterialStatistics>    GetMaterialStatisticsAsync();

        Task<NewsMaterialList>      GetNewsMaterialListAsync(int offset = 0, int count = 20);
        Task<MaterialList>          GetVideoMaterialListAsync(int offset = 0, int count = 20);
        Task<MaterialList>          GetVoiceMaterialListAsync(int offset = 0, int count = 20);
        Task<MaterialList>          GetImageMaterialListAsync(int offset = 0, int count = 20);
        #endregion

        #region modify and delete interfaces

        Task DeleteMaterial(string mediaId);
        Task ModifyNewsMaterialAsync(ModifyNewsMaterialDescription modifyNewsMaterial);

        #endregion
    }
}