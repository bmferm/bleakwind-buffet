/*
 * Author: Zachery Brunner
 * Edited By: Brittany "Chelle" Ferm
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda drink = new SailorSoda();
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda drink = new SailorSoda();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda drink = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, drink.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda drink = new SailorSoda();
            drink.Ice = false;
            Assert.False(drink.Ice);
            drink.Ice = true;
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda drink = new SailorSoda();
            drink.Size = Size.Large;
            Assert.Equal(Size.Large, drink.Size);
            drink.Size = Size.Medium;
            Assert.Equal(Size.Medium, drink.Size);
            drink.Size = Size.Small;
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda drink = new SailorSoda();
            drink.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, drink.Flavor);
            drink.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, drink.Flavor);
            drink.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, drink.Flavor);
            drink.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, drink.Flavor);
            drink.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, drink.Flavor);
            drink.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, drink.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda drink = new SailorSoda()
            {
                Size = size
            };
            Assert.Equal(price, drink.Price);
        }
    

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda drink = new SailorSoda()
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
            SailorSoda drink = new SailorSoda()
            {
                Ice = includeIce
            };
            if (!includeIce) Assert.Contains("Hold ice", drink.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            string expectedFlavor = "", expectedSize = "", expectedName = "";

            SailorSoda drink = new SailorSoda()
            {
                Flavor = flavor,
                Size = size
            };

            if (size == Size.Small) expectedSize = "Small ";
            if (size == Size.Medium) expectedSize = "Medium ";
            if (size == Size.Large) expectedSize = "Large ";

            if (flavor == SodaFlavor.Blackberry) expectedFlavor = "Blackberry ";
            if (flavor == SodaFlavor.Cherry) expectedFlavor = "Cherry ";
            if (flavor == SodaFlavor.Grapefruit) expectedFlavor = "Grapefruit ";
            if (flavor == SodaFlavor.Lemon) expectedFlavor = "Lemon ";
            if (flavor == SodaFlavor.Peach) expectedFlavor = "Peach ";
            if (flavor == SodaFlavor.Watermelon) expectedFlavor = "Watermelon ";

            expectedName = expectedSize + expectedFlavor + "Sailor Soda";

            Assert.Equal(expectedName, name);
        }
    }
}
