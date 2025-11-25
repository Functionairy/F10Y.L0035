using System;

using Microsoft.Extensions.Logging;

using F10Y.T0015;

using F10Y.L0035.L000;


namespace F10Y.L0035
{
    [ServiceImplementationMarker]
    public class Logger_Console : LoggerBase
    {
        public Logger_Console(string categoryName)
            : base(categoryName)
        {
        }

        public override void WriteMessage(LogLevel logLevel, string logName, int eventId, string message, Exception exception)
        {
            var messageText = Instances.LoggerOperator.Get_LogMessageText(
                logLevel, logName, eventId, message, exception);

            Console.Write(messageText);
        }
    }
}