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
            SelectEntree(new Brontowurst());
        }

        protected void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            SelectEntree(new DinoNuggets());
        }

        protected void OnSelectSteak(object sender, RoutedEventArgs args)
        {
            SelectEntree(new SteakosaurusBurger());
        }

        protected void OnSelectTRex(object sender, RoutedEventArgs args)
        {
            SelectEntree(new TRexKingBurger());
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
            SelectEntree(new VelociWrap());
        }
    }
}
