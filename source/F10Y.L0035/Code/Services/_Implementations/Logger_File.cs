using System;
using System.IO;

using Microsoft.Extensions.Logging;

using F10Y.T0015;

using F10Y.L0035.L000;


namespace F10Y.L0035
{
    [ServiceImplementationMarker]
    public class Logger_File : LoggerBase
    {
        private StreamWriter Writer { get; }


        public Logger_File(
            string categoryName,
            StreamWriter writer)
            : base(categoryName)
        {
            this.Writer = writer;
        }

        public override void WriteMessage(LogLevel logLevel, string logName, int eventId, string message, Exception exception)
        {
            var messageText = Instances.LoggerOperator.Get_LogMessageText(
                logLevel, logName, eventId, message, exception);

            this.Writer.Write(messageText);
        }
    }
}