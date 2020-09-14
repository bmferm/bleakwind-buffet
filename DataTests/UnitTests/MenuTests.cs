using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void EntreesShouldBeAssignableToIOrderItemInterface()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(b);

            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(d);

            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(g);

            PhillyPoacher p = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(p);

            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(s);

            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);

            ThugsTBone ttb = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(ttb);

        }

        [Fact]
        public void SidesShouldBeAssignableToIOrderItemInterface()
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(d);

            FriedMiraak f = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(f);

            MadOtarGrits m = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(m);

            VokunSalad v = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(v);
        }

        [Fact]
        public void DrinksShouldBeAssignableToIOrderItemInterface()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(a);

            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(c);

            MarkarthMilk m = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(m);

            SailorSoda s = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(s);

            WarriorWater w = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(w);
        }

        [Fact]
        public void EntreesShouldBeAssignableToBaseClass()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(b);

            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(d);

            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(g);

            PhillyPoacher p = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(p);

            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(s);

            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);

            ThugsTBone ttb = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(ttb);
        }

        [Fact]
        public void SidesSHouldBeAssignableToBaseClass()
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(d);

            FriedMiraak f = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(f);

            MadOtarGrits m = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(m);

            VokunSalad v = new VokunSalad();
            Assert.IsAssignableFrom<Side>(v);
        }

        [Fact]
        public void DrinksShouldBeAssignableToBaseClass()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(a);

            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(c);

            MarkarthMilk m = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(m);

            SailorSoda s = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(s);

            WarriorWater w = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(w);
        }

        [Fact]
        public void EntreesShouldReturnAllEntrees()
        {
            Assert.Collection<IOrderItem>(Menu.Entrees(),
                    item => Assert.Equal("Briarheart Burger", item.ToString()),
                    item => Assert.Equal("Double Draugr", item.ToString()),
                    item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                    item => Assert.Equal("Philly Poacher", item.ToString()),
                    item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                    item => Assert.Equal("Thalmor Triple", item.ToString()),
                    item => Assert.Equal("Thugs T-Bone", item.ToString())
                );
        }

        [Fact]
        public void SidesShouldReturnAllSides()
        {
            Assert.Collection<IOrderItem>(Menu.Sides(),
                    item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                    item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                    item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                    item => Assert.Equal("Small Fried Miraak", item.ToString()),
                    item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                    item => Assert.Equal("Large Fried Miraak", item.ToString()),
                    item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                    item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                    item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                    item => Assert.Equal("Small Vokun Salad", item.ToString()),
                    item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                    item => Assert.Equal("Large Vokun Salad", item.ToString())
                );
        }

        [Fact]
        public void DrinksShouldReturnAllDrinks()
        {
            Assert.Collection<IOrderItem>(Menu.Drinks(),
                    item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                    item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                    item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                    item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                    item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                    item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                    item => Assert.Equal("Small Markarth Milk", item.ToString()),
                    item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                    item => Assert.Equal("Large Markarth Milk", item.ToString()),
                    item => Assert.Equal("Small Warrior Water", item.ToString()),
                    item => Assert.Equal("Medium Warrior Water", item.ToString()),
                    item => Assert.Equal("Large Warrior Water", item.ToString()),

                    item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                    item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                    item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                    item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString())
            );

        }

        [Fact]
        public void FullMenuShouldReturnAllMenuItems()
        {
            Assert.Collection<IOrderItem>(Menu.FullMenu(),
                    item => Assert.Equal("Briarheart Burger", item.ToString()),
                    item => Assert.Equal("Double Draugr", item.ToString()),
                    item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                    item => Assert.Equal("Philly Poacher", item.ToString()),
                    item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                    item => Assert.Equal("Thalmor Triple", item.ToString()),
                    item => Assert.Equal("Thugs T-Bone", item.ToString()),

                    item => Assert.Equal("Small Dragonborn Waffle Fries", item. ToString()),
                    item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                    item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                    item => Assert.Equal("Small Fried Miraak", item.ToString()),
                    item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                    item => Assert.Equal("Large Fried Miraak", item.ToString()),
                    item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                    item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                    item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                    item => Assert.Equal("Small Vokun Salad", item.ToString()),
                    item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                    item => Assert.Equal("Large Vokun Salad", item.ToString()),

                    item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                    item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                    item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                    item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                    item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                    item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                    item => Assert.Equal("Small Markarth Milk", item.ToString()),
                    item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                    item => Assert.Equal("Large Markarth Milk", item.ToString()),
                    item => Assert.Equal("Small Warrior Water", item.ToString()),
                    item => Assert.Equal("Medium Warrior Water", item.ToString()),
                    item => Assert.Equal("Large Warrior Water", item.ToString()),

                    item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                    item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                    item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                    item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                    item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                    item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                    item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString())
                );
        }
    }
}
