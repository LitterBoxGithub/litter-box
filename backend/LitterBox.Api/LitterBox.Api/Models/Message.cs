using LitterBox.Api.Models.Entities;
using System;

namespace LitterBox.Api.Models
{
    public class Message : BaseEntity
    {
        public Guid MatchId { get; set; }
        
        public Guid AuthorId { get; set; }

        // might need to change to account for multimedia/emojis
        public string MessageContent { get; set; } = string.Empty;

    }
}
