﻿using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        //Special
        [Fact]
        public void ShouldHaveEmptyScpecialListByDefault()
        {
            VelociWrap pbj = new VelociWrap();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            VelociWrap bw = new VelociWrap();
            bw.HoldLettuce();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Romaine Lettuce", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldDressing()
        {
            VelociWrap bw = new VelociWrap();
            bw.HoldDressing();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Ceasar Dressing", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldCheese()
        {
            VelociWrap bw = new VelociWrap();
            bw.HoldCheese();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Parmesan Cheese", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldAll()
        {
            VelociWrap bw = new VelociWrap();
            bw.HoldLettuce();
            bw.HoldDressing();
            bw.HoldCheese();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Ceasar Dressing", item);
                },
                item =>
                {
                    Assert.Equal("Hold Romaine Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Parmesan Cheese", item);
                }
            );
        }
    }
}
