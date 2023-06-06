using LitterBox.Api.Models;
using System;
using System.Threading.Tasks;

namespace LitterBox.Api.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public User GetUserById(Guid userId);

        public Task CreateUserAsync(User newUser);

        public Task UpdateUserAsync(User updatedUser);

        public Task DeleteUserAsync(Guid userId);

    }
}
