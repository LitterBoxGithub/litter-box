using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using LitterBox.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace litter_box_api.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        #region User CRUD

        [HttpGet]
        [Route("user")]
        public IActionResult GetUserById([FromQuery] string id)
        {
            try
            {
                var userId = Guid.NewGuid();
                var user = _userService.GetUserById(userId);
                return Ok(user);
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                return Problem(e.ToString());
            }
        }

        [HttpPost]
        [Route("user")]
        public async Task<IActionResult> CreateUser([FromBody] UserRequest request)
        {
            try
            {
                await _userService.CreateUserAsync(request);
                return Ok(request);
            }
            catch(Exception e)
            {
                _logger.LogError(e.ToString());
                return Problem(e.ToString());
            }
        }

        [HttpPut]
        [Route("user")]
        public async Task<IActionResult> UpdateUser([FromQuery] string id, [FromBody] UserRequest updatedUser)
        {
            try
            {
                var userId = new Guid(id);
                await _userService.UpdateUserAsync(userId, updatedUser);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                return Problem(e.ToString());
            }
        }

        [HttpDelete]
        [Route("user")]
        public async Task<IActionResult> DeleteUser([FromQuery] string id)
        {
            try
            {
                var userId = new Guid(id);
                await _userService.DeleteUserAsync(userId);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                return Problem(e.ToString());
            }
        }

        #endregion

    }
}
 