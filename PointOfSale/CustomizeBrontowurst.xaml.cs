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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst bron;
        private CretaceousCombo combo;

        public CustomizeBrontowurst(Brontowurst bron)
        {
            InitializeComponent();
            this.bron = bron;
        }

        public CustomizeBrontowurst(CretaceousCombo bron)
        {
            InitializeComponent();
            this.combo = bron;
            this.bron = bron.Entree as Brontowurst;
        }

        private void OnHoldOnions(object sender, RoutedEventArgs args)
        {
            bron.HoldOnion();
            if(combo != null)
            {
                combo.Entree = bron;
            }
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            bron.HoldBun();
            if (combo != null)
            {
                combo.Entree = bron;
            }
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            bron.HoldPeppers();
            if (combo != null)
            {
                combo.Entree = bron;
            }
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
                {
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
            else if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCatagorySelection());
            }
        }
    }
}
