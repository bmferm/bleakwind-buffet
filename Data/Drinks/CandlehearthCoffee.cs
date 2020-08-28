/*
* Author: Brittany "Chelle" Ferm
* Class name: CandlehearthCoffee.cs
* Purpose: To set properties and conditions of the Candlehearth Coffee drink
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    class CandlehearthCoffee
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
                if (_size == Size.Small) return 0.75;
                if (_size == Size.Medium) return 1.25;
                if (_size == Size.Large) return 1.75;
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
                if (_size == Size.Small) return 7;
                if (_size == Size.Medium) return 10;
                if (_size == Size.Large) return 20;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Get if there should be ice in the drink
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// Get if drink should be decaf
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Get if room should be left for cream
        /// </summary>
        public bool RoomForCream { get; set; }

        /// <summary>
        /// Set any special instructions in list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (Decaf) instructions.Add("Make decaf");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Override ToString method to print out size and type of drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!Decaf) return _size + " Candlehearth Coffee";
            if (Decaf) return _size + " Decaf Candlehearth Coffee";
            else throw new NotImplementedException();
        }
    }
}
