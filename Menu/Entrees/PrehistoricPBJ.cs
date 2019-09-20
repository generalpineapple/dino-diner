using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// boolean statements to determine what they want on their food
        /// </summary>
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// List of ingredients on their selected entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for class
        /// sets Price and Calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Method to Hold peanut butter
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Method to Hold jelly
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
