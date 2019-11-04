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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public static NavigationService NavigationService {get; set;}
        public OrderControl()
        {
            InitializeComponent();
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if(OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
            if (OrderItems.SelectedItem is Entree entree)
            {
                NavigationService?.Navigate(new EntreeSelection(entree));
            }
            if (OrderItems.SelectedItem is CretaceousCombo combo)
            {
                NavigationService?.Navigate(new CustomizeCombo(combo));
            }
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            MountItemListener();
        }

        private void MountItemListener()
        {
            if (DataContext is Order order)
            {
                //order.Items.PropertyChan += OnCollectionChanged;
            }
        }

        public void OnCollectionChanged(object sender, EventArgs args)
        {
            CollectionViewSource.GetDefaultView(OrderItems.Items).MoveCurrentToLast();
        }

        private void OnRemovedItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)               
                    if (element.DataContext is IOrderItem item)
                        order.Remove(item);
                NavigationService.Navigate(new MenuCatagorySelection());
            }
        }

        private void OnCancel(object sender, RoutedEventArgs args)
        {
            //ToDo
        }

        private void OnPay(object sender, RoutedEventArgs args)
        {
            //ToDo
        }
    }
}
