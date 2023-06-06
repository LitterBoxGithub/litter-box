using LitterBox.Api.Models.Entities;
using System;

namespace LitterBox.Api.Models
{
    public class Photo : BaseEntity
    {
        public Guid UserId { get; set; }

        public Guid PetId { get; set; }

        //This might need to be System.Guid or a more complex object for image store provider
        public string PhotoKey { get; set; }
    }
}
