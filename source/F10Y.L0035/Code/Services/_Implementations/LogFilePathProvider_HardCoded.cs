using System;
using System.Threading.Tasks;

using F10Y.T0015;


namespace F10Y.L0035
{
    /// <summary>
    /// Uses the hard-coded <inheritdoc cref="IFilePaths.LogFilePath_Default" path="descendant::value"/> (<see cref="IFilePaths.LogFilePath_Default"/>) file path value.
    /// </summary>
    [ServiceImplementationMarker]
    public class LogFilePathProvider_HardCoded : ILogFilePathProvider
    {
        public LogFilePathProvider_HardCoded()
        {
        }

        public Task<string> Get_LogFilePath()
        {
            var output = Instances.FilePaths.LogFilePath_Default;

            return Task.FromResult(output);
        }
    }
}