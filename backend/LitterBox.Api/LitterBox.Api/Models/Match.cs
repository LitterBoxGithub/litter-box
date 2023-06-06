using LitterBox.Api.Models.Entities;
using System;

namespace LitterBox.Api.Models
{
    public class Match : BaseEntity
    {
        public Guid UserId1 { get; set; }

        public Guid? UserId2 { get; set; }

        public Guid PetId1 { get; set; }

        public Guid? PetId2 { get; set; }

    }
}
