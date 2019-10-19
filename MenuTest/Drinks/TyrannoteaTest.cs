/* TyrannoteaTest.cs
 * Author: Colden Miller
 */
 using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //The correct default price, calories, 
        //ice, size, lemon, and sweet properties.
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(0.99, tea.Price, 2);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveIceAsDefault()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }


        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveSmallPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal(.99, tea.Price, 2);
        }

        [Fact]
        public void ShouldHaveMediumPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal(1.49, tea.Price, 2);
        }

        [Fact]
        public void ShouldHaveLargePrice()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal(1.99, tea.Price, 2);
        }

        [Fact]
        public void ShouldHaveSmallCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveMediumCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveLargeCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }


        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }


        //That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }


        //That setting the sweet property to true results in the right calories for each size
        [Fact]
        public void ShouldHaveSmallCaloriesWithSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.AddSweet();
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveMediumCaloriesWithSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.AddSweet();
            Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void ShouldHaveLargeCaloriesWithSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.AddSweet();
            Assert.Equal<uint>(64, tea.Calories);
        }


        //That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        [Fact]
        public void ShouldHaveSmallCaloriesAfterSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Sweet = false;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveMediumCaloriesAfterSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Sweet = false;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveLargeCaloriesAfterSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Sweet = false;
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }


        //The correct ingredients are given
        [Fact]
        public void ShouldHaveDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal(2, tea.Ingredients.Count);
        }

        [Fact]
        public void ShouldContainAllIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.AddSweet();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Equal(4, tea.Ingredients.Count);
        }

        //Special
        [Fact]
        public void ShouldHaveEmptyScpecialListByDefault()
        {
            Tyrannotea pbj = new Tyrannotea();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void SpecialShouldHoldIce()
        {
            Tyrannotea bw = new Tyrannotea();
            bw.HoldIce();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldAddSugar()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddSweet();
            Assert.Collection<string>(tt.Special,
                item =>
                {
                    Assert.Equal("Add Cane Sugar", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldAddLemon()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            Assert.Collection<string>(tt.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldContainAll()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            tt.AddSweet();
            tt.HoldIce();
            Assert.Collection<string>(tt.Special,
                item =>
                {
                    Assert.Equal("Add Cane Sugar", item);
                },
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                }
            );
        }

        //INotify
        [Fact]
        public void ShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Special", () => tt.AddLemon());
            Assert.PropertyChanged(tt, "Special", () => tt.AddSweet());
            Assert.PropertyChanged(tt, "Special", () => tt.HoldIce());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyOfPricePropertyChange(Size size)
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Price", () => {
                tt.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyOfDescriptionPropertyChange(Size size)
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Description", () => {
                tt.Size = size;
            });
        }

        [Fact]
        public void AddSweetShouldNotifyOfDescriptionPropertyChange()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Description", () => tt.AddSweet());
        }
    }
}
