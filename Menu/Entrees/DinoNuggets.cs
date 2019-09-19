using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        private int nuggets = 6;

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

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        public void AddNugget()
        {
            nuggets++;
            this.Price += .25;
            this.Calories += 59;
        }

    }
}
