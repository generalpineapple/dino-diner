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
        private CretaceousCombo combo;

        public CustomizeNuggets(DinoNuggets dino)
        {
            InitializeComponent();
            this.dino = dino;
        }

        public CustomizeNuggets(CretaceousCombo dino)
        {
            InitializeComponent();
            this.combo = dino;
            this.dino = dino.Entree as DinoNuggets;
        }

        public void OnAddNugget(object sender, RoutedEventArgs args)
        {            
            dino.AddNugget();
            if(combo != null)
            {
                combo.Entree = dino;
            }
            
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if(combo != null)
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
