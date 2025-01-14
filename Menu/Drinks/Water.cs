﻿/* Water.cs
 * Author: Colden Miller
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class for water
    /// </summary>
    public class Water : Drink, INotifyPropertyChanged
    {
        public bool Lemon = false;

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
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// sets Price and Calories
        /// </summary>
        public Water()
        {
            Price = .10;
            Calories = 0;
        }

        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        Size size;
        /// <summary>
        /// Allows to set and get Size
        /// </summary>
        public override Size Size {
            get { return size; }
            set {
                size = value;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
            }
        }

        /// <summary>
        /// Adds Lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// overrides the ToString function to return the size and the item
        /// </summary>
        /// <returns>The size and water</returns>
        public override string ToString()
        {
            return $"{Size.ToString()} Water";
        }
    }
}
