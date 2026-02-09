using System;

using Microsoft.Extensions.Logging.Abstractions;

using F10Y.T0003;


namespace F10Y.L0035
{
    [ValuesMarker]
    public partial interface ILoggers
    {
        /// <summary>
        /// The null logger. (<see cref="NullLogger.Instance"/>)
        /// </summary>
        NullLogger Null => NullLogger.Instance;
    }
}
