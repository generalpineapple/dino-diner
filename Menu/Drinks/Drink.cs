/* Drink.cs
 * Author: Colden Miller
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// abstract class for drinks
    /// </summary>
    public abstract class  Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// an abstract variable to set and get size of drink
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Ice is set to true as default
        /// </summary>
        public bool Ice { get; protected set; } = true;

        /// <summary>
        /// The Price of the drink
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// the Calories inside the drink
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List of Ingredients
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// A Description of the item
        /// </summary>
        public abstract string Description { get; }
        
        /// <summary>
        /// Special instruction for preparing the item
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// The PropertyChanged event handler; notifies
        /// of changes to the Price, Description, and
        /// Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        
        //Helper function for notifying of property changes
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Allows users to Hold Ice 
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChange("Special");
        }
    }
}
