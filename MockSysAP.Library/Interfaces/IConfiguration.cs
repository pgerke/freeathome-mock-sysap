namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes System Access Point configurations.
    /// </summary>

    public interface IConfiguration<TSystemAccessPoint> : IDictionary<Guid, TSystemAccessPoint>
        where TSystemAccessPoint : ISystemAccessPoint
    {
    }
}
