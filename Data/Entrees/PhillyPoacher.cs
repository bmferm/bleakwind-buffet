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
    class PhillyPoacher
    {
        /// <summary>
        /// Price property of entree item
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Calories property of entree item
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Special Instructions property of entree item.
        /// </summary>
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

        public bool Sirloin { get; set; } = true;

        public bool Onion { get; set; } = true;

        public bool Roll { get; set; } = true;

        /// <summary>
        /// Overridden default ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
