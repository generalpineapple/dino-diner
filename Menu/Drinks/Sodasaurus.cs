/* Sodasaurus.cs
 * Author: Colden Miller
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class for soda
    /// </summary>
    public class Sodasaurus : Drink, INotifyPropertyChanged
    {
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola;
        /// <summary>
        /// gets and sets Flavor
        /// </summary>
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set
            {
                NotifyOfPropertyChange("Description");
                flavor = value;
            }
        }       

        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        public override string Description
        {
            get { return this.ToString();  }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        //Backing variable
        private Size size;
        /// <summary>
        /// When changing the size, this method will 
        /// update the Price and Calories of the item
        /// </summary>
        public override Size Size
        {
            set
            {
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
            get
            {
                return size;
            }
        }


        /// <summary>
        /// Sets default Price and Calories
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
        }

        /// <summary>
        /// overrides the ToString function to return the size and the item
        /// </summary>
        /// <returns>The size and Sodasaurus</returns>
        public override string ToString()
        {
            return $"{size.ToString()} {Flavor.ToString()} Sodasaurus";
        }
    }
}
