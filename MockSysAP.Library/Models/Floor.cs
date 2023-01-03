using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes a building floor.
    /// </summary>
    [Serializable]
    public sealed class Floor : IFloor
    {
        /// <inheritdoc/>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <inheritdoc/>
        [JsonProperty("rooms")]
        public Dictionary<string, Room> Rooms { get; } = new Dictionary<string, Room>();

        IDictionary<string, IRoom> IFloor.Rooms => (IDictionary<string, IRoom>)Rooms;

        /// <summary>
        /// Constructs a new <see cref="Floor"/> instance.
        /// </summary>
        [JsonConstructor]
        public Floor() : this("Default Floor")
        {
        }

        /// <summary>
        /// Constructs a new <see cref="Floor"/> instance using the specified name.
        /// </summary>
        /// <param name="name">The floor name.</param>
        public Floor(string name) { Name = name; }
    }
}
