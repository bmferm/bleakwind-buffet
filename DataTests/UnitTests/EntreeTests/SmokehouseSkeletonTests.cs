﻿/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            Assert.True(entree.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            Assert.True(entree.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            Assert.True(entree.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            Assert.True(entree.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            entree.SausageLink = false;
            Assert.False(entree.SausageLink);
            entree.SausageLink = true;
            Assert.True(entree.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            entree.Egg = false;
            Assert.False(entree.Egg);
            entree.Egg = true;
            Assert.True(entree.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            entree.HashBrowns = false;
            Assert.False(entree.HashBrowns);
            entree.HashBrowns = true;
            Assert.True(entree.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            entree.Pancake = false;
            Assert.False(entree.Pancake);
            entree.Pancake = true;
            Assert.True(entree.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            Assert.Equal(4.57, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            Assert.Equal(404, (double)entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton()
            {
                SausageLink = includeSausage,
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake
            };

            if (!includeSausage) Assert.Contains("Hold sausage", entree.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", entree.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", entree.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", entree.ToString());
        }
    }
}