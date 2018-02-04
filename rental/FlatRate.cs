using System;
namespace rental
{
    /// <summary>
    /// Rates depending on rent duration only, Cost = CostByHour * duration
    /// Implements IRateElement because it will part of discounts. 
    /// </summary>
    public class FlatRate : IRate, IRateElement
    {
        public FlatRate(double costByHour)
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

        /// <summary>
        /// Returns the definition for this element, i.e. Rate for Category A Bikes
        /// </summary>
        public IRateElementDefinition GetElementDefinition()
        {
            return null;
        }
    }
}
