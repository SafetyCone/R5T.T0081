using System;

using Microsoft.Extensions.Configuration;

using R5T.T0080;
using R5T.T0081;


namespace System
{
    public static class IConfigurationSourceActionExtensions
    {
        /// <summary>
        /// Get a do-nothing instance communicating that a configuration source is added elsewhere (perhaps later, perhaps earlier).
        /// Useful for when a dependent configuration AddXAction() method requires an <see cref="IConfigurationSourceAction{TConfigurationSource}"/> instance, but you know it will be added elsewhere (or are willing to risk the error if not) so you don't want to re-create the configuration source action instance, or don't want decided what implementation to use for the instance.
        /// </summary>
        /// <remarks>
        /// Note: there should be no reason to use this method since it is now easy to pass configuration source action instances. Still, this method is provided if needed. In that case, just ignore the obsolete warning at the call site.
        /// </remarks>
        [Obsolete("Is there no way to reorder program flow so a real service action instance or service action aggregation instance is available where required?\nIgnore if required.", false)]
        public static IConfigurationSourceAction<TConfigurationSource> AddedElsewhere<TConfigurationSource>(this IConfigurationSourceAction _)
        {
            var output = new DoNothingConfigurationSourceAction<TConfigurationSource>();
            return output;
        }

        /// <summary>
        /// Get a do-nothing instance communicating that a configuration source has already been added (in some other location).
        /// Useful for when a dependent configuration AddXAction() method requires an <see cref="IConfigurationSourceAction{TConfigurationSource}"/> instance, but you know it was already added (or are willing to risk the error if not) so you don't want to re-create the configuration source action instance, or don't want decided what implementation to use for the instance.
        /// </summary>
        /// <remarks>
        /// Note: there should be no reason to use this method since it is now easy to pass configuration source action instances. Still, this method is provided if needed. In that case, just ignore the obsolete warning at the call site.
        /// </remarks>
        [Obsolete("Is there no way to request a real service action instance or service action aggregation instance as a parameter for this call site?\nIgnore if required.", false)]
        public static IConfigurationSourceAction<TConfigurationSource> AlreadyAdded<TConfigurationSource>(this IConfigurationSourceAction _)
        {
            var output = new DoNothingConfigurationSourceAction<TConfigurationSource>();
            return output;
        }

        /// <summary>
        /// Constructor for <see cref="SingleRunConfigurationSourceAction{TConfigurationSource}"/> instances.
        /// </summary>
        public static IConfigurationSourceAction<TConfigurationSource> NewSingleRun<TConfigurationSource>(this IConfigurationSourceAction _,
            Action<IConfigurationBuilder> configurationBuilderAction)
        {
            var output = new SingleRunConfigurationSourceAction<TConfigurationSource>(configurationBuilderAction);
            return output;
        }

        /// <summary>
        /// Chooses single-run (<see cref="IConfigurationSourceActionExtensions.NewSingleRun{TConfigurationSource}(IConfigurationSourceAction, Action{IConfigurationBuilder})"/> as the default implementation for <see cref="IConfigurationSourceAction{TConfigurationSource}"/> instances.
        /// </summary>
        public static IConfigurationSourceAction<TConfigurationSource> New<TConfigurationSource>(this IConfigurationSourceAction _,
            Action<IConfigurationBuilder> configurationBuilderAction)
        {
            var output = _.NewSingleRun<TConfigurationSource>(configurationBuilderAction);
            return output;
        }
    }
}