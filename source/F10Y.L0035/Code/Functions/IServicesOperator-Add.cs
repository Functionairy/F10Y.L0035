using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using F10Y.T0002;
using F10Y.T0016;


namespace F10Y.L0035
{
    [FunctionsMarker]
    public partial interface IServicesOperator
    {
        /// <inheritdoc cref="LogFilePathProvider_HardCoded"/>
        void Add_LogFilePathProvider_ConstructorBased(
            IServiceCollection services,
            string logFilePath,
            out ServiceToken<ILogFilePathProvider> logFilePathProvider_Token)
        {
            services.AddSingleton<ILogFilePathProvider>(_ =>
            {
                var output = new LogFilePathProvider_ConstructorBased(logFilePath);
                return output;
            });
        }

        /// <inheritdoc cref="LogFilePathProvider_HardCoded"/>
        void Add_LogFilePathProvider_HardCoded(
            IServiceCollection services,
            out ServiceToken<ILogFilePathProvider> logFilePathProvider_Token)
        {
            services.AddSingleton<ILogFilePathProvider, LogFilePathProvider_HardCoded>();
        }

        /// <inheritdoc cref="LoggerProvider_Console_Synchronous"/>
        void Add_LoggerProvider_Console_Synchronous(
            IServiceCollection services,
            out ServiceToken<ILoggerProvider> loggerProvider_Console_Token)
        {
            services.AddSingleton<ILoggerProvider, LoggerProvider_Console_Synchronous>();
        }

        /// <inheritdoc cref="LoggerProvider_File_Synchronous"/>
        void Add_LoggerProvider_File_Synchronous(
            IServiceCollection services,
            out ServiceToken<ILoggerProvider> loggerProvider_File_Token,
            ServiceToken<ILogFilePathProvider> logFilePathProvider_Token)
        {
            services.AddSingleton<ILoggerProvider, LoggerProvider_File_Synchronous>();
        }
    }
}
