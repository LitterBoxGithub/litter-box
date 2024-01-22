using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitterBox.Api.Services.Interfaces
{
    public interface IChatMessageService
    {
        public Task<IEnumerable<ChatMessage>> GetChatMessagesAsync(Guid id);
        public Task<ChatMessage> SendChatMessageAsync(SendChatMessageRequest request);
    }
}
