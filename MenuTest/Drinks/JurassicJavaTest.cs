/* JurassicJavaTest.cs
 * Author: Colden Miller
 */
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal(0.59, jj.Price, 2);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveIceAsDefault()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<Size>(Size.Small, jj.Size);
        }

        [Fact]
        public void ShouldHaveDefaultSpaceForCream()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.RoomForCream);
        }


        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveSmallPrice()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Small;
            Assert.Equal(0.59, jj.Price, 2);
        }

        [Fact]
        public void ShouldHaveMediumPrice()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal(.99, jj.Price, 2);
        }

        [Fact]
        public void ShouldHaveLargePrice()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal(1.49, jj.Price, 2);
        }

        [Fact]
        public void ShouldHaveSmallCalories()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Small;
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveMediumCalories()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }

        [Fact]
        public void ShouldHaveLargeCalories()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }


        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldAddIce()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }


        //That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void ShouldLeaveRoomForCream()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }


        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Contains("Water", jj.Ingredients);
            Assert.Contains("Coffee", jj.Ingredients);
            Assert.Equal(2, jj.Ingredients.Count);
        }

        //Special
        [Fact]
        public void ShouldHaveEmptyScpecialListByDefault()
        {
            JurassicJava pbj = new JurassicJava();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void SpecialShouldAddIce()
        {
            JurassicJava bw = new JurassicJava();
            bw.AddIce();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldLeaveRoomForCream()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special,
                item =>
                {
                    Assert.Equal("Leave Room for Cream", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHaveAll()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            jj.AddIce();
            Assert.Collection<string>(jj.Special,
                item =>
                {
                    Assert.Equal("Leave Room for Cream", item);
                },
                item =>
                {
                    Assert.Equal("Add Ice", item);
                }
            );
        }
    }
}
