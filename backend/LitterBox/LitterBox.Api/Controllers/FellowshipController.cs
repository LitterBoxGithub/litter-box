using LitterBox.Api.Models;
using LitterBox.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace LitterBox.Api.Controllers
{
    public class FellowshipController : Controller
    {
        private readonly ILogger<FellowshipController> _logger;
        private readonly IFellowshipService _fellowshipService;
        private readonly IPetService _petService;

        public FellowshipController
        (
            ILogger<FellowshipController> logger,
            IFellowshipService fellowshipService,
            IPetService petService
        )
        {
            _logger = logger;
            _fellowshipService = fellowshipService;
        }

        [HttpGet]
        [Route("initiate-fellowship/{initiatorPetId}/{otherPetId}")]
        public async Task<IActionResult> InitiateFellowship(string initiatorPetId, string otherPetId)
        {
            return Ok(await _fellowshipService.InitiateFellowshipAsync(Guid.Parse(initiatorPetId), Guid.Parse(otherPetId)));
        }

        [HttpGet]
        [Route("finalize-fellowship/{fellowshipId}/{match}")]
        public async Task<IActionResult> FinalizeFellowship(string fellowshipId, bool match)
        {
            return Ok(await _fellowshipService.FinalizeFellowshipAsync(Guid.Parse(fellowshipId), match));
        }

        [HttpGet]
        [Route("get-candidate-fellowships/{petId}")]
        public async Task<IActionResult> GetCandidateFellowships(string petId)
        {
            return Ok(await _fellowshipService.GetCandidateFellowshipsAsync(Guid.Parse(petId)));
        }
    }
}
