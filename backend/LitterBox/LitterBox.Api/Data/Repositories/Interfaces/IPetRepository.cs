using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using System.Threading.Tasks;
using System;

namespace LitterBox.Api.Data.Repositories.Interfaces
{
    public interface IPetRepository
    {
        public Pet GetPetById(Guid petId);

        public Task<Pet> CreatePetAsync(Pet pet);

        public Task<(bool, Pet)> UpdatePetAsync(Pet pet);

        public Task<Pet> DeletePetAsync(Guid petId);
    }
}
