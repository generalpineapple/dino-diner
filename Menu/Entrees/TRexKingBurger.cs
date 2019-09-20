using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// boolean statements to determine what they want on their food
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool lettuce = true;
        private bool onion = true;
        private bool mayo = true;
        private bool tomato = true;

        /// <summary>
        /// List of ingredients on their selected entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (lettuce) ingredients.Add("Lettuce");
                if (onion) ingredients.Add("Onion");
                if (mayo) ingredients.Add("Mayo");
                if (tomato) ingredients.Add("Tomato");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for class
        /// sets Price and Calories
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Method to Hold bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Method to Hold pickles
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Method to Hold ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Method to Hold mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Method to Hold lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Method to Hold onion
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Method to Hold mayo
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }

        /// <summary>
        /// Method to Hold tomato
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }
    }
}