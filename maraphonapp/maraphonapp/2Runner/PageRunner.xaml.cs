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
using maraphonapp.Class;
using maraphonapp._5UnregUser;
using maraphonapp._2Runner;
using maraphonapp._1Main;
using maraphonapp._3Admin;
using maraphonapp._4Coordinator;

namespace maraphonapp._2Runner
{
    /// <summary>
    /// Interaction logic for PageRunner.xaml
    /// </summary>
    public partial class PageRunner : Page
    {
        public PageRunner()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            AppData.User = null;
            AppData.frame.Navigate(new PageLogin());
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
           WindowContact a = new WindowContact();
           a.Show();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageRegOnMarathon());
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageMyResults());
        }

        private void BtnEditProfile_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageEditProfile());
        }

        private void BtnSponsor_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageMySponsor());
        }
    }
}
