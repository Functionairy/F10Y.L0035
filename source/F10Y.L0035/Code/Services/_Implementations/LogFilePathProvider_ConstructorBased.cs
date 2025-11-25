using System;
using System.Threading.Tasks;

using F10Y.T0015;


namespace F10Y.L0035
{
    /// <summary>
    /// Allows providing a log file path at runtime.
    /// </summary>
    [ServiceImplementationMarker]
    public class LogFilePathProvider_ConstructorBased : ILogFilePathProvider
    {
        private string LogFilePath { get; set; }


        public LogFilePathProvider_ConstructorBased(string logFilePath)
        {
            this.LogFilePath = logFilePath;
        }

        public Task<string> Get_LogFilePath()
            => Task.FromResult(this.LogFilePath);
    }
}