/*
* Author: Brittany "Chelle" Ferm
* Class name: WarriorWater.cs
* Purpose: To set properties and conditions of the Warrior Water drink
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the Warrior Water drink.
    /// </summary>
    public class WarriorWater : Drink
    {
        /* Private variable declaration for the drink. */
        //private Size _size = Size.Small; // Size Small set as default size.

        /// <value>
        /// Price of the drink.
        /// </value>
        /// <remarks>Default price set to $0.00 for all sizes.</remarks>
        public override double Price { get { return 0.00; } }

        /// <value>
        /// Calories of the drink based on size.
        /// </value>
        public override uint Calories { get { return 0; } }


        /// <value>
        /// If drink is prepared with ice.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Ice { get; set; } = true;

        /// <value>
        /// If drink is prepared with lemon.
        /// </value>
        public bool Lemon { get; set; }

        /// <value>
        /// List of special instructions for preparing the drink.
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
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
            return Size +  " Warrior Water";
        }
    }
}
