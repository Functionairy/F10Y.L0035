using System;
using System.Text;

using Microsoft.Extensions.Logging;

using F10Y.Extensions;
using F10Y.T0002;


namespace F10Y.L0035
{
    [FunctionsMarker]
    public partial interface ILoggerOperator
    {
        void Append_LogMessageText_WithoutLogLevel(
            StringBuilder logBuilder,
            string logName, int eventId, string message, Exception exception)
        {
            // Category and Event ID. Example:
            //
            // INFO: ConsoleApp.Program[10]
            //       Request received

            var logLevelPadding = ": ";

            logBuilder.Append(logLevelPadding)
                .Append(logName)
                .Append(Instances.Characters.OpenBracket)
                .Append(eventId)
                .Append(Instances.Characters.CloseBracket)
                .AppendLine()
                ;

            // Message
            if (Instances.StringOperator.Is_NotNullOrEmpty(message))
            {
                var messageTabinationCount = 6;
                var messageTabination = new String(Instances.Characters.Space, messageTabinationCount);

                logBuilder.Append(messageTabination);

                // Indent all new lines in the message.
                var length = logBuilder.Length;

                logBuilder.AppendLine(message);
                logBuilder.Replace(Environment.NewLine, Environment.NewLine + messageTabination, length, message.Length);
            }

            // Exception message. Example:
            //
            // System.InvalidOperationException
            //    at Namespace.Class.Function() in File:line X

            if (exception != null)
            {
                logBuilder.AppendLine(exception.ToString());
            }
        }

        void Append_LogMessageText_WithLogLevel(
            StringBuilder logBuilder,
            LogLevel logLevel, string logName, int eventId, string message, Exception exception)
        {
            var logLevelString = Instances.LogLevelOperator.Get_LogLevelName_Short(logLevel);

            logBuilder.Append(logLevelString);

            this.Append_LogMessageText_WithoutLogLevel(logBuilder,
                logName, eventId, message, exception);
        }

        string Get_LogMessageTextWithLogLevel(LogLevel logLevel, string logName, int eventId, string message, Exception exception)
        {
            var output = new StringBuilder()
                .Get_String(logBuilder =>
                {
                    this.Append_LogMessageText_WithLogLevel(logBuilder,
                        logLevel, logName, eventId, message, exception);
                });

            return output;
        }

        /// <summary>
        /// Chooses <see cref="Get_LogMessageTextWithLogLevel(LogLevel, string, int, string, Exception)"/> as the default.
        /// </summary>
        string Get_LogMessageText(LogLevel logLevel, string logName, int eventId, string message, Exception exception)
        {
            var output = this.Get_LogMessageTextWithLogLevel(logLevel, logName, eventId, message, exception);
            return output;
        }
    }
}
