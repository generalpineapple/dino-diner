using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public IEnumerable<IMenuItem> Menu { get; private set; }

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }


        [BindProperty]
        public List<string> exIngredients { get; set; } = new List<string>();

        public HashSet<string> Ingredients { get; set; } = DinoDiner.Menu.Menu.PossibleIngredients;



        //public string list { get; set; }
        public void OnGet()
        {
            Menu = DinoDiner.Menu.Menu.AvailableMenuItems;
        }

        public void OnPost()
        {
            Menu = DinoDiner.Menu.Menu.AvailableMenuItems;
            if(search != null)
            {
                //(IMenuItem.Description.Contains(search, StringComparison.OrdinalIgnoreCase) || IMenuItem.Ingredients.Contains(search)))
                Menu = Menu.Where(IMenuItem =>
                {
                    if (IMenuItem.Description.Contains(search, StringComparison.OrdinalIgnoreCase))
                        return true;
                    foreach (string ingred in IMenuItem.Ingredients)
                    {
                        if (ingred.Contains(search, StringComparison.OrdinalIgnoreCase))
                            return true;
                    }
                    return false;
                });
            }

            if(menuCategory.Count != 0)
            {
                Menu = Menu.Where(IMenuItem =>
                    (menuCategory.Contains("Combo") && IMenuItem is DinoDiner.Menu.CretaceousCombo) ||
                    (menuCategory.Contains("Entree") && IMenuItem is DinoDiner.Menu.Entree) ||
                    (menuCategory.Contains("Side") && IMenuItem is DinoDiner.Menu.Side) ||
                    (menuCategory.Contains("Drink") && IMenuItem is DinoDiner.Menu.Drink)
                    );
            }

            if(minimumPrice != null)
            {
                Menu = Menu.Where(IMenuItem => IMenuItem.Price >= minimumPrice);
            }

            if (maximumPrice != null)
            {
                Menu = Menu.Where(IMenuItem => IMenuItem.Price <= maximumPrice);
            }

            if (exIngredients.Count != 0)
            {
                Menu = Menu.Where(IMenuItem =>
                {
                    foreach(string item in exIngredients)
                    {
                        if (IMenuItem.Ingredients.Contains(item))
                            return false;
                    }
                    return true;
                });
            }
        }
    }
}