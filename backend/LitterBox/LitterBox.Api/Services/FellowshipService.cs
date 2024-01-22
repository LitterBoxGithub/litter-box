using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Models;
using LitterBox.Api.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LitterBox.Api.Services
{
    public class FellowshipService : IFellowshipService
    {
        private readonly ILogger<IFellowshipService> _logger;
        private readonly IFellowshipRepository _fellowshipRepo;
        private readonly IUserService _userService;
        private readonly IPetService _petService;

        public FellowshipService
        (
            ILogger<IFellowshipService> logger,
            IFellowshipRepository fellowshipRepo,
            IUserService userService,
            IPetService petService
        )
        {
            _logger = logger;
            _fellowshipRepo = fellowshipRepo;
            _userService = userService;
            _petService = petService;
        }

        public async Task<Fellowship> InitiateFellowshipAsync(Guid petId1, Guid petId2)
        {
            var pet1 = _petService.GetPetById(petId1);
            var pet2 = _petService.GetPetById(petId2);
            var userId1 = _userService.GetUserById(pet1.UserId).Id;
            var userId2 = _userService.GetUserById(pet2.UserId).Id;

            return await _fellowshipRepo.InitiateFellowshipAsync(userId1, petId1, userId2, petId2);
        }

        public async Task<Fellowship> FinalizeFellowshipAsync(Guid fellowshipId, bool match)
        {
            return await _fellowshipRepo.FinalizeFellowshipAsync(fellowshipId, match);
        }

        public async Task<IEnumerable<Pet>> GetCandidateFellowshipsAsync(Guid petId)
        {
            var candidatePets = Enumerable.Empty<Pet>();
            var candidateFellowships = await _fellowshipRepo.GetCandidateFellowshipsAsync(petId);
            var candidatePetIds = candidateFellowships.Select(f => f.PetId1).ToList();
            candidatePetIds.ForEach(cpi =>
            {
                var pet = _petService.GetPetById(cpi);
                candidatePets = candidatePets.Append(pet);
            });
            return candidatePets;
        }
    }
}
