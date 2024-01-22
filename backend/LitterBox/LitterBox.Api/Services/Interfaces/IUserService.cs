using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using System;
using System.Threading.Tasks;

namespace LitterBox.Api.Services.Interfaces
{
    public interface IUserService
    {
        public User GetUserById(Guid userId);

        public Task<User> CreateUserAsync(UserRequest request);

        public Task<(bool, User)> UpdateUserAsync(Guid userId, UserRequest request);

        public Task<User> DeleteUserAsync(Guid guid);

    }
}
