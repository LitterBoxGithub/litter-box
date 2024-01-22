using System;
using LitterBox.Api.Models.Entities;

namespace LitterBox.Api.Models
{
    public class ChatMessage : BaseEntity
    {
        public Guid FellowshipId { get; set; }
        
        public Guid AuthorId { get; set; }

        public Guid RecipientId { get; set; }

        // might need to change to account for multimedia/emojis or might be a json string field
        public string ChatMessageContent { get; set; } = string.Empty;

        public bool Read { get; set; }

    }
}
