using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    class ThugsTBone
    {
        /// <summary>
        /// Price property of entree item
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// Calories property of entree item
        /// </summary>
        public uint Calories => 982;

        /// <summary>
        /// Special Instructions property of entree item.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }



        /// <summary>
        /// Overridden default ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
