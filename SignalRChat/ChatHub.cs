using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChat.Server
{
    class ChatHub : Hub
    {
        //Metodo que va a enviar y recibir mensajes
        public async Task SendMessage(string user, string message)
        {
            await Client.All.SendAsync("Receivessage", user, message);
        }
    }
}
