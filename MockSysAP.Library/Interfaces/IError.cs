namespace PhilipGerke.FreeAtHome.MockSysAP.Library.Interfaces
{
    /// <summary>
    /// Describes an error.
    /// </summary>
    public interface IError
    {
        /// <summary>
        /// The error code
        /// </summary>
        /// <example>2010</example>
        string Code { get; }

        /// <summary>
        /// A detailed message describing the error
        /// </summary>
        /// <example>FreeAtHome connection timeout</example>
        string Detail { get; }

        /// <summary>
        /// The title for the error
        /// </summary>
        /// <example>Connection Error</example>
        string Title { get; }
    }
}
