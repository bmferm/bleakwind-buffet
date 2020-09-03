/*
* Author: Brittany "Chelle" Ferm
* Class name: AretinoAppleJuice.cs
* Purpose: To set properties and conditions of the Aretino Apple Juice drink
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class AretinoAppleJuice
    {
        private Size _size = Size.Small; // default size
        /// <summary>
        /// Get the size of the drink
        /// </summary>
        public Size Size { get { return _size; } set { _size = value; } }

        /// <summary>
        /// Get the prie of the drink based on the size
        /// </summary>
        public double Price
        {
            get
            {
                if (_size == Size.Small) return 0.62;
                if (_size == Size.Medium) return 0.87;
                if (_size == Size.Large) return 1.01;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Get the calories of the drink based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (_size == Size.Small) return 44;
                if (_size == Size.Medium) return 88;
                if (_size == Size.Large) return 132;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Get if there should be ice in the drink
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// Set any special instructions in list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Override ToString method to print out size of drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _size + " " + "Aretino Apple Juice";
        }
    }
}
