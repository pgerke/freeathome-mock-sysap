namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes the floor plan.
    /// </summary>
    public interface IFloorPlan
    {
        /// <summary>
        /// The floor identified by the key.
        /// </summary>
        IDictionary<string, IFloor> Floors { get; }
    }
}
