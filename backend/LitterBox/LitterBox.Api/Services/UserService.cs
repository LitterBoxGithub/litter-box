using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using LitterBox.Api.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace LitterBox.Api.Services
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IUserRepository _userRepo;
        public UserService(ILogger<UserService> logger, IUserRepository userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
        }

        public UserService() { }

        public User GetUserById(Guid userId)
        {
            return _userRepo.GetUserById(userId);
        }
        
        public async Task<User> CreateUserAsync(UserRequest request)
        {
            var user = new User
            {
                Email = request?.Email,
                FirstName = request?.FirstName,
                LastName = request?.LastName,
            };
            return await _userRepo.CreateUserAsync(user);
        }

        public async Task<(bool, User)> UpdateUserAsync(Guid userId, UserRequest request)
        {
            var user = new User
            {
                Id = userId,
                Email = request?.Email,
                FirstName = request?.FirstName,
                LastName = request?.LastName,
                City = request?.City,
            };
            return await _userRepo.UpdateUserAsync(user);
        }

        public async Task<User> DeleteUserAsync(Guid userId)
        {
            return await _userRepo.DeleteUserAsync(userId);
        }
    }
}
