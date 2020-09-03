/*
* Author: Brittany "Chelle" Ferm
* Class name: WarriorWater.cs
* Purpose: To set properties and conditions of the Warrior Water drink
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        private Size _size = Size.Small; // default size
        /// <summary>
        /// Get the size of the drink
        /// </summary>
        public Size Size { get { return _size; } set { _size = value; } }

        /// <summary>
        /// Get the prie of the drink based on the size
        /// </summary>
        public double Price { get { return 0.00; } }

        /// <summary>
        /// Get the calories of the drink based on size
        /// </summary>
        public uint Calories { get { return 0; } }


        /// <summary>
        /// Get if there should be ice in the drink
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Get if there should be a lemon in the drink
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Set any special instructions in list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Override ToString method to print out size of drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _size +  " Warrior Water";
        }
    }
}
