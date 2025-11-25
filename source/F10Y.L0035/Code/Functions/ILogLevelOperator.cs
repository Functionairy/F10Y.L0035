using System;

using Microsoft.Extensions.Logging;

using F10Y.T0002;


namespace F10Y.L0035
{
    [FunctionsMarker]
    public partial interface ILogLevelOperator
    {
        string Get_LogLevelName_Short(LogLevel logLevel)
        {
            var output = logLevel switch
            {
                LogLevel.Trace => Instances.LogLevelNames.Trace_Short,
                LogLevel.Debug => Instances.LogLevelNames.Debug_Short,
                LogLevel.Information => Instances.LogLevelNames.Information_Short,
                LogLevel.Warning => Instances.LogLevelNames.Warning_Short,
                LogLevel.Error => Instances.LogLevelNames.Error_Short,
                LogLevel.Critical => Instances.LogLevelNames.Critical_Short,
                _ => throw Instances.EnumerationOperator.Get_DefaultCaseException(logLevel),
            };

            return output;
        }
    }
}
