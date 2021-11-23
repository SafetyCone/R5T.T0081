using System;


namespace R5T.T0081
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ConfigurationSourceActionAggregationIncrement : IConfigurationSourceActionAggregationIncrement
    {
        #region Static
        
        public static ConfigurationSourceActionAggregationIncrement Instance { get; } = new();

        #endregion
    }
}