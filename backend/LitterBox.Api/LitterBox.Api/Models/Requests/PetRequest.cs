using LitterBox.Api.Models.Enums;
using System;

namespace LitterBox.Api.Models.Requests
{
    public class PetRequest
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public PetSpecies PetSpecies { get; set; }

        public PetMassSize PetSize { get; set; }

        public PetVolumeSize PetVolumeSize { get; set; }

        public string PetBio { get; set; }
    }
}
