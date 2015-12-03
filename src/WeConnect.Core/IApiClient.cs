using System.Threading.Tasks;

namespace WeConnect.Core
{
    public interface IApiClient
    {
        bool AutoAppendToken { get; set; }

        Task<T> ExecuteAsync<T>(ApiDescription apiDescription);
        Task<FileDescription> ExecuteAndGetFileAsync(ApiDescription apiDescription);
    }
}