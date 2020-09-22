/*
* Author: Brittany "Chelle" Ferm
* Class name: Side.cs
* Purpose: Base class for the sides on the menu.
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Abstract base class for sides that inherits from IOrderItem.
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the side.
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the side.
        /// </summary>
        /// <value>In US Dollars.</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the side.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
