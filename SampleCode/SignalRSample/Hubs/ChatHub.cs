using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRSample.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            message += $", connection id: {Context.ConnectionId}";
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", user, message);
        }
    }
}
