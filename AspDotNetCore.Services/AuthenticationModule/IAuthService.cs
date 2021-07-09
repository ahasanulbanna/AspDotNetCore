using System.Threading.Tasks;
using AspDotNetCore.DataAccess.Models;

namespace AspDotNetCore.Services.AuthenticationModule
{
    public interface IAuthService
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
