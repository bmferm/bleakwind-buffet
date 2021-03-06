﻿/*
* Author: Brittany "Chelle" Ferm
* Class name: Entree.cs
* Purpose: Base class for the entrees on the menu.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        /// <value>In US Dollars.</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the entree.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
