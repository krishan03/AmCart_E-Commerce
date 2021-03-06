﻿using System.Threading.Tasks;

namespace AmCart.IAMModule
{
    public interface IUserRepository
    {
        Task<string> CreateAsync(User user);

        Task<User> GetUserAsync(string id);

        Task<User> GetUserByUsernameAsync(string username);

        Task<User> ValidateUserAsync(string username, string password);
    }
}
