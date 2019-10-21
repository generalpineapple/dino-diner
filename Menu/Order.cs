using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// Represents the items added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
        }

        /// <summary>
        /// This calculates the total price from the prices of all order items
        /// </summary>
        public double SubtotalCost {
            get
            {
                double total = 0;
                foreach(IOrderItem item in Items)
                {
                    total += item.Price;
                }
                if (total < 0) return 0;
                return total;
            }
        }

        /// <summary>
        /// Gets the Sales rate tax and is able to be set
        /// </summary>
        public double SalesTaxRate { get; protected set; } = .1;

        /// <summary>
        /// This is the cost of the sales tax
        /// which is the product of the SalesTaxRate and the SubtotalCost
        /// </summary>
        public double SalesTaxCost {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// This is the total cost of everything
        /// which is the sum of the SubtotalCost and the SalesTaxCost.
        /// </summary>
        public double TotalCost {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }

    }
}
