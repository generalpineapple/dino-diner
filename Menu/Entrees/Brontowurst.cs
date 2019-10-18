/* Brontowurst.cs
 * Author: Colden Miller
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// boolean statements to determine what they want on their food
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

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
                if (!peppers) special.Add("Hold Peppers");
                if (!onions) special.Add("Hold Onions");
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
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method to Hold peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method to Hold onions
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// overrides the ToString function to return the item
        /// </summary>
        /// <returns>Brontowurst</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

    }
}

