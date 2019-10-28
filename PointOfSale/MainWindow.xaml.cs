﻿using System;
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
            order.Items.Add(new Tyrannotea());
            order.Items.Add(new Sodasaurus());        
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
    }
}
