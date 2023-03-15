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
using System.Data.SqlClient;

namespace maraphonapp._1Main
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageUnUserMain());
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AppData.User = AppData.Ent.Users.FirstOrDefault(x => x.Email == TbLog.Text && x.Password == TbPass.Password);

            if(AppData.User == null)
            {
                MessageBox.Show("Ошибка! Неверный логин или пароль!");
            }
            else
            {
                switch (AppData.User.RoleId)
                {
                    case "A": AppData.frame.Navigate(new PageAdmin());
                        break;
                    case "R": AppData.frame.Navigate(new PageRunner());
                        break;
                    case "C": AppData.frame.Navigate(new PageCoordinator());
                        break;
                }
            }
        }

        private void admin_Click(object sender, RoutedEventArgs e)
        {
            AppData.User = AppData.Ent.Users.FirstOrDefault(x => x.Email == "leila.azedeva@mskills.com" && x.Password == "MvTQ3itX");
            AppData.frame.Navigate(new PageAdmin());

        }

        private void coordinator_Click(object sender, RoutedEventArgs e)
        {
            AppData.User = AppData.Ent.Users.FirstOrDefault(x => x.Email == "dean.pinilla@gmail.com" && x.Password == "WQnbEyjo");
            AppData.frame.Navigate(new PageCoordinator());
        }

        private void runner_Click(object sender, RoutedEventArgs e)
        {
            AppData.User = AppData.Ent.Users.FirstOrDefault(x => x.Email == "a.adkin@dayrep.net" && x.Password == "jwZh2x@p");
            AppData.frame.Navigate(new PageRunner());
        }
    }
}
