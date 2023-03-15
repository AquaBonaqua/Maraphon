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
using maraphonapp._2Runner;
using maraphonapp._1Main;

namespace maraphonapp._5UnregUser
{
    /// <summary>
    /// Interaction logic for PageUnUserMain.xaml
    /// </summary>
    public partial class PageUnUserMain : Page
    {
        public PageUnUserMain()
        {
            InitializeComponent();
            
        }

        private void BtnBelive_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageSponsor());
            
        }


        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageLogin());
        }

        private void WantToBegin_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new Page1());
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageInformation());
        }
    }
}
