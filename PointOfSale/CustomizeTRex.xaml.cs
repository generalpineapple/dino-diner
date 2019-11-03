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
    /// Interaction logic for CustomizeTRex.xaml
    /// </summary>
    public partial class CustomizeTRex : Page
    {
        private TRexKingBurger bur;

        public CustomizeTRex(TRexKingBurger bur)
        {
            InitializeComponent();
            this.bur = bur;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            bur.HoldBun();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            bur.HoldPickle();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            bur.HoldMustard();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            bur.HoldKetchup();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            bur.HoldLettuce();
        }

        private void OnHoldOnions(object sender, RoutedEventArgs args)
        {
            bur.HoldMayo();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            bur.HoldTomato();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
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
