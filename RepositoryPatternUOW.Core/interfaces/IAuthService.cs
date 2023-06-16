using RepositoryPatternUOW.Core.Models;
using System.Threading.Tasks;

namespace RepositoryPatternUOW.Core.interfaces
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        //Task<string> AddRoleAsync(AddRoleModel model);
    }
}