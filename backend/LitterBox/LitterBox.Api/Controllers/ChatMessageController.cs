using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using LitterBox.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitterBox.Api.Controllers
{
    [ApiController]
    public class ChatMessageController : Controller
    {
        private readonly ILogger<ChatMessageController> _logger;
        private readonly IChatMessageService _chatMessageService;
        private readonly IPetService _petService;

        public ChatMessageController
        (
            ILogger<ChatMessageController> logger,
            IChatMessageService chatMessageService,
            IPetService petService
        )
        {
            _logger = logger;
            _chatMessageService = chatMessageService;
            _petService = petService;
        }

        [HttpGet]
        [Route("get-chat-messages")]
        public async Task<IActionResult> GetChatMessages([FromQuery] string petId)
        {
            //need to add paging
            var chatMessages = await _chatMessageService.GetChatMessagesAsync(Guid.Parse(petId));
            return Ok(chatMessages);
        }

        [HttpPost]
        [Route("send-chat-message")]
        public async Task<IActionResult> SendChatMessage([FromQuery] SendChatMessageRequest request)
        {
            await _chatMessageService.SendChatMessageAsync(request);
            return Ok();
        }
    }
}
