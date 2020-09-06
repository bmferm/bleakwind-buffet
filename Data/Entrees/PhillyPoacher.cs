/*
* Author: Brittany "Chelle" Ferm
* Class name: PhillyPoacher.cs
* Purpose: To set properties and conditions of the Philly Poacher entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing the Philly Poacher entree.
    /// </summary>
    public class PhillyPoacher
    {
        /// <value>
        /// Price of the entree item.
        /// </value>
        public double Price => 7.23;

        /// <value>
        /// Calories of the entree item.
        /// </value>
        public uint Calories => 784;

        /// <value>
        /// If entree is prepared with sirloin.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Sirloin { get; set; } = true;

        /// <value>
        /// If entree is prepared with onion.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Onion { get; set; } = true;

        /// <value>
        /// If entree is prepared with roll.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Roll { get; set; } = true;

        /// <value>
        /// List of special instructions for preparing the entree.
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onion");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Returns description of the entree.
        /// </summary>
        /// <returns>A string describing the entree.</returns>
        /// <remarks>Overrides default ToString method.</remarks>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
