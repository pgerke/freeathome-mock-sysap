namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes the ScenesTriggered object that is included in the web socket message.
    /// </summary>
    public interface IScenesTriggered : IDictionary<Guid, ITriggeredScene>
    {
    }

    /// <summary>
    /// Describes the triggered scene.
    /// </summary>
    public interface ITriggeredScene
    {
        /// <summary>
        /// The channels.
        /// </summary>
        IDictionary<string, ITriggeredSceneChannel> Channels { get; }
    }

    /// <summary>
    /// Describes the channels affected by a triggered scene.
    /// </summary>
    public interface ITriggeredSceneChannel
    {
        /// <summary>
        /// The channel outputs.
        /// </summary>
        IDictionary<string, IInOutPut>? Outputs { get; }
    }
}
