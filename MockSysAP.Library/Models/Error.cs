using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;

namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Models
{
    /// <summary>
    /// Describes an error.
    /// </summary>
    [Serializable]
    public sealed class Error : IError
    {
        /// <inheritdoc/>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <inheritdoc/>
        [JsonProperty("detail")]
        public string Detail { get; set; }

        /// <inheritdoc/>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Constructs a new <see cref="Error"/> instance.
        /// </summary>
        [JsonConstructor]
        public Error() : this(string.Empty, string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// Constructs a new <see cref="Error"/> instance using the specified parameters.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="detail">The error detail.</param>
        /// <param name="title">The error title.</param>
        public Error(string code, string detail, string title)
        {
            Code = code;
            Detail = detail;
            Title = title;
        }
    }
}
