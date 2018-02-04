using System;
namespace rental
{
    /// <summary>
    /// Represents a dates definition, i.e. all Mondays for less than 12 hours. 
    /// </summary>
    public class DatesDefinition
    {
        public DatesDefinition()
        {
        }

        /// <summary>
        /// Returns true if the rent date and rent duration are valid according to this definition
        /// </summary>
        /// <param name="date">The rent date</param>
        /// <param name="duration">The rent duration in hours</param>
        public bool isValid(DateTime date, double duration)
        {
            return false;
        }
    }
}
