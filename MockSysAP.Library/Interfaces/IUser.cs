namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes a System Access Point user.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Determines whether or not the user account is enabled.
        /// </summary>
        bool Enabled { get; }

        /// <summary>
        /// An array of flags for the user account.
        /// </summary>
        string[] Flags { get; }

        /// <summary>
        /// An array of the permissions granted to the user.
        /// </summary>
        string[] GrantedPermissions { get; }

        /// <summary>
        /// The user's JID.
        /// </summary>
        string JID { get; }

        /// <summary>
        /// The users name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The array of the permissions requested by the user.
        /// </summary>
        string[] RequestedPermissions { get; }

        /// <summary>
        /// The user's role.
        /// </summary>
        string Role { get; }
    }
}
