using System;
using System.Threading.Tasks;

namespace WeConnect.Core
{
    public interface IApiClient
    {
        bool AutoAppendToken { get; set; }

        Task                    ExecuteAsync(ApiDescription apiDescription);
        Task<T>                 ExecuteAndGetResultAsync<T>(ApiDescription apiDescription);
        Task<FileDescription>   ExecuteAndGetFileAsync(ApiDescription apiDescription);
    }
}