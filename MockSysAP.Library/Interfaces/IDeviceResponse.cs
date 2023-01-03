namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes the response to a device request.
    /// </summary>
    public interface IDeviceResponse : IDictionary<Guid, IDevices<IDevice>>
    {
    }
}
