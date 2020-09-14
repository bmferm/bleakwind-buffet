using System;
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater drink = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(drink);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater drink = new WarriorWater();
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater drink = new WarriorWater();
            Assert.False(drink.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater drink = new WarriorWater();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater drink = new WarriorWater();
            drink.Ice = true;
            Assert.True(drink.Ice);
            drink.Ice = false;
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater drink = new WarriorWater();
            drink.Size = Size.Large;
            Assert.Equal(Size.Large, drink.Size);
            drink.Size = Size.Medium;
            Assert.Equal(Size.Medium, drink.Size);
            drink.Size = Size.Small;
            Assert.Equal(Size.Small, drink.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater drink = new WarriorWater()
            {
                Size = size
            };
            Assert.Equal(price, drink.Price);

        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater drink = new WarriorWater()
            {
                Size = size
            };
            Assert.Equal(cal, drink.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater drink = new WarriorWater()
            {
                Ice = includeIce,
                Lemon = includeLemon
            };
            if (!includeIce) Assert.Contains("Hold ice", drink.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", drink.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            string expectedName = "";

            if (size == Size.Small) expectedName = "Small Warrior Water";
            if (size == Size.Medium) expectedName = "Medium Warrior Water";
            if (size == Size.Large) expectedName = "Large Warrior Water";

            Assert.Equal(expectedName, name);
        }
    }
}
