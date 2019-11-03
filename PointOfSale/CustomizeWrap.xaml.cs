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
    /// Interaction logic for CustomizeWrap.xaml
    /// </summary>
    public partial class CustomizeWrap : Page
    {
        private VelociWrap wrap;
        private CretaceousCombo combo;

        public CustomizeWrap(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap;
        }

        public CustomizeWrap(CretaceousCombo wrap)
        {
            InitializeComponent();
            this.wrap = wrap.Entree as VelociWrap;
            combo = wrap;
        }

        public void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
            if (combo != null)
            {
                combo.Entree = wrap;
            }
        }

        public void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
            if (combo != null)
            {
                combo.Entree = wrap;
            }
        }

        public void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
            if (combo != null)
            {
                combo.Entree = wrap;
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
