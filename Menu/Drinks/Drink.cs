/* Drink.cs
 * Author: Colden Miller
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// abstract class for drinks
    /// </summary>
    public abstract class  Drink : IMenuItem
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
        /// Allows users to Hold Ice 
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
