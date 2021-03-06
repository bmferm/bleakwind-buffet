﻿/*
* Author: Brittany "Chelle" Ferm
* Class name: VokunSalad.cs
* Purpose: To set properties and conditions of the VokunSalad side
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing Vokun Salad side.
    /// </summary>
    public class VokunSalad : Side
    {
        /* Private declaration for the side. */
        //private Size _size = Size.Small; // Size Small set to default size.

        /// <value>
        /// Price of the side based on the size.
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
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
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
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
            return Size + " Vokun Salad";
        }
    }
}
