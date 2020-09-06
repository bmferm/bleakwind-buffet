/*
* Author: Brittany "Chelle" Ferm
* Class name: ThugsTBone.cs
* Purpose: To set properties and conditions of the Thugs T-Bone entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing Thugs T-Bone entree.
    /// </summary>
    public class ThugsTBone
    {
        /// <value>
        /// Price of the entree item.
        /// </value>
        public double Price => 6.44;

        /// <value>
        /// Calories of the entree item.
        /// </value>
        public uint Calories => 982;

        /// <value>
        /// List of special instructions for preparing the entree.
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
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
            return "Thugs T-Bone";
        }
    }
}
