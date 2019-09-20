using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        /// <summary>
        /// List of ingredients on their selected Side
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// this declares the enum size
        /// </summary>
        private Size size;
        /// <summary>
        /// When changing the size, this method will 
        /// update the Price and Calories of the side
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// A constructor that sets the default price and calories to size small
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
        }
    }
}
