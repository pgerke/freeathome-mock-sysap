using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes the floor plan.
    /// </summary>
    [Serializable]
    public sealed class FloorPlan : IFloorPlan
    {
        /// <inheritdoc/>
        [JsonProperty("floors")]
        public Dictionary<string, Floor> Floors { get; } = new Dictionary<string, Floor>();

        IDictionary<string, IFloor> IFloorPlan.Floors => (IDictionary<string, IFloor>)Floors;
    }
}
