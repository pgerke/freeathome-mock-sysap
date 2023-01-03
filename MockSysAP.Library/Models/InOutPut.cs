using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes an input or output.
    /// </summary>
    [Serializable]
    public sealed class InOutPut : IInOutPut
    {
        /// <inheritdoc/>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <inheritdoc/>
        [JsonProperty("pairingID")]
        public int PairingID { get; set; }

        /// <summary>
        /// Constructs a new <see cref="InOutPut"/> instance.
        /// </summary>
        [JsonConstructor]
        public InOutPut() : this(string.Empty, 0)
        {
        }

        /// <summary>
        /// Constructs a new <see cref="InOutPut"/> instance using the specified values.
        /// </summary>
        /// <param name="pairingID">The pairing ID.</param>
        /// <param name="value">The input or output value.</param>
        public InOutPut(string value, int pairingID)
        {
            Value = value;
            PairingID = pairingID;
        }
    }
}
