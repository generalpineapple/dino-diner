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
    /// Interaction logic for CustomizeNuggets.xaml
    /// </summary>
    public partial class CustomizeNuggets : Page
    {
        private DinoNuggets dino;

        public CustomizeNuggets(DinoNuggets dino)
        {
            InitializeComponent();
            this.dino = dino;
        }

        public void OnAddNugget(object sender, RoutedEventArgs args)
        {
            dino.AddNugget();
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
