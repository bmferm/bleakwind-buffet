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
    public class FriedMiraak : Side
    {
        /* Private variable declaration for the side. */
        //private Size _size = Size.Small; // Size Small set as default size.

        /// <value>
        /// Price of the side based on the size.
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <value>
        /// Calories of the side based on size.
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <value>
        /// List of special instructions for preparing the entree.
        /// </value>
        /// <remarks>Special Instructions set to empty list.</remarks>
        public override List<string> SpecialInstructions
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
            return Size + " Fried Miraak";
        }
    }
}
