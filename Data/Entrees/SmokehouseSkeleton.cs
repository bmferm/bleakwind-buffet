/*
* Author: Brittany "Chelle" Ferm
* Class name: SmokehouseSkeleton.cs
* Purpose: To set properties and conditions of the Smokehouse Skeleton entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing Smokehouse Skeleton entree.
    /// </summary>
    public class SmokehouseSkeleton : Entree
    {
        /// <value>
        /// Price of the entree item.
        /// </value>
        public override double Price => 4.57;

        /// <value>
        /// Calories of th eentree item
        /// </summary>
        public override uint Calories => 404;

        /// <value>
        /// If entree is prepared with sausage links.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool SausageLink { get; set; } = true;

        /// <value>
        /// If entree is prepared with eggs.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Egg { get; set; } = true;

        /// <value>
        /// If entree is prepared with hash browns.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool HashBrowns { get; set; } = true;

        /// <value>
        /// If entree is prepared with pancakes.
        /// </value>
        /// <remarks>Default set to true.</remarks>
        public bool Pancake { get; set; } = true;

        /// <value>
        /// List of special instructions for preparing the entree.
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
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
            return "Smokehouse Skeleton";
        }
    }
}
