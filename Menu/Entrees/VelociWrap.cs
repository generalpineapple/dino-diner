using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        /// <summary>
        /// boolean statements to determine what they want on their food
        /// </summary>
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        /// <summary>
        /// List of ingredients on their selected entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for class
        /// sets Price and Calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Method to Hold lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Method to Hold dressing
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Method to Hold chesse
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}