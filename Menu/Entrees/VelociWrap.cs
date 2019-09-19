using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

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

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }

        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}