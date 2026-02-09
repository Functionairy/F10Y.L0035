using System;
using System.IO;

using Microsoft.Extensions.Logging;

using F10Y.T0015;


namespace F10Y.L0035
{
    [ServiceImplementationMarker]
    public class LoggerProvider_File_Synchronous : ILoggerProvider
    {
        #region Static

        private static void Ensure_IsSetup(LoggerProvider_File_Synchronous fileLoggerProvider)
        {
            var isSetup = Instances.NullOperator.Is_NotNull(fileLoggerProvider.Writer);
            if (!isSetup)
            {
                LoggerProvider_File_Synchronous.Perform_FirstTimeSetup(fileLoggerProvider);
            }
        }

        private static void Perform_FirstTimeSetup(LoggerProvider_File_Synchronous fileLoggerProvider)
        {
            Instances.AsynchronousOperator.Execute_Synchronously(async () =>
            {
                var logFilePath = await fileLoggerProvider.LogFilePathProvider.Get_LogFilePath();

                fileLoggerProvider.Writer = Instances.StreamWriterOperator.New_Write(logFilePath);

                // Ensure write immediately writes its content.
                fileLoggerProvider.Writer.AutoFlush = true;
            });
        }

        #endregion


        private StreamWriter Writer { get; set; }

        private ILogFilePathProvider LogFilePathProvider { get; }



        public LoggerProvider_File_Synchronous(
            ILogFilePathProvider logFilePathProvider)
        {
            this.LogFilePathProvider = logFilePathProvider;
        }


        public ILogger CreateLogger(string categoryName)
        {
            LoggerProvider_File_Synchronous.Ensure_IsSetup(this);

            var output = new Logger_File(
                categoryName,
                this.Writer);

            return output;
        }


        #region IDisposable

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Canonical dispose pattern variable name.")]
        private bool _Disposed { get; set; }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            this.Dispose(true);

            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this._Disposed)
            {
                return;
            }

            if (disposing)
            {
                // Dispose managed state (any managed objects, perhaps implementing IDispoable themselves).
                this.Writer?.Dispose();
            }

            // Free unmanaged resources (unmanaged objects) and override a finalizer below.
            //  => None.
            // Set large fields to null.
            //  => None.

            this._Disposed = true;
        }

        ~LoggerProvider_File_Synchronous() => this.Dispose(false);

        #endregion
    }
}