using System.Threading.Tasks;

namespace WeConnect.Core
{
    public interface ITokenManager
    {
        Task<ApplicationToken> RetrieveToken();
        Task RefreshTokenAsync();
    }
}