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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {

        public Side Side { get; set; }
        private DinoDiner.Menu.Size Size { get; set; } = DinoDiner.Menu.Size.Small;

        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            this.Side = side;
        }

        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                this.Side = side;
                side.Size = this.Size;
                order.Add(Side);                
                NavigationService.Navigate(new MenuCatagorySelection());
            }           
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side == null)
                Size = size;
            else
            {
                if (DataContext is Order order)
                {
                    order.Remove(Side);
                    Side.Size = size;
                    this.Size = size;
                    order.Add(Side);
                    NavigationService.Navigate(new MenuCatagorySelection());
                }
            }
        }

        protected void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        protected void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        protected void OnSelectMozzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        protected void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
    }
}
