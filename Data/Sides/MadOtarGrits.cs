/*
* Author: Brittany "Chelle" Ferm
* Class name: MadOtarGrits.cs
* Purpose: To set properties and conditions of the Mad Otar Grits side
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing Mad Otar Grits side.
    /// </summary>
    public class MadOtarGrits : Side
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
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <value>
        /// Calories of the side based on size
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
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
            return Size + " Mad Otar Grits";
        }
    }
}
