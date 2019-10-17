/* TRexKingBurger.cs
 * Author: Colden Miller
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree, INotifyPropertyChanged
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
                if (!lettuce) special.Add("Hold Lettuce");
                if (!onion) special.Add("Hold Onion");
                if (!mayo) special.Add("Hold Mayo");
                if (!tomato) special.Add("Hold Tomato");
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

        /// <summary>
        /// overrides the ToString function to return the item
        /// </summary>
        /// <returns>T-Rex King Burger</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}