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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        private CretaceousCombo combo { get; set; }

        public ComboSelection()
        {
            InitializeComponent();
        }

        private void Customize(CretaceousCombo combo)
        {
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        private void SelectCombo(CretaceousCombo combo)
        {
            if(DataContext is Order order)
            {
                order.Add(combo);
                this.combo = combo;
            }
        }

        private void OnBronto(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new Brontowurst()));
            NavigationService.Navigate(new CustomizeBrontowurst(combo));
        }

        private void OnNuggets(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new DinoNuggets()));
            NavigationService.Navigate(new CustomizeNuggets(combo));
        }

        private void OnSteak(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new SteakosaurusBurger()));
            NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo));
        }

        private void OnTRex(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new TRexKingBurger()));
            NavigationService.Navigate(new CustomizeTRex(combo));
        }

        private void OnWings(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new PterodactylWings()));
            Customize(combo);
        }

        private void OnPBJ(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new PrehistoricPBJ()));
            NavigationService.Navigate(new CustomizePBJ(combo));
        }

        private void OnWrap(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new VelociWrap()));
            NavigationService.Navigate(new CustomizeWrap(combo));
        }
    }
}
