/*
* Author: Brittany "Chelle" Ferm
* Class name: BriarheartBurger.cs
* Purpose: To set properties and conditions of the Briarheart Burger entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class BriarheartBurger
    {
        /// <summary>
        /// Price property of entree item
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// Calories property of entree item
        /// </summary>
        public uint Calories => 743;

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
                return instructions;
            }
        }

        public bool Bun { get; set; } = true;

        public bool Ketchup { get; set; } = true;

        public bool Mustard { get; set; } = true;

        public bool Pickle { get; set; } = true;

        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Overridden default ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
