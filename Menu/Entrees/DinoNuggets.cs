/* DinoNuggets.cs
 * Author: Colden Miller
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// The starting number of nuggets in this order
        /// </summary>
        private int nuggets = 6;

        /// <summary>
        /// The PropertyChanged event handler; notifies
        /// of changes to the Price, Description, and
        /// Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets and sets the description
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get { return new string[0]; }
        }

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
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Price");
        }

        /// <summary>
        /// overrides the ToString function to return the item
        /// </summary>
        /// <returns>Dino-Nuggets</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
