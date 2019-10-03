using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree
    {
        /// <summary>
        /// boolean statements to determine what they want on their food
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// List of ingredients on their selected entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for class
        /// sets Price and Calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Method to Hold bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Method to Hold peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Method to Hold onions
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }

    }
}

