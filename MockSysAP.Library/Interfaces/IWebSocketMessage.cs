namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Represents a message that was received from the System Access Point web socket.
    /// </summary>
    public interface IWebSocketMessage<TWebSocketMessageContent> : IDictionary<Guid, TWebSocketMessageContent>
        where TWebSocketMessageContent : IWebSocketMessageContent
    {
    }
}
