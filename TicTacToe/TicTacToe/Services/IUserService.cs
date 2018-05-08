using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public interface IUserService
    {
        Task<bool> RegisterUser(UserModel userModel);

        Task<UserModel> GetUserByEmail(string email);
        Task UpdateUser(UserModel user);
    }
}