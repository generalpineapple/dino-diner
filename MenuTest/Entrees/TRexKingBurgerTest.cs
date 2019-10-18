using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        //Special
        [Fact]
        public void ShouldHaveEmptyScpecialListByDefault()
        {
            TRexKingBurger pbj = new TRexKingBurger();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldBun();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldPickle()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldPickle();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldKetchup()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldKetchup();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldMustard()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldMustard();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldLettuce();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldMayo()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldMayo();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldOnion()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldOnion();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldTomato()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldTomato();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldAll()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldBun();
            bw.HoldKetchup();
            bw.HoldPickle();
            bw.HoldMustard();
            bw.HoldLettuce();
            bw.HoldMayo();
            bw.HoldOnion();
            bw.HoldTomato();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                }
            );
        }

    }

}
