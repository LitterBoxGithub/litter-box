using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace LitterBox.Api.SignalR.Hubs
{
    public class LitterBoxHub : Hub
    {
        public async Task SendMessage(string user, string message)
            => await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
