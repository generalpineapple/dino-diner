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
        public Menu menu; 

        public List<object> Menu { get; private set; }

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public string price { get; set; }

        [BindProperty]
        public List<string> exIngredients { get; set; } = new List<string>();



        //public string list { get; set; }
        public void OnGet()
        {
            Menu = menu.AvailableMenuItems;
            Menu.AddRange(menu.AvailalbeCombos);
        }

        public void OnPost()
        {

        }
    }
}