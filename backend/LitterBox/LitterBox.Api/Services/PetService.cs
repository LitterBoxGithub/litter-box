using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Models;
using LitterBox.Api.Models.Enums;
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
        private readonly IPetRepository _petRepo;
        public PetService(ILogger<IPetService> logger, IPetRepository petRepo)
        {
            _logger = logger;
            _petRepo = petRepo;
        }

        public Pet GetPetById(Guid id)
        {
            return _petRepo.GetPetById(id);
        }

        public async Task<Pet> CreatePetAsync(PetRequest request)
        {
            var pet = new Pet
            {
                UserId = request.UserId,
                Name = request.Name,
                City = request.City,
                PetSpecies = request.PetSpecies,
                PetMassSize = request.PetMassSize,
                PetVolumeSize = request.PetVolumeSize,
            };

            return await _petRepo.CreatePetAsync(pet);
        }
        public async Task<(bool, Pet)> UpdatePetAsync(Guid petId, PetRequest request)
        {
            var pet = new Pet
            {
                UserId = request.UserId,
                Name = request.Name,
                City = request.City,
                PetSpecies = request.PetSpecies,
                PetMassSize = request.PetMassSize,
                PetVolumeSize = request.PetVolumeSize,
            };

            return await _petRepo.UpdatePetAsync(pet);
        }

        public async Task<Pet> DeletePetAsync(Guid id)
        {
            return await _petRepo.DeletePetAsync(id);
        }

    }
}
