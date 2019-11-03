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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public Entree Entree { get; set; }

        public EntreeSelection()
        {
            InitializeComponent();
        }

        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }

        private void SelectEntree(Entree entree)
        {

            if (DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
            }
        }

        protected void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            Brontowurst bron = new Brontowurst();
            SelectEntree(bron);
            NavigationService.Navigate(new CustomizeBrontowurst(bron));
        }

        protected void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            DinoNuggets nugs = new DinoNuggets();
            SelectEntree(nugs);
            NavigationService.Navigate(new CustomizeNuggets(nugs));
        }

        protected void OnSelectSteak(object sender, RoutedEventArgs args)
        {
            SteakosaurusBurger bur = new SteakosaurusBurger();
            SelectEntree(bur);
            NavigationService.Navigate(new CustomizeSteakosaurusBurger(bur));
        }

        protected void OnSelectTRex(object sender, RoutedEventArgs args)
        {
            TRexKingBurger bur = new TRexKingBurger();
            SelectEntree(bur);
            NavigationService.Navigate(new CustomizeTRex(bur));
        }

        protected void OnSelectWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
        }

        protected void OnSelectPBJ(object sender, RoutedEventArgs args)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            SelectEntree(pbj);
            NavigationService.Navigate(new CustomizePBJ(pbj));
        }

        protected void OnSelectWrap(object sender, RoutedEventArgs args)
        {
            VelociWrap wrap = new VelociWrap();
            SelectEntree(wrap);
            NavigationService.Navigate(new CustomizeWrap(wrap));
        }
    }
}
