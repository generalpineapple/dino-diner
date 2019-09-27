using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class CretaciousCombo
    {
        public Entree Entree { get; set; }
        public Drink Drink { get; set; }
        public Side Side { get; set; }

        private Size size = Size.Small;
        public Size Size {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        public double Price
        {
            get { return (Entree.Price + Drink.Price + Side.Price - 0.25); }
        }

        public uint Calories
        {
            get { return (Entree.Calories + Drink.Calories + Side.Calories); }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredrients = new List<string>();
                ingredrients.AddRange(Entree.Ingredients);
                ingredrients.AddRange(Side.Ingredients);
                ingredrients.AddRange(Drink.Ingredients);
                return ingredrients;
            }
        }

        private CretaciousCombo() { }

        public CretaciousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
