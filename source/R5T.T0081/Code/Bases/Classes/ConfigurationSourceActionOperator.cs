using System;


namespace R5T.T0081
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ConfigurationSourceActionOperator : IConfigurationSourceActionOperator
    {
        #region Static
        
        public static ConfigurationSourceActionOperator Instance { get; } = new();

        #endregion
    }
}