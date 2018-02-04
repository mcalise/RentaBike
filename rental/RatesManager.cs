using System;
using System.Collections.Generic;

namespace rental
{
    /// <summary>
    /// Provides functionality to calculate rates, i.e. for a three bikes list calculate the best price 
    /// </summary>
    public class RatesManager
    {
        private readonly IRatesProvider m_ratesProvider;

        public RatesManager(IRatesProvider ratesProvider)
        {
            m_ratesProvider = ratesProvider;
        }

        /// <summary>
        /// Given a list of rate elements returns the best price
        /// </summary>
        /// <param name="elements">The list of elements to be included in the price</param>
        /// <param name="date">The rent date</param>
        /// <param name="duration">The rent duration in hours</param>
        public IRate GetBestRate(IEnumerable<IRateElement> elements, DateTime date, double duration)
        {
            return null;
        }
    }
}
