using System;


namespace F10Y.L0035
{
    public class LoggerOperator : ILoggerOperator
    {
        #region Infrastructure

        public static ILoggerOperator Instance { get; } = new LoggerOperator();


        private LoggerOperator()
        {
        }

        #endregion
    }
}
