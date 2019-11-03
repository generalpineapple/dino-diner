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
            Customize(combo);
        }

        private void OnNuggets(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new DinoNuggets()));
            Customize(combo);
        }

        private void OnSteak(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new SteakosaurusBurger()));
            Customize(combo);
        }

        private void OnTRex(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new TRexKingBurger()));
            Customize(combo);
        }

        private void OnWings(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new PterodactylWings()));
            Customize(combo);
        }

        private void OnPBJ(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new PrehistoricPBJ()));
            Customize(combo);
        }

        private void OnWrap(object sender, RoutedEventArgs args)
        {
            combo = new CretaceousCombo(new VelociWrap());
            Customize(combo);
        }
    }
}
