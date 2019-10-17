/* Triceritots.cs
 * Author: Colden Miller
 */
using System.ComponentModel;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class for tator tots
    /// </summary>
    public class Triceritots : Side, INotifyPropertyChanged
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
        /// List of ingredients on their selected Side
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
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
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
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
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
        }

        /// <summary>
        /// overrides the ToString function to return the size and the item
        /// </summary>
        /// <returns>The size and Triceritots</returns>
        public override string ToString()
        {
            return size.ToString() + " Triceritots";
        }
    }
}
