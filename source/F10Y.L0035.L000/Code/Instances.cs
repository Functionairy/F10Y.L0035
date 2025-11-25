using System;


namespace F10Y.L0035.L000
{
    public static class Instances
    {
        public static L0003.IDisposables Disposables => L0003.Disposables.Instance;
        public static L0000.IExceptionOperator ExceptionOperator => L0000.ExceptionOperator.Instance;
        public static L0000.INullOperator NullOperator => L0000.NullOperator.Instance;
        public static L0000.IStringOperator StringOperator => L0000.StringOperator.Instance;
    }
}