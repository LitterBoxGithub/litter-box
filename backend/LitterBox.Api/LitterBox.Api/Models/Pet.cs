using LitterBox.Api.Models.Entities;
using LitterBox.Api.Models.Enums;
using System;

namespace LitterBox.Api.Models
{
    public class Pet : BaseEntity
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public PetSpecies PetSpecies { get; set; }

        public PetMassSize PetMassSize { get; set; }
        
        public PetVolumeSize PetVolumeSize { get; set; }

        public string PetBio { get; set; }

    }
}
