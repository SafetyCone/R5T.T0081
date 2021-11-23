using System;


namespace R5T.T0081
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ConfigurationSourceActionAggregationIncrementOperator : IConfigurationSourceActionAggregationIncrementOperator
    {
        #region Static
        
        public static ConfigurationSourceActionAggregationIncrementOperator Instance { get; } = new();

        #endregion
    }
}