using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
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

        List<IMenuItem> AvailanleCombos
        {
            get
            {
                return new List<IMenuItem> { new CretaceousCombo( new DinoNuggets() ),
                    new CretaceousCombo( new PrehistoricPBJ()), new CretaceousCombo( new PterodactylWings()),
                    new CretaceousCombo( new SteakosaurusBurger()), new CretaceousCombo( new TRexKingBurger()),
                    new CretaceousCombo( new VelociWrap()), };
            }
        }

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