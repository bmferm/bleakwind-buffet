using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    class DoubleDraugr
    {
        private double _price;
        private uint _calories;
        private List<String> _specialInstructions;
        private List<Boolean> _ingredients;

        /// <summary>
        /// Price property of entree item
        /// </summary>
        public double Price
        {
            get => _price;
            set => _price = 7.32;
        }

        /// <summary>
        /// Calories property of entree item
        /// </summary>
        public uint Calories
        {
            get => _calories;
            set => _calories = 843;
        }

        /// <summary>
        /// Special Instructions property of entree item.
        /// </summary>
        public List<String> SpecialInstructions
        {
            get => _specialInstructions;
            set => _specialInstructions = new List<String> { "Bun", "Ketchup", "Mustard", "Pickle", "Cheese", "Tomato", "Lettuce", "Mayo" };
        }

        public List<Boolean> Ingredients
        {
            get => _ingredients;
            set => _ingredients = new List<Boolean> { true, true, true, true, true, true, true, true };
        }
    }
}
