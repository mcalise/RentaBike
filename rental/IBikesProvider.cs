using System;
using System.Collections.Generic;

namespace rental
{
    /// <summary>
    /// Bikes provider, it could be implemented to read the bikes from a database or as a mock for testing purposes
    /// </summary>
    public interface IBikesProvider
    {
        /// <summary>
        /// Returns all bikes
        /// </summary>
        IEnumerable<Bike> GetAllBikes();
    }
}
