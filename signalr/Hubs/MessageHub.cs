using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace signalr {
    public class MessageHub: Hub {
        public Task Send(string message) {
            return Clients.All.InvokeAsync("Send", message);
        }
    }
}