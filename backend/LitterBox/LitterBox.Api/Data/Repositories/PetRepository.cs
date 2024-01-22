using LitterBox.Api.Data;
using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LitterBox.Api.Data.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly ILogger<PetRepository> _logger;

        private readonly LitterBoxContext _context;

        #region CRUD
        public PetRepository(ILogger<PetRepository> logger, LitterBoxContext context)
        {
            _logger = logger;
            _context = context;
        }
        public Pet GetPetById(Guid id)
        {
            return _context.Pets.Where(pet => pet.Id == id).FirstOrDefault();
        }

        public async Task<Pet> CreatePetAsync(Pet newPet)
        {
            _context.Pets.Add(newPet);
            await _context.SaveChangesAsync();
            return newPet;
        }

        public async Task<(bool, Pet)> UpdatePetAsync(Pet updatedPet)
        {
            var modified = false;
            if (_context.Pets.Where(pet => pet.Id == updatedPet.Id).Any())
            {
                _context.Pets.Update(updatedPet);
                modified = true;        // should actually compare old entity to new entity using entity state and fields
            }
            await _context.SaveChangesAsync();
            return (modified, updatedPet);
        }

        public async Task<Pet> DeletePetAsync(Guid petId)
        {
            var deletedPet = _context.Pets.Where(user => user.Id == petId).First();
            _context.Pets.Remove(deletedPet);
            await _context.SaveChangesAsync();
            return deletedPet;
        }
        #endregion
    }
}
