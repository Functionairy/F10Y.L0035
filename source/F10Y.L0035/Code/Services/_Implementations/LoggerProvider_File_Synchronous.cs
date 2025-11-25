using System;

using Microsoft.Extensions.Logging;

using F10Y.T0015;


namespace F10Y.L0035
{
    [ServiceImplementationMarker]
    public class LoggerProvider_Console_Synchronous : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            var output = new Logger_Console(categoryName);
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
                //  => None.
            }

            // Free unmanaged resources (unmanaged objects) and override a finalizer below.
            //  => None.
            // Set large fields to null.
            //  => None.

            this._Disposed = true;
        }

        ~LoggerProvider_Console_Synchronous() => this.Dispose(false);

        #endregion
    }
}