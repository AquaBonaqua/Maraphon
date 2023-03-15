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


namespace maraphonapp._2Runner
{
    /// <summary>
    /// Логика взаимодействия для PageMyResults.xaml
    /// </summary>
    public partial class PageMyResults : Page
    {
        public PageMyResults()
        {
            InitializeComponent();
        }

        private void AllResults_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageLastResults());
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageLogin());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageRunner());
        }
    }
}
