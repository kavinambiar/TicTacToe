using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public class UserService : IUserService
    {
        public Task<bool>RegisterUser(UserModel userModel)
        {
            return Task.FromResult(true);
        }
    }
}
