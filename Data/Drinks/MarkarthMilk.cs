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
    public class MarkarthMilk
    {
        /* Private variable declaration for the drink */
        private Size _size = Size.Small; // Size Small set to default drink size.

        /// <value>
        /// Size of the drink.
        /// </value>
        public Size Size { get { return _size; } set { _size = value; } }

        /// <value>
        /// Price of drink based on size.
        /// </value>
        public double Price
        {
            get
            {
                if (_size == Size.Small) return 1.05;
                if (_size == Size.Medium) return 1.11;
                if (_size == Size.Large) return 1.22;
                else throw new NotImplementedException();
            }
        }

        /// <value>
        /// Calories of drink based on size.
        /// </value>
        public uint Calories
        {
            get
            {
                if (_size == Size.Small) return 56;
                if (_size == Size.Medium) return 72;
                if (_size == Size.Large) return 93;
                else throw new NotImplementedException();
            }
        }

        /// <value>
        /// If ice should be prepared in drink
        /// </value>
        public bool Ice { get; set; }

        /// <value>
        /// List of special instructions for preparing the drink.
        /// </value>
        public List<string> SpecialInstructions
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
            return _size + " " + "Markarth Milk";
        }
    }
}
