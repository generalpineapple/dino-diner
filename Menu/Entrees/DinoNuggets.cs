using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// The starting number of nuggets in this order
        /// </summary>
        private int nuggets = 6;

        /// <summary>
        /// List of ingredients on their selected entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < nuggets; i ++)
                    ingredients.Add("Chicken Nugget");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for class
        /// sets Price and Calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        /// <summary>
        /// this method add one more nugget to their order
        /// adding a nugget updates the price and calories
        /// </summary>
        public void AddNugget()
        {
            nuggets++;
            this.Price += .25;
            this.Calories += 59;
        }

    }
}
