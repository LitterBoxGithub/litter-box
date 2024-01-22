using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using System;
using System.Threading.Tasks;

namespace LitterBox.Api.Services.Interfaces
{
    public interface IPetService
    {
        public Pet GetPetById(Guid id);

        public Task<Pet> CreatePetAsync(PetRequest request);

        public Task<(bool, Pet)> UpdatePetAsync(Guid id, PetRequest request);

        public Task<Pet> DeletePetAsync(Guid id);

    }
}