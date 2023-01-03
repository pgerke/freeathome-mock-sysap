using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// The message content for a web socket message.
    /// </summary>
    [Serializable]
    public sealed class WebSocketMessageContent : IWebSocketMessageContent
    {
        /// <summary>
        /// The data points.
        /// </summary>
        [JsonProperty("datapoints")]
        public Dictionary<string, string> DataPoints { get; } = new Dictionary<string, string>();

        IDictionary<string, string> IWebSocketMessageContent.DataPoints => DataPoints;

        /// <summary>
        /// The devices.
        /// </summary>
        [JsonProperty("devices")]
        public Dictionary<string, Devices> Devices { get; } = new Dictionary<string, Devices>();

        IDictionary<string, IDevices<IDevice>> IWebSocketMessageContent.Devices => (IDictionary<string, IDevices<IDevice>>)Devices;

        /// <summary>
        /// The array of device serials representing the devices added to the System Access Point.
        /// </summary>
        [JsonProperty("devicesAdded")]
        public string[] DevicesAdded { get; set; } = Array.Empty<string>();

        /// <summary>
        /// The array of device serials representing the devices removed from the System Access Point.
        /// </summary>
        [JsonProperty("devicesRemoved")]
        public string[] DevicesRemoved { get; set; } = Array.Empty<string>();

        /// <summary>
        /// The triggered scenes.
        /// </summary>
        [JsonProperty("scenesTriggered")]
        public Dictionary<Guid, TriggeredScene> ScenesTriggered { get; } = new();

        IScenesTriggered IWebSocketMessageContent.ScenesTriggered => (IScenesTriggered)ScenesTriggered;
    }
}
