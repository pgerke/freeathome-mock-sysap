namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes a virtual device response.
    /// </summary>
    public interface IVirtualDeviceResponse : IDictionary<Guid, ICreatedVirtualDevice>
    {
    }
}
