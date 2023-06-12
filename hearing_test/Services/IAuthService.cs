using hearing_test.Models;
using System.Threading.Tasks;

namespace hearing_test.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        //Task<string> AddRoleAsync(AddRoleModel model);
    }
}