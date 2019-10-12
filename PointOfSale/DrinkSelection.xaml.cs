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
        
        public DrinkSelection()
        {
            InitializeComponent();
        }

        private void disableAll()
        {
            But1.IsEnabled = false;
            But1.Opacity = 0;
            But2.IsEnabled = false;
            But2.Opacity = 0;
            Flavor.IsEnabled = false;
            Flavor.Opacity = 0;
        }

        private void AddFlavor(object obj, RoutedEventArgs args)
        {
            disableAll();
            TextBlock1.Text = "Flavor";
            Flavor.Opacity = 100;
            Flavor.IsEnabled = true;
        }

        private void AddWaterButtons(object obj, RoutedEventArgs args)
        {
            disableAll();
            TextBlock1.Text = "No Lemon";
            But1.Tag = 2;
            lemon = false;
            But1.Opacity = 100;
            But1.IsEnabled = true;
        }

        private void AddTeaButtons(object obj, RoutedEventArgs args)
        {
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
            disableAll(); TextBlock1.Text = "Caffinated";
            But1.Tag = 3;
            decaf = false;
            But1.Opacity = 100;
            But1.IsEnabled = true;
        }

        private void SelectFlavor(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
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
    }
}
