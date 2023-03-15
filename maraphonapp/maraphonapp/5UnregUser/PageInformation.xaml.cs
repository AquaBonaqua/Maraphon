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
using maraphonapp._4Coordinator;
using maraphonapp._3Admin;
using maraphonapp._2Runner;
using maraphonapp._1Main;

namespace maraphonapp._1Main
{
    /// <summary>
    /// Логика взаимодействия для PageInformation.xaml
    /// </summary>
    public partial class PageInformation : Page
    {
        public PageInformation()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageUnUserMain());
        }

        private void MarathonInfo_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageMarathonInfo());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageOrganization());
        }

        private void BtnBMICalc_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageBMI());
        }

        private void BtnBMRCalc_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageBMR());
        }

        private void BtnMarathonLength_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageMarathonLength());
        }

        private void BtnLastResult_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageLastResults());
        }
    }
}
