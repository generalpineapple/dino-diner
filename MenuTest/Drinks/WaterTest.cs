/* WaterTest.cs
 * Author: Colden Miller
 */
 using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //The correct default price, calories, ice, size, and lemon properties.
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal(0.10, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveIceAsDefault()
        {

            Water water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }


        //The correct price and calories after changing to small, medium, and large sizes
        [Fact]
        public void ShouldHaveSmallPrice()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal(.10, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveMediumPrice()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal(.10, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveLargePrice()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal(.10, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveSmallCalories()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveMediumCalories()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveLargeCalories()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }


        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }


        //That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }


        //The correct ingredients are given.
        [Fact]
        public void ShouldContainDefaultIngredients()
        {
            Water water = new Water();
            Assert.Contains("Water", water.Ingredients);
            Assert.Single(water.Ingredients);
        }

        [Fact]
        public void ShouldContainAllIngredients()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains("Water", water.Ingredients);
            Assert.Contains("Lemon", water.Ingredients);
            Assert.Equal(2, water.Ingredients.Count);
        }

        //Special
        [Fact]
        public void ShouldHaveEmptyScpecialListByDefault()
        {
            Water pbj = new Water();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void SpecialShouldHoldIce()
        {
            Water wat = new Water();
            wat.HoldIce();
            Assert.Collection<string>(wat.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldAddLemon()
        {
            Water wat = new Water();
            wat.AddLemon();
            Assert.Collection<string>(wat.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldContainAll()
        {
            Water wat = new Water();
            wat.HoldIce();
            wat.AddLemon();
            Assert.Collection<string>(wat.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                },
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                }
            );
        }
    }
}
