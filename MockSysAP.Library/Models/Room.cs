using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes a room.
    /// </summary>
    [Serializable]
    public sealed class Room : IRoom
    {
        /// <inheritdoc/>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Constructs a new <see cref="Room"/> instance.
        /// </summary>
        [JsonConstructor]
        public Room() : this("Default Room")
        {
        }

        /// <summary>
        /// Constructs a new <see cref="Room"/> instance using the specified name.
        /// </summary>
        /// <param name="name">The room name.</param>
        public Room(string name) { Name = name; }
    }
}
