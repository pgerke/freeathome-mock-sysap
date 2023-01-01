using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.WebSockets;
using System.Text;

namespace MockSysAP.Web.Controllers
{
    public sealed class WebSocketController : ControllerBase
    {
        [HttpGet]
        [Route("fhapi/v1/api/ws")]
        public async Task Get()
        {
            if(HttpContext.WebSockets.IsWebSocketRequest)
            {
                using WebSocket webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
                while(true)
                {
                    await webSocket.SendAsync(
                        Encoding.ASCII.GetBytes($"Keep Alive - {DateTime.Now}"),
                        WebSocketMessageType.Text,
                        true,
                        CancellationToken.None);
                    await Task.Delay(30000);
                }
            }
            else
            {
                HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }
    }
}
