using Newtonsoft.Json;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Models;

namespace PhilipGerke.FreeAtHome.MockSysAP.Web.Services
{
    /// <summary>
    /// The implementation of the System Access Point service.
    /// </summary>
    public sealed class SystemAccessPointService : ISystemAccessPointService<SystemAccessPoint>
    {
        /// <summary>
        /// Gets the current System Acess Point configuration.
        /// </summary>
        public Configuration Configuration { get; }

        IConfiguration<SystemAccessPoint> ISystemAccessPointService<SystemAccessPoint>.Configuration => Configuration;

        /// <summary>
        /// Gets the current device list.
        /// </summary>
        public Dictionary<Guid, string[]> DeviceList => new Dictionary<Guid, string[]>
        { { Guid.Empty, Configuration[Guid.Empty].Devices.Keys.ToArray() } };

        IDictionary<Guid, string[]> ISystemAccessPointService<SystemAccessPoint>.DeviceList => DeviceList;


        /// <summary>
        /// Constructs a new <see cref="SystemAccessPointService"/> instance.
        /// </summary>
        public SystemAccessPointService()
        {
            using StreamReader streamReader = File.OpenText(
                Path.Join(Directory.GetCurrentDirectory(), "data", "configuration.json"));
            using JsonReader jsonReader = new JsonTextReader(streamReader);
            Configuration = Extensions.Serializer.Deserialize<Configuration>(jsonReader)!;
        }

        /// <summary>
        /// Gets the specified device.
        /// </summary>
        /// <param name="sysApId">The System Access Point identifier.</param>
        /// <param name="deviceSerial">The device serial.</param>
        /// <returns>The requested device or <code>null</code>, if the device was not found.</returns>
        public Device? GetDevice(Guid sysApId, string deviceSerial)
        {
            Configuration.TryGetValue(sysApId, out SystemAccessPoint? sysAp);
            if(sysAp is null)
                return null;

            sysAp.Devices.TryGetValue(deviceSerial, out Device? device);
            return device;
        }

        IDevice? ISystemAccessPointService<SystemAccessPoint>.GetDevice(Guid sysApId, string deviceSerial)
        { return GetDevice(sysApId, deviceSerial); }
    }

    /// <summary>
    /// Defines the properties and methods provided by the System Access Point service.
    /// </summary>
    public interface ISystemAccessPointService<TSystemAccessPoint> where TSystemAccessPoint : ISystemAccessPoint
    {
        /// <summary>
        /// Gets the current System Acess Point configuration.
        /// </summary>
        IConfiguration<TSystemAccessPoint> Configuration { get; }

        /// <summary>
        /// Gets the current device list.
        /// </summary>
        IDictionary<Guid, string[]> DeviceList { get; }

        /// <summary>
        /// Gets the specified device.
        /// </summary>
        /// <param name="sysApId">The System Access Point identifier.</param>
        /// <param name="deviceSerial">The device serial.</param>
        /// <returns>The requested device or <code>null</code>, if the device was not found.</returns>
        IDevice? GetDevice(Guid sysApId, string deviceSerial);
    }
}
