/* IMenuItem.cs
 * Author: Colden Miller
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// An interface for all menu items
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// getter for the Price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// getter for calories
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// getter for Ingredients
        /// </summary>
        List<string> Ingredients { get; }
    }
}
