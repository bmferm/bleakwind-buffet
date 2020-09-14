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
    public class SailorSoda : Drink
    {
        /* Private variable declaration for the drink. */
        //private Size _size = Size.Small; // Size Small set as default size.
        private SodaFlavor _flavor = SodaFlavor.Cherry; // Flavor Cherry set as default cherry.

        /// <value>
        /// Price of the drink based on the size.
        /// </value>
        public override  double Price
        {
            get 
            {
                switch (Size)
                {
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
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
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException();
                }
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
        public override List<string> SpecialInstructions
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
            return Size + " " + Flavor + " " + "Sailor Soda";
        }
    }
}
