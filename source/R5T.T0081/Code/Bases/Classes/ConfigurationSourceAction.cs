using System;


namespace R5T.T0081
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ConfigurationSourceAction : IConfigurationSourceAction
    {
        #region Static
        
        public static ConfigurationSourceAction Instance { get; } = new();

        #endregion
    }
}