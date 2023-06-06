using LitterBox.Api.Models.Requests;
using LitterBox.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace LitterBox.Api.Controllers
{
    [ApiController]
    public class PetController : Controller
    {
        private readonly ILogger<PetController> _logger;
        private readonly IPetService _petService;

        public PetController(ILogger<PetController> logger, IPetService petService)
        {
            _logger = logger;
            _petService = petService;
        }

        #region Pet CRUD

        [HttpGet]
        [Route("pet")]
        public IActionResult GetPetById([FromQuery] string id)
        {
            try
            {
                var petId = new Guid(id);
                var pet = _petService.GetPetById(petId);
                return Ok(pet);
            }
            catch(Exception e)
            {
                _logger.LogError(e.ToString());
                return Problem(e.ToString());
            }

        }

        [HttpPost]
        [Route("pet")]
        public async Task<IActionResult> CreatePet([FromBody] PetRequest request)
        {
            try
            {
                await _petService.CreatePetAsync(request);
                return Ok(request);
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                return Problem(e.ToString());
            }
        }

        [HttpPut]
        [Route("pet")]
        public async Task<IActionResult> UpdatePet([FromQuery] string id, [FromBody] PetRequest request)
        {
            try
            {
                var petId = new Guid(id);
                await _petService.UpdatePetAsync(petId, request);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                return Problem(e.ToString());
            }
        }

        [HttpDelete]
        [Route("pet")]
        public async Task<IActionResult> DeletePet([FromQuery] string id)
        {
            try
            {
                var petId = new Guid(id);
                await _petService.DeletePetAsync(petId);
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
