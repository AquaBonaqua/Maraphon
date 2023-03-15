﻿using maraphonapp.Class;
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
using maraphonapp._5UnregUser;
using maraphonapp._4Coordinator;
using maraphonapp._3Admin;
using maraphonapp._2Runner;
using maraphonapp._1Main;


namespace maraphonapp._4Coordinator
{
    /// <summary>
    /// Interaction logic for PageCoordinator.xaml
    /// </summary>
    public partial class PageCoordinator : Page
    {
        public PageCoordinator()
        {
            InitializeComponent();
        }

        private void BrnRunner_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageRunners());
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            AppData.User = null;
            AppData.frame.Navigate(new PageLogin());
          
        }

        private void BtnSponsor_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageSponsors());
        }
    }
}
