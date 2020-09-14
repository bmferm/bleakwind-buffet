﻿/*
 * Author: Zachery Brunner
 * Edited By: Brittany "Chelle" Ferm
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.True(entree.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.True(entree.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr entree = new DoubleDraugr();
            entree.Bun = false;
            Assert.False(entree.Bun);
            entree.Bun = true;
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr entree = new DoubleDraugr();
            entree.Ketchup = false;
            Assert.False(entree.Ketchup);
            entree.Ketchup = true;
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr entree = new DoubleDraugr();
            entree.Mustard = false;
            Assert.False(entree.Mustard);
            entree.Mustard = true;
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr entree = new DoubleDraugr();
            entree.Pickle = false;
            Assert.False(entree.Pickle);
            entree.Pickle = true;
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr entree = new DoubleDraugr();
            entree.Cheese = false;
            Assert.False(entree.Cheese);
            entree.Cheese = true;
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr entree = new DoubleDraugr();
            entree.Tomato = false;
            Assert.False(entree.Tomato);
            entree.Tomato = true;
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr entree = new DoubleDraugr();
            entree.Lettuce = false;
            Assert.False(entree.Lettuce);
            entree.Lettuce = true;
            Assert.True(entree.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr entree = new DoubleDraugr();
            entree.Mayo = false;
            Assert.False(entree.Mayo);
            entree.Mayo = true;
            Assert.True(entree.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.Equal(7.32, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.Equal(843, (double)entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr entree = new DoubleDraugr()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo
            };

            if (!includeBun) Assert.Contains("Hold bun", entree.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", entree.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", entree.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", entree.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", entree.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", entree.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", entree.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.Equal("Double Draugr", entree.ToString());
        }
    }
}