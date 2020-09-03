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
    class GardenOrcOmelette
    {
        /// <summary>
        /// Price property of entree item
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Calories property of entree item
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Special Instructions property of entree item.
        /// </summary>
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

        public bool Broccoli { get; set; } = true;

        public bool Mushrooms { get; set; } = true;

        public bool Tomato { get; set; } = true;

        public bool Cheddar { get; set; } = true;


        /// <summary>
        /// Overridden default ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
