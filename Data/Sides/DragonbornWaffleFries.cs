using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    class DragonbornWaffleFries
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
                if (_size == Size.Small) return 0.42;
                if (_size == Size.Medium) return 0.76;
                if (_size == Size.Large) return 0.96;
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
                if (_size == Size.Small) return 77;
                if (_size == Size.Medium) return 89;
                if (_size == Size.Large) return 100;
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
        /// Override ToString method to print out size and flavor of drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _size + " Dragonborn Waffle Fries";
        }
    }
}
