﻿/*
 * Author: Zachery Brunner
 * Edited By: Brittany "Chelle" Ferm
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(drink);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            drink.Ice = true;
            Assert.True(drink.Ice);
            drink.Ice = false;
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            drink.Size = Size.Large;
            Assert.Equal(Size.Large, drink.Size);
            drink.Size = Size.Medium;
            Assert.Equal(Size.Medium, drink.Size);
            drink.Size = Size.Small;
            Assert.Equal(Size.Small, drink.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice drink = new AretinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(price, drink.Price);

        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice drink = new AretinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(cal, drink.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice drink = new AretinoAppleJuice()
            {
                Ice = includeIce
            };
            if (includeIce) Assert.Contains("Add ice", drink.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            string expectedName = "";

            if (size == Size.Small) expectedName = "Small Aretino Apple Juice";
            if (size == Size.Medium) expectedName = "Medium Aretino Apple Juice";
            if (size == Size.Large) expectedName = "Large Aretino Apple Juice";

            Assert.Equal(expectedName, name);
        }
    }
}