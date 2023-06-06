using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using LitterBox.Api.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace LitterBox.Api.Services
{
    public class PetService : IPetService
    {
        private readonly ILogger<IPetService> _logger;
        private readonly IPetRepository _petRepository;
        public PetService(ILogger<IPetService> logger, IPetRepository petRepository)
        {
            _logger = logger;
            _petRepository = petRepository;
        }

        public Task CreatePetAsync(PetRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeletePetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Pet GetPetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePetAsync(Guid id, PetRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
