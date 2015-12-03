using System.Threading.Tasks;

namespace WeConnect.Core
{
    public interface IApiClient
    {
        bool AutoAppendToken { get; set; }

        Task<T> Execute<T>(string resource, object parames);
    }
}