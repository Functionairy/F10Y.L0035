using System;

using Microsoft.Extensions.Logging;

using F10Y.T0004;


namespace F10Y.L0035.L000
{
    /// <summary>
    /// Logger base implementation that handles boilerplate operations, leaving only the actual message writing up to descendants.
    /// </summary>
    /// <remarks>
    /// See also: R5T.L0017.T002.
    /// </remarks>
    [UtilityTypeMarker]
    public abstract class LoggerBase : ILogger
    {
        protected string CategoryName { get; }


        protected LoggerBase(
            string categoryName)
        {
            this.CategoryName = categoryName;
        }

        public IDisposable BeginScope<TState>(TState state)
            // For now, don't support scopes.
            => Instances.Disposables.Empty;

        public bool IsEnabled(LogLevel logLevel)
        {
            // Since the overall logging infrastructure will handle actually obeying filtering rules, this logger can just report true.
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            // Perform basic boilerplate operations.

            if (!this.IsEnabled(logLevel))
            {
                return;
            }

            var formatter_IsNull = Instances.NullOperator.Is_Null(formatter);
            if (formatter_IsNull)
            {
                throw Instances.ExceptionOperator.New_ArgumentNullException(nameof(formatter));
            }

            var message = formatter(state, exception);

            var message_Exists = Instances.StringOperator.Is_NotNullOrEmpty(message);
            var exception_Exists = Instances.NullOperator.Is_NotNull(exception);

            if (message_Exists || exception_Exists)
            {
                this.WriteMessage(logLevel, CategoryName, eventId.Id, message, exception);
            }
        }

        public abstract void WriteMessage(LogLevel logLevel, string logName, int eventId, string message, Exception exception);
    }
}
