/*
* Author: Brittany "Chelle" Ferm
* Class name: SailorSoda.cs
* Purpose: To set properties and conditions of the Sailor Soda drink
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing Sailor Soda drink.
    /// </summary>
    public class SailorSoda
    {
        /* Private variable declaration for the drink. */
        private Size _size = Size.Small; // Size Small set as default size.
        private SodaFlavor _flavor = SodaFlavor.Cherry; // Flavor Cherry set as default cherry.

        /// <value>
        /// Size of the drink.
        /// </value>
        public Size Size { get { return _size; } set { _size = value; } }

        /// <value>
        /// Price of the drink based on the size.
        /// </value>
        public double Price
        {
            get 
            {
                if (_size == Size.Small) return 1.42;
                if (_size == Size.Medium) return 1.74;
                if (_size == Size.Large) return 2.07;
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
                if (_size == Size.Small) return 117;
                if (_size == Size.Medium) return 153;
                if (_size == Size.Large) return 205;
                else throw new NotImplementedException();
            }
        }

        /// <value>
        /// If drink should be prepared with Ice.
        /// </value>
        /// <remarks>Default overridden as true.</remarks>
        public bool Ice { get; set; } = true;

        /// <value>
        /// Flavor of the drink.
        /// </value>
        public SodaFlavor Flavor
        {
            get { return _flavor; }
            set { _flavor = value; }
        }

        /// <value>
        /// List of special instructions for preparing the drink.
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
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
            return _size + " " + _flavor + " " + "Sailor Soda";
        }
    }
}
