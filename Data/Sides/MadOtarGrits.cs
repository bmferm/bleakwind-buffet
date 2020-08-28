/*
* Author: Brittany "Chelle" Ferm
* Class name: MadOtarGrits.cs
* Purpose: To set properties and conditions of the Mad Otar Grits side
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    class MadOtarGrits
    {
        private Size _size = Size.Small; // default size
        /// <summary>
        /// Get the size of the side
        /// </summary>
        public Size Size { get { return _size; } set { _size = value; } }

        /// <summary>
        /// Get the prie of the side based on the size
        /// </summary>
        public double Price
        {
            get
            {
                if (_size == Size.Small) return 1.22;
                if (_size == Size.Medium) return 1.58;
                if (_size == Size.Large) return 1.93;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Get the calories of the side based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (_size == Size.Small) return 105;
                if (_size == Size.Medium) return 142;
                if (_size == Size.Large) return 179;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Set any special instructions in list
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
        /// Override ToString method to print out size of side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _size + " Mad Otar Grits";
        }
    }
}
