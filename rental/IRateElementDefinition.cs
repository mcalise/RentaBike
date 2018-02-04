namespace rental
{
    /// <summary>
    /// Represents an element definition, i.e. Category A Bike or a discount type 
    /// </summary>
    public interface IRateElementDefinition
    {
        /// <summary>
        /// Returns true if the definitions are the same
        /// </summary>
        /// <param name="other">definition to be compared</param>
        bool IsSameDefinition(IRateElementDefinition other);
    }
}
