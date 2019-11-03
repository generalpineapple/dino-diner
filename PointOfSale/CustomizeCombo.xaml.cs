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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo combo;

        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            if (combo.Entree is Brontowurst)
                NavigationService.Navigate(new CustomizeBrontowurst(combo.Entree as Brontowurst));
            else if (combo.Entree is DinoNuggets)
                NavigationService.Navigate(new CustomizeNuggets(combo.Entree as DinoNuggets));
            else if (combo.Entree is PrehistoricPBJ)
                NavigationService.Navigate(new CustomizePBJ(combo.Entree as PrehistoricPBJ));
            else if (combo.Entree is SteakosaurusBurger)
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo.Entree as SteakosaurusBurger));
            else if (combo.Entree is TRexKingBurger)
                NavigationService.Navigate(new CustomizeTRex(combo.Entree as TRexKingBurger));
            else if (combo.Entree is VelociWrap)
                NavigationService.Navigate(new CustomizeWrap(combo.Entree as VelociWrap));
        }
        private void ChangeSide(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        private void ChangeDrink(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }

}
