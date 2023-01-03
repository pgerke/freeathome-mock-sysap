namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes a device channel
    /// </summary>
    public interface IChannel
    {
        /// <summary>
        /// The channel display name.
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// The function identifier.
        /// </summary>
        string FunctionID { get; }

        /// <summary>
        /// The room to which the channel is mapped.
        /// </summary>
        string? Room { get; }

        /// <summary>
        /// The floor to which the channel is mapped.
        /// </summary>
        string? Floor { get; }

        /// <summary>
        /// The inputs provided by the channel.
        /// </summary>
        IDictionary<string, IInOutPut>? Inputs { get; }

        /// <summary>
        /// The output provided by the channel.
        /// </summary>
        IDictionary<string, IInOutPut>? Outputs { get; }

        /// <summary>
        /// The channel type.
        /// </summary>
        string? Type { get; }
    }
}
