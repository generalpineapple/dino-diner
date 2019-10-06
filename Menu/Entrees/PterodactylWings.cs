/* PterodactylWings.cs
 * Author: Colden Miller
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// List of ingredients on their selected entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for class
        /// sets Price and Calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// overrides the ToString function to return the item
        /// </summary>
        /// <returns>Pterodactyl Wings</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
