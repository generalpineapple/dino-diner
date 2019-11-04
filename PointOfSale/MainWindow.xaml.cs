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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderControl.NavigationService =  OrderUI.NavigationService;
            Order order = new Order();
            DataContext = order;     
        }

        private void BindDataContextToPage()
        {
            if(OrderUI.Content is Page element)
            {
                element.DataContext = OrderUI.DataContext;
            }
        }

        private void OnLoadComplete(object sender, NavigationEventArgs args)
        {
            BindDataContextToPage();
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            BindDataContextToPage();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (OrderUI.NavigationService.CanGoBack)
            {
                OrderUI.NavigationService.GoBack();
            }
            else
            {
                OrderUI.NavigationService.Navigate(new MenuCatagorySelection());
            }
        }

        private void OnReturn(object sender, RoutedEventArgs args)
        {
            OrderUI.NavigationService.Navigate(new MenuCatagorySelection());
        }
    }
}
