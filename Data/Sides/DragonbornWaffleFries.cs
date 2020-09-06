/*
* Author: Brittany "Chelle" Ferm
* Class name: DragonbornWaffleFries.cs
* Purpose: To set properties and conditions of the Dragonborn Waffle Fries side
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing Dragonborn Waffle Fries side.
    /// </summary>
    public class DragonbornWaffleFries
    {
        /* Private variable declaration for the side. */
        private Size _size = Size.Small; // Size Small set as default size.

        /// <value>
        /// Size of the side.
        /// </value>
        public Size Size {
            get { return _size; }
            set { _size = value; }
        }

        /// <value>
        /// Price of the side based on the size.
        /// </value>
        public double Price
        {
            get
            {
                if (_size == Size.Small) return 0.42;
                if (_size == Size.Medium) return 0.76;
                if (_size == Size.Large) return 0.96;
                else throw new NotImplementedException();
            }
        }

        /// <value>
        /// Calories of the side based on size.
        /// </value>
        public uint Calories
        {
            get
            {
                if (_size == Size.Small) return 77;
                if (_size == Size.Medium) return 89;
                if (_size == Size.Large) return 100;
                else throw new NotImplementedException();
            }
        }

        /// <value>
        /// List of special instructions for preparing the entree.
        /// </value>
        /// <remarks>Special Instructions set as an empty list.</remarks>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Returns description of the side.
        /// </summary>
        /// <returns>A string describing the side.</returns>
        /// <remarks>Overrides default ToString method.</remarks>
        public override string ToString()
        {
            return _size + " Dragonborn Waffle Fries";
        }
    }
}
