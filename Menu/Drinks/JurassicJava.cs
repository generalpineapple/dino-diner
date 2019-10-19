/* JurassicJava.cs
 * Author: Colden Miller
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class for coffee
    /// </summary>
    public class JurassicJava: Drink, INotifyPropertyChanged
    {
        public bool RoomForCream = false;
        public bool Decaf = false;


        /// <summary>
        /// The PropertyChanged event handler; notifies
        /// of changes to the Price, Description, and
        /// Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        
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
                if (RoomForCream) special.Add("Leave Room for Cream");
                if (Ice) special.Add("Add Ice");
                return special.ToArray();
            }
        }


        /// <summary>
        /// comstructor sets ice to false and default size
        /// </summary>
        public JurassicJava()
        {
            Ice = false;
            Price = 0.59;
            Calories = 2;
        }

        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }

        /// <summary>
        /// this declares the enum size
        /// </summary>
        private Size size;
        /// <summary>
        /// When changing the size, this method will 
        /// update the Price and Calories of the item
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
                    case Size.Small:
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Allows for Decaf coffee
        /// </summary>
        public void MakeDecaf()
        {
            Decaf = true;
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Allows the customer to add their own cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Adds ice to their coffee
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// overrides the ToString function to return the size and the item and whether its decaf
        /// </summary>
        /// <returns>The size and either decaf or just Jurassic Java</returns>
        public override string ToString()
        {
            if (Decaf)
                return size.ToString() + " Decaf Jurassic Java";
            else
                return size.ToString() + " Jurassic Java";
        }
    }
}
