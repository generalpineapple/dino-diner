/* Entree.cs
 * Author: Colden Miller
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        public abstract string Description { get; }

        public abstract string[] Special { get; }
    }
       
    
}
