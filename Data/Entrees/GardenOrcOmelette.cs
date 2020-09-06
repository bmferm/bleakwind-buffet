/*
* Author: Brittany "Chelle" Ferm
* Class name: GardenOrcOmelette.cs
* Purpose: To set properties and conditions of the Garden Orc Omelette entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing Garden Orc Omelette entree.
    /// </summary>
    public class GardenOrcOmelette
    {
        /// <value>
        /// Price of the entree item.
        /// </value>
        public double Price => 4.57;

        /// <value>
        /// Calories of the entree item.
        /// </value>
        public uint Calories => 404;

        /// <value>
        /// If entree is prepared with broccoli.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Broccoli { get; set; } = true;

        /// <value>
        /// If entree is prepared with mushrooms.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Mushrooms { get; set; } = true;

        /// <value>
        /// If entree is prepared with tomato.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// If entree is prepared with cheddar.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Cheddar { get; set; } = true;

        /// <value>
        /// List of special instructions for preparing the entree.
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
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
            return "Garden Orc Omelette";
        }
    }
}
