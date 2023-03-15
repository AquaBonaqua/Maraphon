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
    /// Interaction logic for PageBMR.xaml
    /// </summary>
    public partial class PageBMR : Page
    {
        int check;

        public PageBMR()
        {
            InitializeComponent();
            
        }

       

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageInformation());
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {   
            if (check == 1)
            {
                double height = double.Parse(Height.Text);
                double weight = double.Parse(Weight.Text);
                int age = int.Parse(Age.Text);
                double result = 10 * weight + 6.25 * height - 5 * age + 5;
                BMR.Text = result.ToString("0,000");
            }

            if (check == 2)
            {
                double height = double.Parse(Height.Text);
                double weight = double.Parse(Weight.Text);
                int age = int.Parse(Age.Text);
                double result = 10 * weight + 6.25 * height - 5 * age - 161;
                BMR.Text = result.ToString("0,000");
            }

        }

       
   

        private void Male_Checked(object sender, RoutedEventArgs e)
        {
            check = 1;
            Female.IsChecked = false;
        }

        private void Female_Checked(object sender, RoutedEventArgs e)
        {
            check = 2;
            Male.IsChecked = false;
        }
    }
}
