using System;
namespace rental
{
    /// <summary>
    /// Represents a bike.
    /// Implements IRateElement because it will part of rates. 
    /// </summary>
    public class Bike : IRateElement 
    {
        public Bike()
        {
        }

        // Add all bike properties like the bike brand, gears kind, etc.
        ////

        /// <summary>
        /// Returns the definition for this element, i.e. Category A Bike
        /// </summary>
        public IRateElementDefinition GetElementDefinition()
        {
            return null;
        }
    }
}
