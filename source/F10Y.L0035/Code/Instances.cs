using System;


namespace F10Y.L0035
{
    public static class Instances
    {
        public static L0000.IAsynchronousOperator AsynchronousOperator => L0000.AsynchronousOperator.Instance;
        public static L0000.ICharacters Characters => L0000.Characters.Instance;
        public static L0000.IEnumerationOperator EnumerationOperator => L0000.EnumerationOperator.Instance;
        public static IFilePaths FilePaths => L0035.FilePaths.Instance;
        public static ILoggerOperator LoggerOperator => L0035.LoggerOperator.Instance;
        public static ILogLevelNames LogLevelNames => L0035.LogLevelNames.Instance;
        public static ILogLevelOperator LogLevelOperator => L0035.LogLevelOperator.Instance;
        public static L0000.INullOperator NullOperator => L0000.NullOperator.Instance;
        public static IServicesOperator ServicesOperator => L0035.ServicesOperator.Instance;
        public static L0000.IStreamWriterOperator StreamWriterOperator => L0000.StreamWriterOperator.Instance;
        public static L0000.IStringOperator StringOperator => L0000.StringOperator.Instance;
    }
}