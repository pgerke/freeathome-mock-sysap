namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes a created virtual device.
    /// </summary>
    public interface ICreatedVirtualDevice
    {
        /// <summary>
        /// The created device identified by the key.
        /// </summary>
        IDictionary<string, IVirtualDeviceReference> Devices { get; }
    }
}
