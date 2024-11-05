using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using NotificationsAPI.Hubs;

namespace NotificationsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public NotificationsController(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> PostNotification([FromBody] string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", message);
            return Ok(new { Message = "Notification sent" });
        }
    }
}
