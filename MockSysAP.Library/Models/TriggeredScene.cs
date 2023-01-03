using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes the triggered scene.
    /// </summary>
    [Serializable]
    public sealed class TriggeredScene : ITriggeredScene
    {
        /// <summary>
        /// The channels.
        /// </summary>
        [JsonProperty("channels")]
        public Dictionary<string, TriggeredSceneChannel> Channels { get; } = new();

        IDictionary<string, ITriggeredSceneChannel> ITriggeredScene.Channels => (IDictionary<string, ITriggeredSceneChannel>)Channels;
    }
}
