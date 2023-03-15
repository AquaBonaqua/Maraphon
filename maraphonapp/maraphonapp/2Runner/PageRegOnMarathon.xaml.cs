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

namespace maraphonapp._2Runner
{
    /// <summary>
    /// Логика взаимодействия для PageRegOnMarathon.xaml
    /// </summary>
    /// 
   

    public partial class PageRegOnMarathon : Page
    {
        

        public PageRegOnMarathon()
        {
            InitializeComponent();
            Type1.IsChecked = true;
            Charity.SelectedValuePath = "CharityId";
            Charity.DisplayMemberPath = "CharityName";
            Charity.ItemsSource = AppData.Ent.Charities.ToList();
            
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageSponsor());
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageUnUserMain());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageRunner());
        }
        public void sum()
        {
            int a = 0, b = 0, c = 0, d = 0, f = 0, g = 0;
            
            if (Type1.IsChecked == true) { a = 145; }
            else { a = 0; }
            if (Type2.IsChecked == true) { b = 75; }
            else { b = 0; }
            if (Type3.IsChecked == true) { c = 20; }
            else { c = 0; }
            if (Type4.IsChecked == true) { d = 0; }
            else { d = 0; }
            if (Type5.IsChecked == true) { f = 20; }
            else { f = 0; }
            if (Type6.IsChecked == true) { g = 45; }
            else { g = 0; }

            Cost.Text = (a + b + c + d + f + g).ToString();
        }
        

        public void BtnReg_Click(object sender, RoutedEventArgs e)
        {
           
            
            

            string Option = null;
            if (Type4.IsChecked == true)
            {
                Option = "A";
            }
            if (Type5.IsChecked == true)
            {
                Option = "B"; 
            }
            if (Type6.IsChecked == true)
            {
                Option = "C"; 
            }

            Runner runner = AppData.Ent.Runners.FirstOrDefault(x => x.Email == AppData.User.Email);


            Registration reg = new Registration()
            {
                Runner = runner,
                RunnerId = runner.RunnerId,
                RegistrationDateTime = DateTime.Now,
                RaceKitOptionId = Option,
                RegistrationStatusId = 1,
                CharityId = Convert.ToInt32(Charity.SelectedValue),
                SponsorshipTarget = Convert.ToInt32(Target.Text),
                Cost = Convert.ToInt32(Cost.Text),
            };

            


            AppData.Ent.Registrations.Add(reg);
            AppData.Ent.SaveChanges();
            MessageBox.Show("Спасибо за регистрацию и пожертвование!");
            AppData.frame.Navigate(new PageRunner());
        }
       

        private void Type4_Checked(object sender, RoutedEventArgs e)
        {
            Type5.IsChecked = false;
            Type6.IsChecked = false;
            sum();
        }

        private void Type5_Checked(object sender, RoutedEventArgs e)
        {
            Type4.IsChecked = false;
            Type6.IsChecked = false;
            sum();
        }

        private void Type6_Checked(object sender, RoutedEventArgs e)
        {
            Type4.IsChecked = false;
            Type5.IsChecked = false;
            sum();
        }

        private void Type1_Checked(object sender, RoutedEventArgs e)
        {
            sum();
        }

        private void Type2_Checked(object sender, RoutedEventArgs e)
        {
            sum();
        }

        private void Type3_Checked(object sender, RoutedEventArgs e)
        {
            sum();
        }

        private void Type1_Unchecked(object sender, RoutedEventArgs e)
        {
            sum();
        }

        private void Type2_Unchecked(object sender, RoutedEventArgs e)
        {
            sum();
        }

        private void Type3_Unchecked(object sender, RoutedEventArgs e)
        {
            sum();
        }

        private void Type4_Unchecked(object sender, RoutedEventArgs e)
        {
            sum();
        }

        private void Type5_Unchecked(object sender, RoutedEventArgs e)
        {
            sum();
        }

        private void Type6_Unchecked(object sender, RoutedEventArgs e)
        {
            sum();
        }
    }
}
