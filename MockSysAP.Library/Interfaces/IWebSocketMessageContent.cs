namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// The message content for a web socket message.
    /// </summary>
    public interface IWebSocketMessageContent
    {
        /// <summary>
        /// The data points.
        /// </summary>
        IDictionary<string, string> DataPoints { get; }

        /// <summary>
        /// The devices.
        /// </summary>
        IDictionary<string, IDevices<IDevice>> Devices { get; }

        /// <summary>
        /// The array of device serials representing the devices added to the System Access Point.
        /// </summary>
        string[] DevicesAdded { get; }

        /// <summary>
        /// The array of device serials representing the devices removed from the System Access Point.
        /// </summary>
        string[] DevicesRemoved { get; }

        /// <summary>
        /// The triggered scenes.
        /// </summary>
        IScenesTriggered ScenesTriggered { get; }
    }
}
