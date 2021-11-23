using System;


namespace R5T.T0081
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ConfigurationSourceActionAggregation : IConfigurationSourceActionAggregation
    {
        #region Static
        
        public static ConfigurationSourceActionAggregation Instance { get; } = new();

        #endregion
    }
}