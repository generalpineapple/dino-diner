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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        Sodasaurus Soda;
        private bool isCombo = false;
        protected CretaceousCombo Combo;

        public FlavorSelection()
        {
            InitializeComponent();
        }

        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            if (drink is Sodasaurus soda)
                Soda = soda;
        }

        public FlavorSelection(CretaceousCombo drink)
        {
            InitializeComponent();
            if (drink.Drink is Sodasaurus soda)
                Soda = soda;
            isCombo = true;
            Combo = drink;
        }

        protected void updateCombo()
        {
            if(isCombo)
                Combo.Drink = Soda;
        }

        protected void OnCherry(object sender, RoutedEventArgs args)
        {
            Soda.Flavor = SodasaurusFlavor.Cherry;
            updateCombo();
            NavigationService.GoBack();
        }

        protected void OnChocolate(object sender, RoutedEventArgs args)
        {
            Soda.Flavor = SodasaurusFlavor.Chocolate;
            updateCombo();
            NavigationService.GoBack();
        }

        protected void OnCola(object sender, RoutedEventArgs args)
        {
            Soda.Flavor = SodasaurusFlavor.Cola;
            updateCombo();
            NavigationService.GoBack();
        }

        protected void OnLime(object sender, RoutedEventArgs args)
        {
            Soda.Flavor = SodasaurusFlavor.Lime;
            updateCombo();
            NavigationService.GoBack();
        }

        protected void OnOrange(object sender, RoutedEventArgs args)
        {
            Soda.Flavor = SodasaurusFlavor.Orange;
            updateCombo();
            NavigationService.GoBack();
        }

        protected void OnBeer(object sender, RoutedEventArgs args)
        {
            Soda.Flavor = SodasaurusFlavor.RootBeer;
            updateCombo();
            NavigationService.GoBack();
        }

        protected void OnVanilla(object sender, RoutedEventArgs args)
        {
            Soda.Flavor = SodasaurusFlavor.Vanilla;
            updateCombo();
            NavigationService.GoBack();
        }

    }
}
