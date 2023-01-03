using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes a device.
    /// </summary>
    [Serializable]
    public sealed class Device : IDevice
    {
        /// <inheritdoc/>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <inheritdoc/>
        [JsonProperty("room")]
        public string? Room { get; set; }

        /// <inheritdoc/>
        [JsonProperty("floor")]
        public string? Floor { get; set; }

        /// <inheritdoc/>
        [JsonProperty("interface")]
        public string? Interface { get; set; }

        /// <inheritdoc/>
        [JsonProperty("nativeId")]
        public string? NativeID { get; set; }

        /// <inheritdoc/>
        [JsonProperty("channels")]
        public Dictionary<string, Channel>? Channels { get; set; }

        IDictionary<string, IChannel>? IDevice.Channels => (IDictionary<string, IChannel>?)Channels;

        /// <summary>
        /// Constructs a new <see cref="Device"/> instance.
        /// </summary>
        [JsonConstructor]
        public Device() : this(string.Empty)
        {
        }

        /// <summary>
        /// Constructs a new <see cref="Device"/> instance using the specified values.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        public Device(string displayName) { DisplayName = displayName; }
    }
}
