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
using System.Data.SqlClient;
using maraphonapp.Class;
using maraphonapp._5UnregUser;
using maraphonapp._4Coordinator;
using maraphonapp._3Admin;
using maraphonapp._2Runner;
using maraphonapp._1Main;

namespace maraphonapp._3Admin
{
    /// <summary>
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        public PageAdmin()
        {
            InitializeComponent();
        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageUsers());
        }

        private void Volunteers_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageVolunteers());
        }

        private void Charity_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageCharity());
        }

       

        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageInventory());
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            AppData.User = null;
            AppData.frame.Navigate(new PageLogin());
        }
    }
}
