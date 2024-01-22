using LitterBox.Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitterBox.Api.Data.Repositories.Interfaces
{
    public interface IFellowshipRepository
    {
        public Task<Fellowship> InitiateFellowshipAsync(Guid userId1, Guid petId1, Guid userId2, Guid petId2);
        public Task<Fellowship> FinalizeFellowshipAsync(Guid fellowshipId, bool match);
        public Task<IEnumerable<Fellowship>> GetCandidateFellowshipsAsync(Guid petId);
    }
}
