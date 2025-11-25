using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using F10Y.T0016;


namespace F10Y.L0035
{
    public static partial class IServiceCollectionExtensions
    {
        /// <inheritdoc cref="IServicesOperator.Add_LogFilePathProvider_ConstructorBased(IServiceCollection, string, out ServiceToken{ILogFilePathProvider})"/>
        public static IServiceCollection Add_LogFilePathProvider_ConstructorBased(this IServiceCollection services,
            string logFilePath,
            out ServiceToken<ILogFilePathProvider> logFilePathProvider_Token)
        {
            Instances.ServicesOperator.Add_LogFilePathProvider_ConstructorBased(
                services,
                logFilePath,
                out logFilePathProvider_Token);

            return services;
        }

        /// <inheritdoc cref="IServicesOperator.Add_LogFilePathProvider_HardCoded(IServiceCollection, out ServiceToken{ILogFilePathProvider})"/>
        public static IServiceCollection Add_LogFilePathProvider_HardCoded(this IServiceCollection services,
            out ServiceToken<ILogFilePathProvider> logFilePathProvider_Token)
        {
            Instances.ServicesOperator.Add_LogFilePathProvider_HardCoded(
                services,
                out logFilePathProvider_Token);

            return services;
        }

        /// <inheritdoc cref="IServicesOperator.Add_LoggerProvider_Console_Synchronous(IServiceCollection, out ServiceToken{ILoggerProvider})"/>
        public static IServiceCollection Add_LoggerProvider_Console_Synchronous(this IServiceCollection services,
            out ServiceToken<ILoggerProvider> loggerProvider_Console_Token)
        {
            Instances.ServicesOperator.Add_LoggerProvider_Console_Synchronous(
                services,
                out loggerProvider_Console_Token);

            return services;
        }

        /// <inheritdoc cref="IServicesOperator.Add_LoggerProvider_File_Synchronous(IServiceCollection, out ServiceToken{ILoggerProvider}, ServiceToken{ILogFilePathProvider})"/>
        public static IServiceCollection Add_LoggerProvider_File_Synchronous(this IServiceCollection services,
            out ServiceToken<ILoggerProvider> loggerProvider_File_Token,
            ServiceToken<ILogFilePathProvider> logFilePathProvider_Token)
        {
            Instances.ServicesOperator.Add_LoggerProvider_File_Synchronous(
                services,
                out loggerProvider_File_Token,
                logFilePathProvider_Token);

            return services;
        }
    }
}
