using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes a system access point.
    /// </summary>
    [Serializable]
    public sealed class SystemAccessPoint : ISystemAccessPoint
    {
        /// <inheritdoc/>        
        [JsonProperty("devices")]
        public Dictionary<string, Device> Devices { get; } = new Dictionary<string, Device>();

        IDictionary<string, IDevice> ISystemAccessPoint.Devices => (IDictionary<string, IDevice>)Devices;

        /// <inheritdoc/>
        [JsonProperty("floorplan")]
        public FloorPlan FloorPlan { get; } = new FloorPlan();

        IFloorPlan ISystemAccessPoint.FloorPlan => FloorPlan;

        /// <inheritdoc/>
        [JsonProperty("sysapName")]
        public string Name { get; set; } = "Mock System Access Point";

        /// <inheritdoc/>
        [JsonProperty("users")]
        private IDictionary<string, User> Users { get; } = new Dictionary<string, User>();

        IDictionary<string, IUser> ISystemAccessPoint.Users => (IDictionary<string, IUser>)Users;

        /// <inheritdoc/>
        [JsonProperty("error")]
        public Error? Error { get; set; }

        IError? ISystemAccessPoint.Error => Error;
    }
}
