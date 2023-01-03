namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes a building floor.
    /// </summary>
    public interface IFloor
    {
        /// <summary>
        /// The floor name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The room names on the floor identified by the floor key.
        /// </summary>
        IDictionary<string, IRoom> Rooms { get; }
    }
}
