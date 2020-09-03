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
    public class SmokehouseSkeleton
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
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        public bool SausageLink { get; set; } = true;

        public bool Egg { get; set; } = true;

        public bool HashBrowns { get; set; } = true;

        public bool Pancake { get; set; } = true;


        /// <summary>
        /// Overridden default ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
