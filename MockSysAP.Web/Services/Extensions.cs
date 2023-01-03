using Newtonsoft.Json;

namespace PhilipGerke.FreeAtHome.MockSysAP.Web.Services
{
    /// <summary>
    /// The service extension methods.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// The common JSON serializer settings
        /// </summary>
        public static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
        };

        /// <summary>
        /// The common JsonSerializer instance.
        /// </summary>
        public static readonly JsonSerializer Serializer = JsonSerializer.Create(SerializerSettings);
    }
}
