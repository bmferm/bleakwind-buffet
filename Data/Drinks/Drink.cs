﻿/*
* Author: Brittany "Chelle" Ferm
* Class name: Drink.cs
* Purpose: Base class for the drinks on the menu.
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks.
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The size of the drink.
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the drink.
        /// </summary>
        /// <value>In US Dollars.</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the drink.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
