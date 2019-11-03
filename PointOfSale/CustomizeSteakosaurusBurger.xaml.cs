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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        private SteakosaurusBurger bur;
        private CretaceousCombo combo;

        public CustomizeSteakosaurusBurger(SteakosaurusBurger bur)
        {
            InitializeComponent();
            this.bur = bur;
        }

        public CustomizeSteakosaurusBurger(CretaceousCombo bur)
        {
            InitializeComponent();
            this.bur = bur.Entree as SteakosaurusBurger;
            combo = bur;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            bur.HoldBun();
            if (combo != null)
            {
                combo.Entree = bur;
            }
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            bur.HoldPickle();
            if (combo != null)
            {
                combo.Entree = bur;
            }
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            bur.HoldMustard();
            if (combo != null)
            {
                combo.Entree = bur;
            }
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            bur.HoldKetchup();
            if (combo != null)
            {
                combo.Entree = bur;
            }
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
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