/* Water.cs
 * Author: Colden Miller
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class for water
    /// </summary>
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

        /// <summary>
        /// overrides the ToString function to return the size and the item
        /// </summary>
        /// <returns>The size and water</returns>
        public override string ToString()
        {
            return $"{Size.ToString()} Water";
        }
    }
}
