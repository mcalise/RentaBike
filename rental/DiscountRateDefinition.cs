using System;
using System.Collections.Generic;

namespace rental
{
    /// <summary>
    /// Represents a rate definition for discounts, i.e. Five Category A bikes for a week
    /// </summary>
    public class DiscountRateDefinition : BaseRateDefinition
    {
        public DiscountRateDefinition(IEnumerable<IRateElementDefinition> elementsDefinition, DatesDefinition datesDefinition) : base(elementsDefinition, datesDefinition)
        {
        }

        /// <summary>
        /// Returns a rate including the given elements
        /// </summary>
        /// <param name="elements">The list of elements to be included in the rate. They sould be included into this definition</param>
        /// <returns>A FactoredRate instance</returns>
        public override IRate CreateRate(IEnumerable<IRateElement> elements)
        {
            return null;
        }
    }
}
