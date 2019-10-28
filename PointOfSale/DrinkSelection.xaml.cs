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
        private bool decaf;
        private bool sweet;
        private bool lemon;
        private bool ice = true;
        private bool roomForCream;
        private int drinkSelection;


        public Drink Drink { get; set; }
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

        protected void OnAddOrder(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                switch (drinkSelection)
                {
                    //Water
                    case 1:
                        Water wat = new Water();
                        if (lemon) wat.AddLemon();
                        if (!ice) wat.HoldIce();
                        wat.Size = Size;
                        this.Drink = wat;
                        order.Items.Add(wat);
                        NavigationService.Navigate(new MenuCatagorySelection());
                        break;
                    //Soda
                    case 2:
                        if(Drink is Sodasaurus soda)
                        {
                            if (!ice) soda.HoldIce();
                            soda.Size = Size;
                            order.Items.Add(soda);
                            NavigationService.Navigate(new MenuCatagorySelection());
                        }                        
                        break;
                    //Tea
                    case 3:
                        Tyrannotea tea = new Tyrannotea();
                        if (lemon) tea.AddLemon();
                        if (sweet) tea.AddSweet();
                        if (!ice) tea.HoldIce();
                        tea.Size = Size;
                        this.Drink = tea;
                        order.Items.Add(tea);
                        NavigationService.Navigate(new MenuCatagorySelection());
                        break;
                    //Java
                    case 4:
                        JurassicJava jav = new JurassicJava();
                        if (decaf) jav.MakeDecaf();
                        if (roomForCream) jav.LeaveRoomForCream();
                        if (ice) jav.AddIce();
                        jav.Size = Size;
                        this.Drink = jav;
                        order.Items.Add(jav);
                        NavigationService.Navigate(new MenuCatagorySelection());
                        break;

                }
                
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            Size = size;
        }

        private void disableAll()
        {
            AddOrder.IsEnabled = true;
            But1.IsEnabled = false;
            But1.Opacity = 0;
            But2.IsEnabled = false;
            But2.Opacity = 0;
            Flavor.IsEnabled = false;
            Flavor.Opacity = 0;
            CreamButton.IsEnabled = false;
            CreamButton.Opacity = 0;


        }

        private void AddFlavor(object obj, RoutedEventArgs args)
        {
            Drink = new Sodasaurus();
            drinkSelection = 2;
            disableAll();
            TextBlock1.Text = "Flavor";
            Flavor.Opacity = 100;
            Flavor.IsEnabled = true;
        }

        private void AddWaterButtons(object obj, RoutedEventArgs args)
        {
            drinkSelection = 1;
            disableAll();
            TextBlock1.Text = "No Lemon";
            But1.Tag = 2;
            lemon = false;
            But1.Opacity = 100;
            But1.IsEnabled = true;
        }

        private void AddTeaButtons(object obj, RoutedEventArgs args)
        {
            drinkSelection = 3;
            disableAll();
            TextBlock1.Text = "No Lemon";
            But1.Tag = 2;
            sweet = false;
            But1.Opacity = 100;
            But1.IsEnabled = true;
            TextBlock2.Text = "No Sugar";
            But2.Tag = 1;
            lemon = false;
            But2.Opacity = 100;
            But2.IsEnabled = true;
        }

        private void AddJavaButtons(object obj, RoutedEventArgs args)
        {
            drinkSelection = 4;
            disableAll();
            TextBlock1.Text = "Caffinated";
            But1.Tag = 3;
            decaf = false;
            But1.Opacity = 100;
            But1.IsEnabled = true;
            CreamButton.IsEnabled = true;
            CreamButton.Opacity = 100;
        }



        private void SelectFlavor(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection(Drink));
        }

        private void buttonClick(object obj, RoutedEventArgs args)
        {
            Button button = (Button)obj;
            switch ((int)button.Tag)
            {
                case 1:
                    if (sweet)
                    {
                        sweet = false;
                        TextBlock2.Text = "No Sugar"; 
                    }
                    else
                    {
                        sweet = true;
                        TextBlock2.Text = "Add Sugar";
                    }
                    break;
                case 2:
                    if (lemon)
                    {
                        lemon = false;
                        TextBlock1.Text = "No Lemon";
                    }
                    else
                    {
                        lemon = true;
                        TextBlock1.Text = "Add lemon";
                    }
                    break;
                case 3:
                    if (decaf)
                    {
                        decaf = false;
                        TextBlock1.Text = "Caffeinated";
                    }
                    else
                    {
                        decaf = true;
                        TextBlock1.Text = "Decaffeinated";
                    }
                    break;
            }
        }

        private void OnCreamClick(object sender, RoutedEventArgs args)
        {
            if (roomForCream)
            {
                roomForCream = false;
                cream.Text = "No Cream";
            }
            else
            {
                roomForCream = true;
                cream.Text = "Add Cream";
            }
        }

        private void OnIceClick(object sender, RoutedEventArgs args)
        {
            if (ice)
            {
                ice = false;
                IceTextBlock.Text = "No Ice";
            }
            else
            {
                ice = true;
                IceTextBlock.Text = "Add Ice";
            }
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