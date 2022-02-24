using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using test2.Data;

namespace test2.Shared
{
    public class ChatHub: Hub
    {
       public async Task SendMessage(long sitterRequestId , ChatMessage chatMessage)
        {
            await Clients.All.SendAsync("ReceiveMessage", sitterRequestId, chatMessage);
        }
    }
}
