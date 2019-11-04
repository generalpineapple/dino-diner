using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink Drink { get; set; }
        private CretaceousCombo combo;
        private DinoDiner.Menu.Size Size { get; set; } = DinoDiner.Menu.Size.Small;

        public DrinkSelection()
        {
            InitializeComponent();
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;
        }

        public DrinkSelection(CretaceousCombo drink)
        {
            InitializeComponent();
            this.Drink = drink.Drink;
            Size = drink.Size;
            combo = drink;
        }

        private void AddDrink(Drink drink)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    order.Remove(Drink);
                    order.Add(drink);
                    Drink = drink;
                }
            }
            else
            {
                drink.Size = Size;
                Drink = drink;
                combo.Drink = drink;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (combo == null)
            {
                if (Drink == null)
                    Size = size;
                else
                {
                    if (DataContext is Order order)
                    {
                        order.Remove(Drink);
                        Drink.Size = size;
                        order.Add(Drink);
                        NavigationService.GoBack();
                    }
                }
            }
        }

        private void AddFlavor(object obj, RoutedEventArgs args)
        {
            Sodasaurus soda = new Sodasaurus();
            AddDrink(soda);
        }

        private void AddWaterButtons(object obj, RoutedEventArgs args)
        {
            Water wat = new Water();
            AddDrink(wat);
        }

        private void AddTeaButtons(object obj, RoutedEventArgs args)
        {
            Tyrannotea tea = new Tyrannotea();
            AddDrink(tea);
        }

        private void AddJavaButtons(object obj, RoutedEventArgs args)
        {
            JurassicJava java = new JurassicJava();
            AddDrink(java);
        }



        private void SelectFlavor(object obj, RoutedEventArgs args)
        { 
            if (combo == null)
            {
                    NavigationService.Navigate(new FlavorSelection(Drink));
            }
            else
            {
                NavigationService.Navigate(new FlavorSelection(combo));
            }
        }
       
        private void OnAddSweet(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea)
            {
                Tyrannotea tea = Drink as Tyrannotea;
                tea.AddSweet();
                Drink = tea;
            }
            if (combo != null)
                combo.Drink = Drink;
        }

        private void OnAddLemon(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea)
            {
                Tyrannotea tea = Drink as Tyrannotea;
                tea.AddLemon();
                Drink = tea;
            }
            else if (Drink is Water)
            {
                Water water = Drink as Water;
                water.AddLemon();
                Drink = water;
            }
            if (combo != null)
                combo.Drink = Drink;
        }

        private void OnDecaf(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava)
            {
                JurassicJava java = Drink as JurassicJava;
                java.MakeDecaf();                
                Drink = java;
            }
            if (combo != null)
                combo.Drink = Drink;
        }

        private void OnCreamClick(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava)
            {
                JurassicJava java = Drink as JurassicJava;
                java.LeaveRoomForCream();
                Drink = java;
            }
            if (combo != null)
                combo.Drink = Drink;
        }

            private void OnIceClick(object sender, RoutedEventArgs args)
        {
            if(Drink is JurassicJava)
            {
                JurassicJava java = Drink as JurassicJava;
                java.AddIce();
                Drink = java;
            }
            else
            {
                Drink.HoldIce();
            }
            if (combo != null)
                combo.Drink = Drink;
        }

        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
    }
}