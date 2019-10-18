using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        [Fact]
        public void ShouldHaveEmptyScpecialListByDefault()
        {
            SteakosaurusBurger bw = new SteakosaurusBurger();
            Assert.Empty(bw.Special);
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            SteakosaurusBurger bw = new SteakosaurusBurger();
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
            SteakosaurusBurger bw = new SteakosaurusBurger();
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
            SteakosaurusBurger bw = new SteakosaurusBurger();
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
            SteakosaurusBurger bw = new SteakosaurusBurger();
            bw.HoldMustard();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldAll()
        {
            SteakosaurusBurger bw = new SteakosaurusBurger();
            bw.HoldBun();
            bw.HoldKetchup();
            bw.HoldPickle();
            bw.HoldMustard();
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
                }
            );
        }
    }

}
