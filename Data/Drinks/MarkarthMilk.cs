/*
* Author: Brittany "Chelle" Ferm
* Class name: MarkarthMilk.cs
* Purpose: To set properties and conditions of the Markarth Milk drink
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the Markarth Milk drink.
    /// </summary>
    public class MarkarthMilk : Drink
    {
        /* Private variable declaration for the drink */
        //private Size _size = Size.Small; // Size Small set to default drink size.

        /// <value>
        /// Price of drink based on size.
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <value>
        /// Calories of drink based on size.
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <value>
        /// If ice should be prepared in drink
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
            return Size + " " + "Markarth Milk";
        }
    }
}
