using PhilipGerke.FreeAtHome.MockSysAP.Library.Enumerations;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Defines a virtual device.
    /// </summary>
    public interface IVirtualDevice
    {
        /// <summary>
        /// The virtual device type.
        /// </summary>
        VirtualDeviceType Type { get; }

        /// <summary>
        /// The virtual device properties.
        /// </summary>
        IVirtualDeviceProperties Properties { get; }
    }
}
