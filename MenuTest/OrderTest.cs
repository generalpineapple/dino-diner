using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldHaveExpectedSubTotal()
        {
            Order order = new Order();
            order.Add(new Brontowurst());
            order.Add(new Fryceritops());
            order.Add(new Sodasaurus());
            Assert.Equal(7.85, order.SubtotalCost, 2);
        }

        [Fact]
        public void ShouldHaveExpectedRateCost()
        {
            Order order = new Order();
            order.Add(new Brontowurst());
            order.Add(new Fryceritops());
            order.Add(new Sodasaurus());
            Assert.Equal(.79, order.SalesTaxCost, 2);
        }

        [Fact]
        public void ShouldHaveExpectedTotalCost()
        {
            Order order = new Order();
            order.Add(new Brontowurst());
            order.Add(new Fryceritops());
            order.Add(new Sodasaurus());
            Assert.Equal(8.64, order.TotalCost, 2);
        }

        [Fact]
        public void ShouldNeverBeNegative()
        {
            //ToDo
        }
    }
}
