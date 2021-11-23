using System;


namespace R5T.T0081
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ConfigurationSourceActionAggregationOperator : IConfigurationSourceActionAggregationOperator
    {
        #region Static
        
        public static ConfigurationSourceActionAggregationOperator Instance { get; } = new();

        #endregion
    }
}