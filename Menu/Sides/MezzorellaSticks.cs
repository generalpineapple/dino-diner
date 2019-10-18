/* MezzorellaSticks.cs
 * Author: Colden Miller
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class for Mozzarella sticks
    /// </summary>
    public class MezzorellaSticks : Side, INotifyPropertyChanged
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
            get { return new string[0]; }
        }

        /// <summary>
        /// List of ingredients on their selected side
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// this declares the enum size
        /// </summary>
        private Size size;
        /// <summary>
        /// When changing the size, this method will 
        /// update the Price and Calories of the side
        /// </summary>
        public override Size Size
        {
            set
            {
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// A constructor that sets the default price and calories to size small
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
        }

        /// <summary>
        /// overrides the ToString function to return the size and the item
        /// </summary>
        /// <returns>The size and Mezzorella Sticks</returns>
        public override string ToString()
        {
            return size.ToString() + " Mezzorella Sticks";
        }
    }
}
