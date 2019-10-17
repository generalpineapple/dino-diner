/* PterodactylWings.cs
 * Author: Colden Miller
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree, INotifyPropertyChanged
    {
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
                return null;
            }
        }
        /// <summary>
        /// List of ingredients on their selected entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for class
        /// sets Price and Calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// overrides the ToString function to return the item
        /// </summary>
        /// <returns>Pterodactyl Wings</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
