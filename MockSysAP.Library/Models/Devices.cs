using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes a list of Devices identified by their serial.
    /// </summary>
    [Serializable]
    public sealed class Devices : Dictionary<Guid, Device>, IDevices<Device>
    {
    }
}
