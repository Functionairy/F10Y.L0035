using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0035
{
    [ValuesMarker]
    public partial interface ILogLevelNames
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        Raw.ILogLevelNames _Raw => Raw.LogLevelNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.ILogLevelNames.none"/>
        public string None => _Raw.none;

        /// <inheritdoc cref="Raw.ILogLevelNames.trce"/>
        public string Trace_Short => _Raw.trce;

        /// <inheritdoc cref="Raw.ILogLevelNames.dbug"/>
        public string Debug_Short => _Raw.dbug;

        /// <inheritdoc cref="Raw.ILogLevelNames.info"/>
        public string Information_Short => _Raw.info;

        /// <inheritdoc cref="Raw.ILogLevelNames.warn"/>
        public string Warning_Short => _Raw.warn;

        /// <inheritdoc cref="Raw.ILogLevelNames.fail"/>
        public string Error_Short => _Raw.fail;

        /// <inheritdoc cref="Raw.ILogLevelNames.crit"/>
        public string Critical_Short => _Raw.crit;
    }
}
