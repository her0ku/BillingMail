using BillingMail.Models;

using System.Threading.Tasks;

namespace BillingMail.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(UserRoleModel model);
    }
}
