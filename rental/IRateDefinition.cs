using System;
using System.Collections.Generic;

namespace rental
{
    /// <summary>
    /// A definition for a rate, i.e two BikeCategoryA and one BikeCategoryB on weekends
    /// </summary>
    public interface IRateDefinition
    {
        /// <summary>
        /// Given a list of rate elements returns the ones that are valid for the definiction
        /// </summary>
        /// <param name="elements">The list of elements to be checked</param>
        /// <param name="date">The rent date</param>
        /// <param name="duration">The rent duration in hours</param>
        /// <returns>If there are no valid elemets or date or duration are not valid, returns an empty list</returns>
        IEnumerable<IRateElement> AppliesTo(IEnumerable<IRateElement> elements, DateTime date, double duration);

        /// <summary>
        /// Returns a rate including the given elements
        /// </summary>
        /// <param name="elements">The list of elements to be included in the rate. They sould be included into this definition</param>
        IRate CreateRate(IEnumerable<IRateElement> elements);
    }
}