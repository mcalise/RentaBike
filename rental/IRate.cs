namespace rental
{
    /// <summary>
    /// Represents the rate for a set of IRateElement
    /// </summary>
    public interface IRate
    {
        /// <summary>
        /// Returns the cost
        /// </summary>
        /// <param name="duration">rent duration in hours</param>
        double GetCost(double duration);
    }
}