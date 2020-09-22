/*
* Author: Brittany "Chelle" Ferm
* Class name: Menu.cs
* Purpose: Creating categorized lists of the items on the menu.
*/

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Static class that can be used to get lists of the items on the menu.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Adds an instance of each entree item to an IOrderItem typed list.
        /// </summary>
        /// <returns>List of entree options.</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();

            entreeList.Add(new BriarheartBurger());
            entreeList.Add(new DoubleDraugr());
            entreeList.Add(new GardenOrcOmelette());
            entreeList.Add(new PhillyPoacher());
            entreeList.Add(new SmokehouseSkeleton());
            entreeList.Add(new ThalmorTriple());
            entreeList.Add(new ThugsTBone());

            return entreeList;
        }

        /// <summary>
        /// Adds an instance of each side item to an IOrderItem typed list.
        /// </summary>
        /// <returns>List of side options</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sideList = new List<IOrderItem>();

            sideList.Add(new DragonbornWaffleFries() { Size = Size.Small });
            sideList.Add(new DragonbornWaffleFries() { Size = Size.Medium });
            sideList.Add(new DragonbornWaffleFries() { Size = Size.Large });
            sideList.Add(new FriedMiraak() { Size = Size.Small });
            sideList.Add(new FriedMiraak() { Size = Size.Medium });
            sideList.Add(new FriedMiraak() { Size = Size.Large });
            sideList.Add(new MadOtarGrits() { Size = Size.Small });
            sideList.Add(new MadOtarGrits() { Size = Size.Medium });
            sideList.Add(new MadOtarGrits() { Size = Size.Large });
            sideList.Add(new VokunSalad() { Size = Size.Small });
            sideList.Add(new VokunSalad() { Size = Size.Medium });
            sideList.Add(new VokunSalad() { Size = Size.Large });

            return sideList;
        }

        /// <summary>
        /// Adds instances of each drink item to an IOrderItem typed list.
        /// </summary>
        /// <returns>List of drink options</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkList = new List<IOrderItem>();

            drinkList.Add(new AretinoAppleJuice() { Size = Size.Small });
            drinkList.Add(new AretinoAppleJuice() { Size = Size.Medium });
            drinkList.Add(new AretinoAppleJuice() { Size = Size.Large });
            drinkList.Add(new CandlehearthCoffee() { Size = Size.Small });
            drinkList.Add(new CandlehearthCoffee() { Size = Size.Medium });
            drinkList.Add(new CandlehearthCoffee() { Size = Size.Large });
            drinkList.Add(new MarkarthMilk() { Size = Size.Small });
            drinkList.Add(new MarkarthMilk() { Size = Size.Medium });
            drinkList.Add(new MarkarthMilk() { Size = Size.Large });
            drinkList.Add(new WarriorWater() { Size = Size.Small });
            drinkList.Add(new WarriorWater() { Size = Size.Medium });
            drinkList.Add(new WarriorWater() { Size = Size.Large });

            drinkList.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Blackberry });
            drinkList.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Blackberry });
            drinkList.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Blackberry });
            drinkList.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Cherry });
            drinkList.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Cherry });
            drinkList.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Cherry });
            drinkList.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Grapefruit });
            drinkList.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Grapefruit });
            drinkList.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Grapefruit });
            drinkList.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Lemon });
            drinkList.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Lemon });
            drinkList.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Lemon });
            drinkList.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Peach });
            drinkList.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Peach });
            drinkList.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Peach });
            drinkList.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Watermelon });
            drinkList.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Watermelon });
            drinkList.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Watermelon });

            return drinkList;
        }

        /// <summary>
        /// Creates a IOrderItem typed list of earch item on the menu.
        /// </summary>
        /// <returns>List of all items on the menu.</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menuList = new List<IOrderItem>();

            menuList.AddRange(Entrees());
            menuList.AddRange(Sides());
            menuList.AddRange(Drinks());

            return menuList;
        }

    }
}
