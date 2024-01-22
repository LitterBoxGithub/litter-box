using LitterBox.Api.Models;
using System;
using System.Threading.Tasks;

namespace LitterBox.Api.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public User GetUserById(Guid userId);

        public Task<User> CreateUserAsync(User newUser);

        public Task<(bool, User)> UpdateUserAsync(User updatedUser);

        public Task<User> DeleteUserAsync(Guid userId);

    }
}
