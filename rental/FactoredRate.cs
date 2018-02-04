using System;
using System.Collections.Generic;

namespace rental
{
    /// <summary>
    /// Rates that are a percent of a list of sub-rates, Cost = sum of sub-rates * factor
    /// It could Implement IRateElement to allow nested discounts. 
    /// </summary>
    public class FactoredRate : IRate //, IRateElement
    {
        public FactoredRate(IEnumerable<IRate> subRates, double factor)
        {
        }

        /// <summary>
        /// Returns the cost
        /// </summary>
        /// <param name="duration">rent duration in hours</param>
        public double GetCost(double duration)
        {
            return 0;
        }
    }
}
