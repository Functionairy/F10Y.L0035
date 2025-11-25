using System;

using F10Y.T0003;


namespace F10Y.L0035
{
    [ValuesMarker]
    public partial interface IFilePaths
    {
        /// <summary>
        /// <para><value>C:\Temp\Log.txt</value></para>
        /// </summary>
        string LogFilePath_Default => @"C:\Temp\Log.txt";
    }
}
