/*
* Author: Brittany "Chelle" Ferm
* Class name: ThalmorTriple.cs
* Purpose: To set properties and conditions of the Thalmor Triple entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    class ThalmorTriple
    {
        /// <summary>
        /// Price property of entree item
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Calories property of entree item
        /// </summary>
        public uint Calories => 943;

        /// <summary>
        /// Special Instructions property of entree item.
        /// </summary>
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

        public bool Bun { get; set; } = true;

        public bool Ketchup { get; set; } = true;

        public bool Mustard { get; set; } = true;

        public bool Pickle { get; set; } = true;

        public bool Cheese { get; set; } = true;

        public bool Tomato { get; set; } = true;

        public bool Lettuce { get; set; } = true;

        public bool Mayo { get; set; } = true;

        public bool Bacon { get; set; } = true;

        public bool Egg { get; set; } = true;

        /// <summary>
        /// Overridden default ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
