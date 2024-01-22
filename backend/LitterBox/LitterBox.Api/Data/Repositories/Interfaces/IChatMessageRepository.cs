using LitterBox.Api.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitterBox.Api.Data.Repositories.Interfaces
{
    public interface IChatMessageRepository
    {
        public Task<IEnumerable<ChatMessage>> GetChatMessagesAsync(Guid id);
        public Task<ChatMessage> SendChatMessageAsync(ChatMessage chatMessage);
    }
}