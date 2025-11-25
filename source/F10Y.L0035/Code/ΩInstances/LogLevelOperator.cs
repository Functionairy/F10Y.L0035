using System;


namespace F10Y.L0035
{
    public class LogLevelOperator : ILogLevelOperator
    {
        #region Infrastructure

        public static ILogLevelOperator Instance { get; } = new LogLevelOperator();


        private LogLevelOperator()
        {
        }

        #endregion
    }
}
