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
    /// Interaction logic for PageBMI.xaml
    /// </summary>
    public partial class PageBMI : Page
    {
        public PageBMI()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageInformation());
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {   
            if (Height.Text.Contains('.'))
            {
                Height.Text = Height.Text.Replace(".",",");
                
            }

            if (Weight.Text.Contains('.'))
            {
                Weight.Text = Weight.Text.Replace(".",",");

            }


            double a = double.Parse(Height.Text);
                a = a / 100;
                double b = double.Parse(Weight.Text);
                double c = b / Math.Pow(a, 2);
                Total.Text = c.ToString("00.00");

                if (c < 18.5)
                {

                    var uriSource = new Uri(@"/Resource/bmi-underweight-icon.png", UriKind.Relative);
                    ImgResult.Source = new BitmapImage(uriSource);
                }

                if (c > 18.5 && c < 25)
                {
                    var uriSource = new Uri(@"/Resource/bmi-healthy-icon.png", UriKind.Relative);
                    ImgResult.Source = new BitmapImage(uriSource);
                }

                if (c > 25 && c < 30)
                {
                    var uriSource = new Uri(@"/Resource/bmi-overweight-icon.png", UriKind.Relative);
                    ImgResult.Source = new BitmapImage(uriSource);
                }

                if (c > 30)
                {
                    var uriSource = new Uri(@"/Resource/bmi-obese-icon.png", UriKind.Relative);
                    ImgResult.Source = new BitmapImage(uriSource);
                }

                slider1.Value = c;
            
        }

    

        private void Male_Checked(object sender, RoutedEventArgs e)
        {
            Female.IsChecked = false;
        }

        private void Female_Checked(object sender, RoutedEventArgs e)
        {
            Male.IsChecked = false;
        }
    }
}
 