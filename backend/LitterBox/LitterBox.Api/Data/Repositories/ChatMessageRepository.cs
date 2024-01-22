using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LitterBox.Api.Data.Repositories
{
    public class ChatMessageRepository : IChatMessageRepository
    {
        private readonly ILogger<IChatMessageRepository> _logger;
        private readonly LitterBoxContext _context;

        public ChatMessageRepository(ILogger<IChatMessageRepository> logger, LitterBoxContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IEnumerable<ChatMessage>> GetChatMessagesAsync(Guid petId)
        {
            var chatMessages = _context.ChatMessages.Where(cm => cm.Id == petId);
            await _context.SaveChangesAsync();
            return chatMessages;
        }

        public async Task<ChatMessage> SendChatMessageAsync(ChatMessage chatMessage)
        {
            _context.ChatMessages.Add(chatMessage);
            await _context.SaveChangesAsync();
            return chatMessage;
        }
    }
}
