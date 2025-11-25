using System;

using F10Y.T0003;


namespace F10Y.L0035.Raw
{
    [ValuesMarker]
    public partial interface ILogLevelNames
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>none</value></para>
        /// </summary>
        string none => "none";

        /// <summary>
        /// <para><value>trce</value></para>
        /// </summary>
        string trce => "trce";

        /// <summary>
        /// <para><value>dbug</value></para>
        /// </summary>
        string dbug => "dbug";

        /// <summary>
        /// <para><value>info</value></para>
        /// </summary>
        string info => "info";

        /// <summary>
        /// <para><value>warn</value></para>
        /// </summary>
        string warn => "warn";

        /// <summary>
        /// <para><value>fail</value></para>
        /// </summary>
        string fail => "fail";

        /// <summary>
        /// <para><value>crit</value></para>
        /// </summary>
        string crit => "crit";

#pragma warning restore IDE1006 // Naming Styles
    }
}
