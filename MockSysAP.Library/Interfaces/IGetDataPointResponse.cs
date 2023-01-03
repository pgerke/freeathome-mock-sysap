namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes the response to a query requesting a data point.
    /// </summary>
    public interface IGetDataPointResponse : IDictionary<Guid, string[]>
    {
    }
}
