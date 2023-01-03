namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes a response to a request setting a new value for a data point.
    /// </summary>
    public interface ISetDataPointResponse : IDictionary<Guid, IDictionary<string, string>>
    {
    }
}
