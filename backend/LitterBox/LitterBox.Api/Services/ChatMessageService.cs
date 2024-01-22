using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using LitterBox.Api.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitterBox.Api.Services
{
    public class ChatMessageService : IChatMessageService
    {
        private readonly ILogger<IChatMessageService> _logger;
        private readonly IChatMessageRepository _chatMessageRepo;

        public ChatMessageService(ILogger<IChatMessageService> logger, IChatMessageRepository chatMessageRepo)
        {
            _logger = logger;
            _chatMessageRepo = chatMessageRepo;
        }

        public async Task<IEnumerable<ChatMessage>> GetChatMessagesAsync(Guid petId)
        {
            return await _chatMessageRepo.GetChatMessagesAsync(petId);
        }

        public async Task<ChatMessage> SendChatMessageAsync(SendChatMessageRequest request)
        {
            var chatMessage = new ChatMessage
            {
                AuthorId = request.AuthorId,
                RecipientId = request.RecipientId,
                ChatMessageContent = request.ChatMessageContent,
            };

            return await _chatMessageRepo.SendChatMessageAsync(chatMessage);
        }
    }
}
