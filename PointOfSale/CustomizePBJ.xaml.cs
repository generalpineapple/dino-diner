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
    /// Interaction logic for CustomizePBJ.xaml
    /// </summary>
    public partial class CustomizePBJ : Page
    {
        private PrehistoricPBJ pbj;
        private CretaceousCombo combo;

        public CustomizePBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        public CustomizePBJ(CretaceousCombo pbj)
        {
            InitializeComponent();
            this.pbj = pbj.Entree as PrehistoricPBJ;
            combo = pbj;
        }

        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
            if (combo != null)
            {
                combo.Entree = pbj;
            }

        }

        private void OnHoldPB(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
            if (combo != null)
            {
                combo.Entree = pbj;
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
