using System;


namespace F10Y.L0035
{
    public class LogLevelNames : ILogLevelNames
    {
        #region Infrastructure

        public static ILogLevelNames Instance { get; } = new LogLevelNames();


        private LogLevelNames()
        {
        }

        #endregion
    }
}


namespace F10Y.L0035.Raw
{
    public class LogLevelNames : ILogLevelNames
    {
        #region Infrastructure

        public static ILogLevelNames Instance { get; } = new LogLevelNames();


        private LogLevelNames()
        {
        }

        #endregion
    }
}