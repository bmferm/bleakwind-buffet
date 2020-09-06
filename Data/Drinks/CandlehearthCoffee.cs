/*
* Author: Brittany "Chelle" Ferm
* Class name: CandlehearthCoffee.cs
* Purpose: To set properties and conditions of the Candlehearth Coffee drink
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the Candlehearth Coffee drink.
    /// </summary>
    public class CandlehearthCoffee
    {
        /* Private variable declaration for the drink */
        private Size _size = Size.Small; // Size Small set as the default size of the drink.

        /// <value>
        /// Size of the drink.
        /// </value>
        public Size Size { 
            get { return _size; }
            set { _size = value; }
        }

        /// <value>
        /// Price of the drink based on the size.
        /// </value>
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

        /// <value>
        /// Calories of the drink based on the size.
        /// </value>
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

        /// <value>
        /// If there should be ice in the drink.
        /// </value>
        public bool Ice { get; set; }

        /// <value>
        /// If drink should be prepared as decaf.
        /// </value>
        public bool Decaf { get; set; }

        /// <value>
        /// If room should be left for cream in the cup.
        /// </value>
        public bool RoomForCream { get; set; }

        /// <value>
        /// List of special instructions for preparing the drink.
        /// </value>
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
        /// Returns description of the drink.
        /// </summary>
        /// <returns>A string describing the drink.</returns>
        /// <remarks>Overrides default ToString method.</remarks>
        public override string ToString()
        {
            if (!Decaf) return _size + " Candlehearth Coffee";
            if (Decaf) return _size + " Decaf Candlehearth Coffee";
            else throw new NotImplementedException();
        }
    }
}
