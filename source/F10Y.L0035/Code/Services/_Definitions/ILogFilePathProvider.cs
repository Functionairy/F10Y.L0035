using System;
using System.Threading.Tasks;

using F10Y.T0015;



namespace F10Y.L0035
{
    [ServiceDefinitionMarker]
    public interface ILogFilePathProvider
    {
        Task<string> Get_LogFilePath();
    }
}