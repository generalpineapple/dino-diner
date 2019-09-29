using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        public bool Lemon = false;

        /// <summary>
        /// sets Price and Calories
        /// </summary>
        public Water()
        {
            Price = .10;
            Calories = 0;
        }

        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Allows to set and get Size
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// Adds Lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
