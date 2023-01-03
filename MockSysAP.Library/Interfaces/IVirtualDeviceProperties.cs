namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes virtual device properties.
    /// </summary>
    public interface IVirtualDeviceProperties
    {
        /// <summary>
        /// The time to live value indicates the number of seconds the System Access Point will wait for a message before it
        /// assumes the device to be unresponsive.
        /// </summary>
        string? TTL { get; }

        /// <summary>
        /// The display name for the virtual device.
        /// </summary>
        string? DisplayName { get; }
    }
}
