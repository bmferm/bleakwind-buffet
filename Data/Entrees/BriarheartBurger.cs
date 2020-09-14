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
    /// <summary>
    /// Class representing Briarheart Burger entree.
    /// </summary>
    public class BriarheartBurger : Entree
    {
        /// <value>
        /// Price of the entree item.
        /// </value>
        public override double Price => 6.32;

        /// <value>
        /// Calories of the entree item.
        /// </value>
        public override uint Calories => 743;

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
        /// If entree is prepared with mustard.
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
        /// List of special instructions for preparing the entree.
        /// </value>
        public override List<string> SpecialInstructions
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

        /// <summary>
        /// Returns description of the entree.
        /// </summary>
        /// <returns>A string describing the entree.</returns>
        /// <remarks>Overrides default ToString method.</remarks>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
