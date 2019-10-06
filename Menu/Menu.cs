/* Menu.cs
 * Author: Colden Miller
 */using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class containing all availiable menu items
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// A list of all the availiable menu items
        /// </summary>
        List<object> AvailableMenuItems
        {
            get
            {
                List<object> items = new List<object>();
                items.Add(new JurassicJava());
                items.Add(new Sodasaurus());
                items.Add(new Tyrannotea());
                items.Add(new Water());

                items.Add(new Brontowurst());
                items.Add(new DinoNuggets());
                items.Add(new PrehistoricPBJ());
                items.Add(new PterodactylWings());
                items.Add(new SteakosaurusBurger());
                items.Add(new TRexKingBurger());
                items.Add(new VelociWrap());

                items.Add(new Fryceritops());
                items.Add(new MeteorMacAndCheese());
                items.Add(new MezzorellaSticks());
                items.Add(new Triceritots());
                return items;
            }
        }

        /// <summary>
        /// a list of all Entrees
        /// </summary>
        List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> items = new List<Entree>();
                items.Add(new Brontowurst());
                items.Add(new DinoNuggets());
                items.Add(new PrehistoricPBJ());
                items.Add(new PterodactylWings());
                items.Add(new SteakosaurusBurger());
                items.Add(new TRexKingBurger());
                items.Add(new VelociWrap());
                return items;
            }
        }

        /// <summary>
        /// A list of all Sides
        /// </summary>
        List<Side> AvailableSides
        {
            get
            {
                List<Side> items = new List<Side>();
                items.Add(new Fryceritops());
                items.Add(new MeteorMacAndCheese());
                items.Add(new MezzorellaSticks());
                items.Add(new Triceritots());
                return items;
            }
        }

        /// <summary>
        /// A list of all Drinks
        /// </summary>
        List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> items = new List<Drink>();
                items.Add(new JurassicJava());
                items.Add(new Sodasaurus());
                items.Add(new Tyrannotea());
                items.Add(new Water());
                return items;
            }
        }

        /// <summary>
        /// A list of all Combos
        /// </summary>
        List<IMenuItem> AvailalbeCombos
        {
            get
            {
                return new List<IMenuItem> { new CretaceousCombo( new DinoNuggets() ),
                    new CretaceousCombo( new PrehistoricPBJ()), new CretaceousCombo( new PterodactylWings()),
                    new CretaceousCombo( new SteakosaurusBurger()), new CretaceousCombo( new TRexKingBurger()),
                    new CretaceousCombo( new VelociWrap()), };
            }
        }

        /// <summary>
        /// overrides the ToString method
        /// </summary>
        /// <returns>Every item on the menu seperated by a newline</returns>
        public override string ToString()
        {
            string fullMenu = "";
           foreach(object item in AvailableMenuItems)
            {
                fullMenu += item.ToString();
                fullMenu += "\n";
            }
            return fullMenu;
        }
    }
}