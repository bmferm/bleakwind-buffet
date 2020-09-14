/*
 * Author: Zachery Brunner
 * Edited By: Brittany "Chelle" Ferm
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee drink = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(drink);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee drink = new CandlehearthCoffee();
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee drink = new CandlehearthCoffee();
            Assert.False(drink.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee drink = new CandlehearthCoffee();
            Assert.False(drink.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee drink = new CandlehearthCoffee();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee drink = new CandlehearthCoffee();
            drink.Ice = true;
            Assert.True(drink.Ice);
            drink.Ice = false;
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee drink = new CandlehearthCoffee();
            drink.Decaf = true;
            Assert.True(drink.Decaf);
            drink.Decaf = false;
            Assert.False(drink.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee drink = new CandlehearthCoffee();
            drink.RoomForCream = true;
            Assert.True(drink.RoomForCream);
            drink.Ice = false;
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee drink = new CandlehearthCoffee();
            drink.Size = Size.Large;
            Assert.Equal(Size.Large, drink.Size);
            drink.Size = Size.Medium;
            Assert.Equal(Size.Medium, drink.Size);
            drink.Size = Size.Small;
            Assert.Equal(Size.Small, drink.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee drink = new CandlehearthCoffee()
            {
                Size = size
            };
            Assert.Equal(price, drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee drink = new CandlehearthCoffee()
            {
                Size = size
            };
            Assert.Equal(cal, drink.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(true, false, true)]
        [InlineData(false, true, false)]
        [InlineData(false, false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream, bool makeDecaf)
        {
            CandlehearthCoffee drink = new CandlehearthCoffee()
            {
                Ice = includeIce,
                RoomForCream = includeCream,
                Decaf = makeDecaf
            };

            if (includeIce) Assert.Contains("Add ice", drink.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", drink.SpecialInstructions);
            if (makeDecaf) Assert.Contains("Make decaf", drink.SpecialInstructions);

        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            string expectedSize = "";
            string expectedDecaf = "";

            if (size == Size.Small) expectedSize = "Small ";
            if (size == Size.Medium) expectedSize = "Medium ";
            if (size == Size.Large) expectedSize = "Large ";

            if (decaf) expectedDecaf = "Decaf ";

            string expectedName = expectedSize + expectedDecaf + "Candlehearth Coffee";

            Assert.Equal(expectedName, name);
        }
    }
}
