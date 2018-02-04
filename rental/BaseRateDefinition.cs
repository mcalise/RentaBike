using System;
using System.Collections.Generic;

namespace rental
{
    /// <summary>
    /// Base class for rate definitions. Implements the matching between rate elements and the rate definition
    /// </summary>
    public abstract class BaseRateDefinition : IRateDefinition
    {
        public BaseRateDefinition(IEnumerable<IRateElementDefinition> elementsDefinition, DatesDefinition datesDefinition)
        {
        }

        /// <summary>
        /// Given a list of rate elements returns the ones that are valid for the definiction
        /// </summary>
        /// <param name="elements">The list of elements to be checked</param>
        /// <param name="date">The rent date</param>
        /// <param name="duration">The rent duration in hours</param>
        /// <returns>If there are no valid elemets or date or duration are not valid, returns an empty list</returns>
        public IEnumerable<IRateElement> AppliesTo(IEnumerable<IRateElement> elements, DateTime date, double duration)
        {
            return null;
        }

        /// <summary>
        /// Returns a rate including the given elements
        /// </summary>
        /// <param name="elements">The list of elements to be included in the rate. They sould be included into this definition</param>
        public abstract IRate CreateRate(IEnumerable<IRateElement> elements);    
    }
}
