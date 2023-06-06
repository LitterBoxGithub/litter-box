using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using System;
using System.Threading.Tasks;

namespace LitterBox.Api.Services.Interfaces
{
    public interface IUserService
    {
        public User GetUserById(Guid userId);

        public Task CreateUserAsync(UserRequest request);

        public Task UpdateUserAsync(Guid userId, UserRequest updatedUser);

        public Task DeleteUserAsync(Guid guid);
    }
}
