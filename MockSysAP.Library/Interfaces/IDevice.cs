namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes a device.
    /// </summary>
    public interface IDevice
    {
        /// <summary>
        /// The channel display name.
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// The room to which the channel is mapped.
        /// </summary>
        string? Room { get; }

        /// <summary>
        /// The floor to which the channel is mapped.
        /// </summary>
        string? Floor { get; }

        /// <summary>
        /// The device interface.
        /// </summary>
        string? Interface { get; }

        /// <summary>
        /// The device's native identifier.
        /// </summary>
        string? NativeID { get; }

        /// <summary>
        /// The channel identified by a string key.
        /// </summary>
        IDictionary<string, IChannel>? Channels { get; }
    }
}
