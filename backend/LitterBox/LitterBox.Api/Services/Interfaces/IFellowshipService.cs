using LitterBox.Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitterBox.Api.Services.Interfaces
{
    public interface IFellowshipService
    {
        public Task<Fellowship> InitiateFellowshipAsync(Guid petId1, Guid petId2);
        public Task<Fellowship> FinalizeFellowshipAsync(Guid fellowshipId, bool match);
        public Task<IEnumerable<Pet>> GetCandidateFellowshipsAsync(Guid petId);
    }
}
