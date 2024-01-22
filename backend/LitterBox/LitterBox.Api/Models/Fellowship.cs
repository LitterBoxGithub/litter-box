using LitterBox.Api.Models.Entities;
using System;

namespace LitterBox.Api.Models
{
    public class Fellowship : BaseEntity
    {
        // Initiator
        public Guid UserId1 { get; set; }

        public Guid PetId1 { get; set; }

        // Finalizer
        public Guid UserId2 { get; set; }

        public Guid PetId2 { get; set; }

        // Finalizer sets this
        public bool IsMatched { get; set; }

    }
}
