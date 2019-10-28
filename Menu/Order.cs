using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace DinoDiner.Menu
{
    public class Order  : INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for property chnages
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// A collection of items in the order
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }


        public Order()
        {

        }

        protected void NotifyAllPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnCollectionChanged;
            NotifyAllPropertyChanged();
        }

        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertyChanged();
            }
            return removed;
        }


        private void OnCollectionChanged(object sender, EventArgs args)
        {
            NotifyAllPropertyChanged();
        }

        /// <summary>
        /// This calculates the total price from the prices of all order items
        /// </summary>
        public double SubtotalCost {
            get
            {
                double total = 0;
                foreach(IOrderItem item in items)
                {
                    total += item.Price;
                }
                if (total < 0) return 0;
                return total;
            }
        }


        double salesTaxRate = .1;        
        /// <summary>
        /// Gets the Sales rate tax and is able to be set
        /// </summary>
        public double SalesTaxRate {
            get { return salesTaxRate; }
            protected set {
                if (value < 0) return;
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

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
