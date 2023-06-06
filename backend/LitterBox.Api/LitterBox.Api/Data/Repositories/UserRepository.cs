using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LitterBox.Api.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ILogger<UserRepository> _logger;
        private readonly LitterBoxContext _ctx;

        public UserRepository(ILogger<UserRepository> logger, LitterBoxContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public User GetUserById(Guid userId)
        {
            return _ctx.Users.Where(user => user.Id == userId).FirstOrDefault();
        }

        public async Task CreateUserAsync(User newUser)
        {
            _ctx.Users.Add(newUser);
            await _ctx.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User updatedUser)
        {
            if(_ctx.Users.Where(user => user.Id == updatedUser.Id).Any())
            {
                _ctx.Users.Update(updatedUser);
            }
            await _ctx.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(Guid userId)
        {
            var deletedUser = _ctx.Users.Where(user => user.Id == userId).First();
            _ctx.Users.Remove(deletedUser);
            await _ctx.SaveChangesAsync();
        }
    }
}
