/*
* Author: Brittany "Chelle" Ferm
* Class name: AretinoAppleJuice.cs
* Purpose: To set properties and conditions of the Aretino Apple Juice drink
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing the Aretino Apple Juice drink.
    /// </summary>
    public class AretinoAppleJuice
    {
        /* Private variable declaration for the drink */
        private Size _size = Size.Small; // Size Small is set as the default size of drink.

        /// <value>
        /// Get the size of the drink.
        /// </value>
        public Size Size { 
            get { return _size; } 
            set { _size = value; }
        }

        /// <value>
        /// Price of the drink based on the size.
        /// </value>
        public double Price
        {
            get
            {
                if (_size == Size.Small) return 0.62;
                if (_size == Size.Medium) return 0.87;
                if (_size == Size.Large) return 1.01;
                else throw new NotImplementedException();
            }
        }

        /// <value>
        /// Calories of the drink based on size.
        /// </value>
        public uint Calories
        {
            get
            {
                if (_size == Size.Small) return 44;
                if (_size == Size.Medium) return 88;
                if (_size == Size.Large) return 132;
                else throw new NotImplementedException();
            }
        }

        /// <value>
        /// If drink is served with ice.
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
            return _size + " " + "Aretino Apple Juice";
        }
    }
}
