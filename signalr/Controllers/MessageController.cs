using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace signalr {
    [Route("api/message")]
    public class MessageController: Controller {
        private IHubContext<MessageHub> _messageHubContext;

        public MessageController(IHubContext<MessageHub> messageHubContext) {
            _messageHubContext = messageHubContext;
        }

        public IActionResult Post () {
            _messageHubContext.Clients.All.InvokeAsync("send", "Hello from the server");
            return Ok();
        }
    }
}