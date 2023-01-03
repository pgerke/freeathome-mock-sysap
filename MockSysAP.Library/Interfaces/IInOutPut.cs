namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes an input or output.
    /// </summary>
    public interface IInOutPut
    {
        /// <summary>
        /// The input or output value.
        /// </summary>
        string Value { get; }

        /// <summary>
        /// The pairing ID.
        /// </summary>
        int PairingID { get; }
    }
}
