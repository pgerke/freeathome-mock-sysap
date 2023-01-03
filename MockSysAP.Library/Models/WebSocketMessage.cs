using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Represents a message that was received from the System Access Point web socket.
    /// </summary>
    [Serializable]
    public sealed class WebSocketMessage : Dictionary<Guid, WebSocketMessageContent>, IWebSocketMessage<WebSocketMessageContent>
    {
    }
}
