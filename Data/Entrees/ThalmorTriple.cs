/*
* Author: Brittany "Chelle" Ferm
* Class name: ThalmorTriple.cs
* Purpose: To set properties and conditions of the Thalmor Triple entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing Thalmor Triple entree.
    /// </summary>
    public class ThalmorTriple
    {
        /// <value>
        /// Price of the entree item.
        /// </value>
        public double Price => 8.32;

        /// <value>
        /// Calories of the entree item.
        /// </value>
        public uint Calories => 943;

        /// <value>
        /// If entree is prepared with bun.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Bun { get; set; } = true;

        /// <value>
        /// If entree is prepared with ketchup.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Ketchup { get; set; } = true;

        /// <value>
        /// If entree is prepared with nustard.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Mustard { get; set; } = true;

        /// <value>
        /// If entree is prepared with pickle.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Pickle { get; set; } = true;

        /// <value>
        /// If entree is prepared with cheese.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Cheese { get; set; } = true;

        /// <value>
        /// If entree is prepared with tomato.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// If entree is prepared with lettuce.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Lettuce { get; set; } = true;

        /// <value>
        /// If entree is prepared with mayo.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Mayo { get; set; } = true;

        /// <value>
        /// If entree is prepared with bacon.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Bacon { get; set; } = true;

        /// <value>
        /// If entree is prepared with egg.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Egg { get; set; } = true;

        /// <value>
        /// List of special instructions for preparing the entree.
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
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
            return "Thalmor Triple";
        }
    }
}
