/*
* Author: Brittany "Chelle" Ferm
* Class name: FriedMiraak.cs
* Purpose: To set properties and conditions of the Fried Miraak side
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing Fried Miraak side.
    /// </summary>
    public class FriedMiraak
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
                if (_size == Size.Small) return 1.78;
                if (_size == Size.Medium) return 2.01;
                if (_size == Size.Large) return 2.88;
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
                if (_size == Size.Small) return 151;
                if (_size == Size.Medium) return 236;
                if (_size == Size.Large) return 306;
                else throw new NotImplementedException();
            }
        }

        /// <value>
        /// List of special instructions for preparing the entree.
        /// </value>
        /// <remarks>Special Instructions set to empty list.</remarks>
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
            return _size + " Fried Miraak";
        }
    }
}
