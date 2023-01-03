namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes a reference to the virtual device.
    /// </summary>
    public interface IVirtualDeviceReference
    {
        /// <summary>
        /// The device serial.
        /// </summary>
        string Serial { get; }
    }
}
