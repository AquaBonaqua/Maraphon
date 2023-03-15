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
    /// Interaction logic for PageMap.xaml
    /// </summary>
    public partial class PageMap : Page
    {
        public PageMap()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageMarathonInfo());
        }

        private void Ellipse_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Panel1.Visibility = Visibility.Visible;
            Panel2.Visibility = Visibility.Hidden;
            Panel3.Visibility = Visibility.Hidden;
            Panel4.Visibility = Visibility.Hidden;
            Panel5.Visibility = Visibility.Hidden;
            Panel6.Visibility = Visibility.Hidden;
            Panel7.Visibility = Visibility.Hidden;
            Panel8.Visibility = Visibility.Hidden;

        }

        private void Ellipse_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Panel1.Visibility = Visibility.Hidden;
            Panel2.Visibility = Visibility.Visible;
            Panel3.Visibility = Visibility.Hidden;
            Panel4.Visibility = Visibility.Hidden;
            Panel5.Visibility = Visibility.Hidden;
            Panel6.Visibility = Visibility.Hidden;
            Panel7.Visibility = Visibility.Hidden;
            Panel8.Visibility = Visibility.Hidden;


        }

        private void Ellipse_PreviewMouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            Panel1.Visibility = Visibility.Hidden;
            Panel2.Visibility = Visibility.Hidden;
            Panel3.Visibility = Visibility.Visible;
            Panel4.Visibility = Visibility.Hidden;
            Panel5.Visibility = Visibility.Hidden;
            Panel6.Visibility = Visibility.Hidden;
            Panel7.Visibility = Visibility.Hidden;
            Panel8.Visibility = Visibility.Hidden;

        }

        private void Ellipse_PreviewMouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            Panel1.Visibility = Visibility.Hidden;
            Panel2.Visibility = Visibility.Hidden;
            Panel3.Visibility = Visibility.Hidden;
            Panel4.Visibility = Visibility.Visible;
            Panel5.Visibility = Visibility.Hidden;
            Panel6.Visibility = Visibility.Hidden;
            Panel7.Visibility = Visibility.Hidden;
            Panel8.Visibility = Visibility.Hidden;


        }

        private void Ellipse_PreviewMouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            Panel1.Visibility = Visibility.Hidden;
            Panel2.Visibility = Visibility.Hidden;
            Panel3.Visibility = Visibility.Hidden;
            Panel4.Visibility = Visibility.Hidden;
            Panel5.Visibility = Visibility.Visible;
            Panel6.Visibility = Visibility.Hidden;
            Panel7.Visibility = Visibility.Hidden;
            Panel8.Visibility = Visibility.Hidden;

        }

        private void Ellipse_PreviewMouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            Panel1.Visibility = Visibility.Hidden;
            Panel2.Visibility = Visibility.Hidden;
            Panel3.Visibility = Visibility.Hidden;
            Panel4.Visibility = Visibility.Hidden;
            Panel5.Visibility = Visibility.Hidden;
            Panel6.Visibility = Visibility.Visible;
            Panel7.Visibility = Visibility.Hidden;
            Panel8.Visibility = Visibility.Hidden;


        }

        private void Ellipse_PreviewMouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            Panel1.Visibility = Visibility.Hidden;
            Panel2.Visibility = Visibility.Hidden;
            Panel3.Visibility = Visibility.Hidden;
            Panel4.Visibility = Visibility.Hidden;
            Panel5.Visibility = Visibility.Hidden;
            Panel6.Visibility = Visibility.Hidden;
            Panel7.Visibility = Visibility.Visible;
            Panel8.Visibility = Visibility.Hidden;

        }

        private void Ellipse_PreviewMouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            Panel1.Visibility = Visibility.Hidden;
            Panel2.Visibility = Visibility.Hidden;
            Panel3.Visibility = Visibility.Hidden;
            Panel4.Visibility = Visibility.Hidden;
            Panel5.Visibility = Visibility.Hidden;
            Panel6.Visibility = Visibility.Hidden;
            Panel7.Visibility = Visibility.Hidden;
            Panel8.Visibility = Visibility.Visible;

        }

        private void Image_PreviewMouseLeftButtonDown1(object sender, MouseButtonEventArgs e)
        {
            Panel1.Visibility = Visibility.Hidden;
        }

        private void Image_PreviewMouseLeftButtonDown2(object sender, MouseButtonEventArgs e)
        {
            Panel2.Visibility = Visibility.Hidden;
        }

        private void Image_PreviewMouseLeftButtonDown3(object sender, MouseButtonEventArgs e)
        {
            Panel3.Visibility = Visibility.Hidden;
        }

        private void Image_PreviewMouseLeftButtonDown4(object sender, MouseButtonEventArgs e)
        {
            Panel4.Visibility = Visibility.Hidden;
        }

        private void Image_PreviewMouseLeftButtonDown5(object sender, MouseButtonEventArgs e)
        {
            Panel5.Visibility = Visibility.Hidden;
        }

        private void Image_PreviewMouseLeftButtonDown6(object sender, MouseButtonEventArgs e)
        {
            Panel6.Visibility = Visibility.Hidden;
        }

        private void Image_PreviewMouseLeftButtonDown7(object sender, MouseButtonEventArgs e)
        {
            Panel7.Visibility = Visibility.Hidden;
        }

        private void Image_PreviewMouseLeftButtonDown8(object sender, MouseButtonEventArgs e)
        {
            Panel8.Visibility = Visibility.Hidden;
        }
    }
}
