using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Models;

namespace PhilipGerke.FreeAtHome.MockSysAP.Web.Services
{
    /// <summary>
    /// The implementation of the update service.
    /// </summary>
    public sealed class UpdateService : IUpdateService<WebSocketMessageContent>
    {
        /// <summary>
        /// Gets the web socket message for the current update state
        /// </summary>
        /// <returns>The generated <see cref="WebSocketMessage"/> instance.</returns>
        public WebSocketMessage GetWebSocketMessage()
        {
            WebSocketMessage message = new() { { Guid.Empty, new WebSocketMessageContent() } };
            return message;
        }

        IWebSocketMessage<WebSocketMessageContent> IUpdateService<WebSocketMessageContent>.GetWebSocketMessage()
        { return GetWebSocketMessage(); }
    }

    /// <summary>
    /// Defines the properties and methods provided by the update service.
    /// </summary>
    public interface IUpdateService<TWebSocketMessageContent> where TWebSocketMessageContent : IWebSocketMessageContent
    {
        /// <summary>
        /// Gets the web socket message for the current update state
        /// </summary>
        /// <returns>The generated web socket message.</returns>
        IWebSocketMessage<TWebSocketMessageContent> GetWebSocketMessage();
    }
}
