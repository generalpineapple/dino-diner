using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
    {
        public bool Sweet = false;
        public bool Lemon = false;

        public Tyrannotea()
        {
            Price = .99;
            Calories = 8;
        }

        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Tea", "Water"};
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// this declares the enum size
        /// </summary>
        private Size size;
        /// <summary>
        /// When changing the size, this method will 
        /// update the Price and Calories of the item
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        if (Sweet)
                            Calories *= 2;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        if (Sweet)
                            Calories *= 2;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        if (Sweet)
                            Calories *= 2;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// sets lemon to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }


        /// <summary>
        /// Adds sweetner to the tea
        /// </summary>
        public void AddSweet()
        {
            Sweet = true;
            Size = size;
        }

        /// <summary>
        /// overrides the ToString function to return the size and the item
        /// </summary>
        /// <returns>The size and Tyrannotea</returns>
        public override string ToString()
        {
            return $"{size.ToString()} Tyrannotea";
        }
    }
}
