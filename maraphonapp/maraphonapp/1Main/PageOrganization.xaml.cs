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
using maraphonapp.Class;
using maraphonapp._5UnregUser;
using maraphonapp._4Coordinator;
using maraphonapp._3Admin;
using maraphonapp._2Runner;
using maraphonapp._1Main;
namespace maraphonapp._1Main
{
    /// <summary>
    /// Interaction logic for PageOrganization.xaml
    /// </summary>
    public partial class PageOrganization : Page
    {
        public PageOrganization()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageInformation());
        }
    }
}
