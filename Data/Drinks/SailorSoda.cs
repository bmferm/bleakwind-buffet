using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    class SailorSoda
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
                if (_size == Size.Small) return 1.42;
                if (_size == Size.Medium) return 1.74;
                if (_size == Size.Large) return 2.07;
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
                if (_size == Size.Small) return 117;
                if (_size == Size.Medium) return 153;
                if (_size == Size.Large) return 205;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Get if there should be ice in the drink
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Set any special instructions in list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        private SodaFlavor _flavor = SodaFlavor.Cherry; // default flavor
        /// <summary>
        /// Get the flavor of the drink
        /// </summary>
        public SodaFlavor Flavor { get { return _flavor; } set { _flavor = value; } }

        /// <summary>
        /// Override ToString method to print out size and flavor of drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _size + " " + _flavor + " " + "Sailor Soda";
        }
    }
}
