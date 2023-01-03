namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes a free@home System Access Point.
    /// </summary>
    public interface ISystemAccessPoint
    {
        /// <summary>
        /// The devices connected to the System Access Point.
        /// </summary>
        IDictionary<string, IDevice> Devices { get; }

        /// <summary>
        /// The floor plan.
        /// </summary>
        IFloorPlan FloorPlan { get; }

        /// <summary>
        /// The name of the System Access Point.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The users.
        /// </summary>
        IDictionary<string, IUser> Users { get; }

        /// <summary>
        /// An error, if an error is reported by the system access point.
        /// </summary>
        IError? Error { get; }
    }
}
