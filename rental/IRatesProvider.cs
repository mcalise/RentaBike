using System;
using System.Collections.Generic;

namespace rental
{
    /// <summary>
    /// Rate definitions provider, it could be implemented to read the rates definitions from a database or as a mock for testing purposes
    /// </summary>
    public interface IRatesProvider
    {
        /// <summary>
        /// Returns all flat rates
        /// </summary>
        IEnumerable<IRateDefinition> GetAllFlatRates();

        /// <summary>
        /// Returns all discounts
        /// </summary>
        IEnumerable<IRateDefinition> GetAllDiscounts();
    }
}
