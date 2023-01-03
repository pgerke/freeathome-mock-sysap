using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes a System Access Point user.
    /// </summary>
    [Serializable]
    public sealed class User : IUser
    {
        /// <inheritdoc/>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <inheritdoc/>
        [JsonProperty("flags")]
        public string[] Flags { get; set; } = Array.Empty<string>();

        /// <inheritdoc/>
        [JsonProperty("grantedPermissions")]
        public string[] GrantedPermissions { get; set; } = Array.Empty<string>();

        /// <inheritdoc/>
        [JsonProperty("jid")]
        public string JID { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <inheritdoc/>
        [JsonProperty("requestedPermissions")]
        public string[] RequestedPermissions { get; set; } = Array.Empty<string>();

        /// <inheritdoc/>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// Constructs a new <see cref="User"/> instance.
        /// </summary>
        [JsonConstructor]
        public User() : this(string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// Constructs a new <see cref="User"/> instance using the specified name and role.
        /// </summary>
        /// <param name="name">The name of the new user.</param>
        /// <param name="role">The role of the new user.</param>
        public User(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}
