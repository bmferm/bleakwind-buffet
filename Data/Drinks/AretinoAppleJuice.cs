/*
* Author: Brittany "Chelle" Ferm
* Class name: AretinoAppleJuice.cs
* Purpose: To set properties and conditions of the Aretino Apple Juice drink
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing the Aretino Apple Juice drink.
    /// </summary>
    public class AretinoAppleJuice : Drink
    {
        /* Private variable declaration for the drink */
        //private Size _size = Size.Small; // Size Small is set as the default size of drink.

        /// <value>
        /// Price of the drink based on the size.
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <value>
        /// Calories of the drink based on size.
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <value>
        /// If drink is served with ice.
        /// </value>
        public bool Ice { get; set; }

        /// <value>
        /// List of special instructions for preparing the drink.
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Returns description of the drink.
        /// </summary>
        /// <returns>A string describing the drink.</returns>
        /// <remarks>Overrides default ToString method.</remarks>
        public override string ToString()
        {
            return Size + " " + "Aretino Apple Juice";
        }
    }
}
