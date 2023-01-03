using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Models;
using PhilipGerke.FreeAtHome.MockSysAP.Web.Services;
using System.Net;
using System.Net.WebSockets;
using System.Text;

namespace PhilipGerke.FreeAtHome.MockSysAP.Web.Controllers
{
    /// <summary>
    /// The controller for the web socket.
    /// </summary>
    public sealed class WebSocketController : ControllerBase
    {
        private readonly IUpdateService<WebSocketMessageContent> service;

        /// <summary>
        /// Constructs a new <see cref="WebSocketController"/> instance injecting the specified services.
        /// </summary>
        /// <param name="updateService">The update service instance.</param>
        public WebSocketController(IUpdateService<WebSocketMessageContent> updateService) { service = updateService; }

        /// <summary>
        /// Provides the web socket connection endpoint.
        /// </summary>
        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("fhapi/v1/api/ws")]
        public async Task Get()
        {
            if(!HttpContext.WebSockets.IsWebSocketRequest)
            {
                HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return;
            }

            using WebSocket webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
            await Echo(webSocket);
        }

        private async Task Echo(WebSocket webSocket)
        {
            //byte[] buffer = new byte[1024 * 4];
            //CancellationTokenSource tokenSource = new(500);
            //WebSocketReceiveResult? receiveResult = null;

            //try
            //{
            //    receiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), tokenSource.Token);
            //}
            //catch(OperationCanceledException) // This is fine.
            //{
            //}

            //while((receiveResult is null) || !receiveResult.CloseStatus.HasValue)
            while(true)
            {
                await webSocket.SendAsync(
                    GetWebSocketMessage(),
                    WebSocketMessageType.Text,
                    true,
                    CancellationToken.None);

                await Task.Delay(1000);
            }

            //await webSocket.CloseAsync(
            //    receiveResult.CloseStatus.Value,
            //    receiveResult.CloseStatusDescription,
            //    CancellationToken.None);
        }

        private byte[] GetWebSocketMessage()
        {
            IWebSocketMessage<WebSocketMessageContent> message = service.GetWebSocketMessage();
            string serialized = JsonConvert.SerializeObject(message, Extensions.SerializerSettings);
            return Encoding.UTF8.GetBytes(serialized);
        }
    }
}
