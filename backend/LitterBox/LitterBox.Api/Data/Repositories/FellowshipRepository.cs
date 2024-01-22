using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LitterBox.Api.Data.Repositories
{
    public class FellowshipRepository : IFellowshipRepository
    {
        private readonly ILogger<IFellowshipRepository> _logger;
        private readonly LitterBoxContext _context;

        public FellowshipRepository(ILogger<IFellowshipRepository> logger, LitterBoxContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<Fellowship> InitiateFellowshipAsync(Guid userId1, Guid petId1, Guid userId2, Guid petId2)
        {
            var newFellowship = new Fellowship
            {
                UserId1 = userId1,
                PetId1 = petId1,
                UserId2 = userId2,
                PetId2 = petId2
            };

            await _context.Fellowships.AddAsync(newFellowship);
            await _context.SaveChangesAsync();

            return newFellowship;
        }

        public async Task<Fellowship> FinalizeFellowshipAsync(Guid fellowshipId, bool match)
        {
            var foundFellowship = _context.Fellowships.Where(f => f.Id == fellowshipId).FirstOrDefault();

            var finalizedFellowship = new Fellowship
            {
                Id = foundFellowship.Id,
                UserId1 = foundFellowship.UserId1,
                PetId1 = foundFellowship.PetId1,
                UserId2 = foundFellowship.UserId2,
                PetId2 = foundFellowship.PetId2,
                IsMatched = match,
            };

            _context.Fellowships.Update(finalizedFellowship);
            await _context.SaveChangesAsync();

            return finalizedFellowship;
        }

        public async Task<IEnumerable<Fellowship>> GetCandidateFellowshipsAsync(Guid petId2)
        {
            // Note pet id 2 represents the finalizer for the fellowship
            var candidateFellowships = _context.Fellowships.Where(f => f.PetId2 == petId2);
            await _context.SaveChangesAsync();
            return candidateFellowships;
        }
    }
}
