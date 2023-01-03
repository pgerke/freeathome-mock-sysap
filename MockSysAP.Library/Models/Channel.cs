using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes a device channel.
    /// </summary>
    [Serializable]
    public sealed class Channel : IChannel
    {
        /// <inheritdoc/>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <inheritdoc/>
        [JsonProperty("functionID")]
        public string FunctionID { get; set; }

        /// <inheritdoc/>
        [JsonProperty("room")]
        public string? Room { get; set; }

        /// <inheritdoc/>
        [JsonProperty("floor")]
        public string? Floor { get; set; }

        /// <inheritdoc/>
        [JsonProperty("inputs")]
        public Dictionary<string, InOutPut>? Inputs { get; set; }

        IDictionary<string, IInOutPut>? IChannel.Inputs => (IDictionary<string, IInOutPut>?)Inputs;

        /// <inheritdoc/>
        [JsonProperty("outputs")]
        public Dictionary<string, InOutPut>? Outputs { get; set; }

        IDictionary<string, IInOutPut>? IChannel.Outputs => (IDictionary<string, IInOutPut>?)Outputs;

        /// <inheritdoc/>
        [JsonProperty("type")]

        public string? Type { get; set; }

        /// <summary>
        /// Constructs a new <see cref="Channel"/> instance.
        /// </summary>
        [JsonConstructor]
        public Channel() : this(string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// Constructs a new <see cref="Channel"/> instance with the specified values.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="functionID">The function ID.</param>
        public Channel(string displayName, string functionID)
        {
            DisplayName = displayName;
            FunctionID = functionID;
        }
    }
}
