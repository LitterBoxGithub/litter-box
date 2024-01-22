using System;

namespace LitterBox.Api.Models.Requests
{
    public class SendChatMessageRequest
    {
        public Guid AuthorId { get; set; }

        public Guid RecipientId { get; set; }

        // might need to change to account for multimedia/emojis or might be a json string field
        public string ChatMessageContent { get; set; } = string.Empty;

        public bool Read { get; set; }
    }
}
