namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes a list of Devices identified by their serial.
    /// </summary>
    public interface IDevices<TDevice> : IDictionary<Guid, TDevice> where TDevice : IDevice
    {
    }
}
