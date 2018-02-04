using System;
using System.Collections.Generic;

namespace rental
{
    /// <summary>
    /// Represents a rate definition for flat rates, i.e. A Category A bike for less than 12 hours
    /// Implements IRateElement because it will part of rates
    /// </summary>
    public class FlatRateDefinition : BaseRateDefinition
    {
        public FlatRateDefinition(IEnumerable<IRateElementDefinition> elementsDefinition, DatesDefinition datesDefinition) : base(elementsDefinition, datesDefinition)
        {
        }

        /// <summary>
        /// Returns a rate including the given elements
        /// </summary>
        /// <param name="elements">The list of elements to be included in the rate. They sould be included into this definition</param>
        /// <returns>A FlatRate instance</returns>
        public override IRate CreateRate(IEnumerable<IRateElement> elements)
        {
            return null;
        }
    }
}
