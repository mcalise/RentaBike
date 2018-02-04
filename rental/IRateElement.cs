namespace rental
{
    /// <summary>
    /// Represents elements that can be part of a rate, i.e. a bike 
    /// </summary>
    public interface IRateElement
    {
        /// <summary>
        /// Returns the definition for this element, i.e. Category A Bike
        /// </summary>
        IRateElementDefinition GetElementDefinition();
    }
}