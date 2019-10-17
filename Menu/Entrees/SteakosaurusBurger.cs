/* SteakosaurusBurger.cs
 * Author: Colden Miller
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// boolean statements to determine what they want on their food
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

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
                if (!bun) special.Add("Hold Whole Wheat Bun");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
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
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for class
        /// sets Price and Calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
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
        /// overrides the ToString function to return the item
        /// </summary>
        /// <returns>Steakosaurus Burger</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
