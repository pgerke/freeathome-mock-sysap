using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes the channels affected by a triggered scene.
    /// </summary>
    [Serializable]
    public sealed class TriggeredSceneChannel : ITriggeredSceneChannel
    {
        /// <summary>
        /// The channel outputs.
        /// </summary>
        [JsonProperty("outputs")]
        public Dictionary<string, InOutPut>? Outputs { get; }

        IDictionary<string, IInOutPut>? ITriggeredSceneChannel.Outputs => (IDictionary<string, IInOutPut>?)Outputs;
    }
}
