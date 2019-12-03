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
    public static class Menu
    {
        /// <summary>
        /// A list of all the availiable menu items
        /// </summary>
        public static List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(new CretaceousCombo(new Brontowurst()));
                items.Add(new CretaceousCombo(new DinoNuggets()));
                items.Add(new CretaceousCombo(new PrehistoricPBJ()));
                items.Add(new CretaceousCombo(new PterodactylWings()));
                items.Add(new CretaceousCombo(new SteakosaurusBurger()));
                items.Add(new CretaceousCombo(new TRexKingBurger()));
                items.Add(new CretaceousCombo(new VelociWrap()));

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

                items.Add(new JurassicJava());
                items.Add(new Sodasaurus());
                items.Add(new Tyrannotea());
                items.Add(new Water());
                return items;
            }
        }

        /// <summary>
        /// a list of all Entrees
        /// </summary>
        public static List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
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
        public static List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
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
        public static List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
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
        public static List<IMenuItem> AvailalbeCombos
        {
            get
            {
                return new List<IMenuItem> { new CretaceousCombo( new DinoNuggets() ),
                    new CretaceousCombo( new PrehistoricPBJ()), new CretaceousCombo( new PterodactylWings()),
                    new CretaceousCombo( new SteakosaurusBurger()), new CretaceousCombo( new TRexKingBurger()),
                    new CretaceousCombo( new VelociWrap()), };
            }
        }


        public static HashSet<string> PossibleIngredients
        {
            get
            {
                HashSet<string> result = new HashSet<string>();
                foreach(IMenuItem item in AvailableMenuItems)
                {
                    foreach(string ingredient in item.Ingredients)
                    {
                        result.Add(ingredient);
                    }
                }
                return result;
            }
        }
        /// <summary>
        /// overrides the ToString method
        /// </summary>
        /// <returns>Every item on the menu seperated by a newline</returns>
/*
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
        */
    }
}