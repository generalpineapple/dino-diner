/* VelociWrap.cs
 * Author: Colden Miller
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// boolean statements to determine what they want on their food
        /// </summary>
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

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
            get
            {
                List<string> special = new List<string>();
                if (!dressing) special.Add("Hold Ceasar Dressing");
                if (!lettuce) special.Add("Hold Romaine Lettuce");
                if (!cheese) special.Add("Hold Parmesan Cheese");
                return special.ToArray();
            }
        }


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

        /// <summary>
        /// overrides the ToString function to return the item
        /// </summary>
        /// <returns>Veloci-Wrap</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}