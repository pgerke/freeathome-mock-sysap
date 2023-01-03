using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes System Access Point configurations.
    /// </summary>
    [Serializable]
    public sealed class Configuration : Dictionary<Guid, SystemAccessPoint>, IConfiguration<SystemAccessPoint>
    {
    }
}
