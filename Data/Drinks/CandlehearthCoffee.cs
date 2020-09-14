/*
* Author: Brittany "Chelle" Ferm
* Class name: CandlehearthCoffee.cs
* Purpose: To set properties and conditions of the Candlehearth Coffee drink
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the Candlehearth Coffee drink.
    /// </summary>
    public class CandlehearthCoffee : Drink
    {
        /* Private variable declaration for the drink */
        //private Size _size = Size.Small; // Size Small set as the default size of the drink.

        /// <value>
        /// Size of the drink.
        /// </value>
 
        /// <value>
        /// Price of the drink based on the size.
        /// </value>
        /// <exception cref="NotImplementedException"></exception>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <value>
        /// Calories of the drink based on the size.
        /// </value>
        /// <exception cref="NotImplementedException"></exception>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <value>
        /// If there should be ice in the drink.
        /// </value>
        public bool Ice { get; set; }

        /// <value>
        /// If drink should be prepared as decaf.
        /// </value>
        public bool Decaf { get; set; }

        /// <value>
        /// If room should be left for cream in the cup.
        /// </value>
        public bool RoomForCream { get; set; }

        /// <value>
        /// List of special instructions for preparing the drink.
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (Decaf) instructions.Add("Make decaf");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Returns description of the drink.
        /// </summary>
        /// <returns>A string describing the drink.</returns>
        /// <exception cref="NotImplementedException"></exception>
        /// <remarks>Overrides default ToString method.</remarks>
        public override string ToString()
        {
            if (!Decaf) return Size + " Candlehearth Coffee";
            if (Decaf) return Size + " Decaf Candlehearth Coffee";
            else throw new NotImplementedException();
        }
    }
}
