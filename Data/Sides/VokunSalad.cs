/*
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
    public class VokunSalad
    {
        /* Private declaration for the side. */
        private Size _size = Size.Small; // Size Small set to default size.

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
                if (_size == Size.Small) return 0.93;
                if (_size == Size.Medium) return 1.28;
                if (_size == Size.Large) return 1.82;
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
                if (_size == Size.Small) return 41;
                if (_size == Size.Medium) return 52;
                if (_size == Size.Large) return 73;
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
            return _size + " Vokun Salad";
        }
    }
}
