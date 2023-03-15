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
using Microsoft.Win32;
using maraphonapp.Class;
using maraphonapp._5UnregUser;
using maraphonapp._4Coordinator;
using maraphonapp._3Admin;
using maraphonapp._2Runner;
using maraphonapp._1Main;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace maraphonapp._1Main
{
    /// <summary>
    /// Логика взаимодействия для PageRegRunner.xaml
    /// </summary>
    /// 



    public partial class PageRegRunner : Page
    {
        byte[] image;
        public bool txSearch = false;
        public PageRegRunner()
        {
            InitializeComponent();
            CountryBox.SelectedValuePath = "CountryCode";
            CountryBox.DisplayMemberPath = "CountryName";
            CountryBox.SelectedIndex = 0;
            CountryBox.ItemsSource = AppData.Ent.Countries.ToList();
        }

    private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new Page1());
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            string Pass = TBPass.Password;
            string sym = "!@#$%^";
            
            if (!Regex.IsMatch(TBEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Неверный email");
                TBEmail.Select(0, TBEmail.Text.Length);
                TBEmail.Focus();
                return;
            }

            char[] Array = Pass.ToCharArray();
            if (Array.Length < 6)
            {
                MessageBox.Show("Ошибка! В пароле должно быть более 5 символов!");
                return;
            }
            Regex regex1 = new Regex("[0-9][A-Z]");
            MatchCollection matches = regex1.Matches(Pass);
            if (matches.Count == 0)
            {
                MessageBox.Show("Ошибка! В пароле должны быть минимум 1 цифра и 1 прописная буква!");
                return;
            }


            if (Pass.IndexOfAny(sym.ToCharArray()) == -1)
            {
                MessageBox.Show("Ошибка! Пароль должен содержать один из следующих символов: ! @ # $ % ^");
                return;
            }

            if (TBPass2.Password != Pass)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            if (CBGender.SelectedIndex == 0)
            {
                User user = new User()
                {
                    Email = TBEmail.Text,
                    FirstName = TBName.Text,
                    LastName = TBSurname.Text,
                    RoleId = "R",
                    Password = Pass,

                };

                Runner runner = new Runner()
                {
                    User = user,
                    DateOfBirth = Birthdate.SelectedDate,
                    CountryCode = CountryBox.SelectedValue.ToString(),
                    Gender = "Male",
                    Photo = image,
                };

                AppData.Ent.Users.Add(user);
                AppData.Ent.Runners.Add(runner);
            }
            else
            {
                User user = new User()
                {
                    Email = TBEmail.Text,
                    FirstName = TBName.Text,
                    LastName = TBSurname.Text,
                    RoleId = "R",
                    Password = Pass,

                };

                Runner runner = new Runner()
                {
                    User = user,
                    DateOfBirth = Birthdate.SelectedDate,
                    CountryCode = CountryBox.SelectedValue.ToString(),
                    Gender = "Female",
                    Photo = image,
                };

                AppData.Ent.Users.Add(user);
                AppData.Ent.Runners.Add(runner);
            }
            MessageBox.Show("Вы успешно зарегистрировались!");
            AppData.Ent.SaveChanges();
            AppData.frame.Navigate(new PageLogin());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "Image Files(*.JPG;*.PNG;*.BMP)|*.JPG;*.PNG;*.BMP";

            Nullable<bool> result = File.ShowDialog();

            if (result == true)
            {
                // Open document 
                string filename = File.FileName;

                ImageFile.Text = filename;

                Stream imageStream = new FileStream(File.FileName, FileMode.Open);

                using(MemoryStream ms1 = new MemoryStream())
                {
                    imageStream.CopyTo(ms1);

                    image = ms1.ToArray();
                }

                BitmapImage biImg = new BitmapImage();
                MemoryStream ms2 = new MemoryStream(image);
                biImg.BeginInit();
                biImg.StreamSource = ms2;
                biImg.EndInit();

                ImageSource imgSrc = biImg as ImageSource;

                ImagePhoto.Source = imgSrc;

            }




        }

  

       
        private void TBEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            txSearch = true;

            if (TBEmail.Text == "Email")
            {
                if (txSearch == true)
                {
                    TBEmail.Text = "";
                }
            }
        }

        private void TBEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TBEmail.Text == "")  // here you can also use txtSearch.Text != "Poduct Name", but it could affect your search code possibly 
            {
                TBEmail.Text =  "Email";
            }
        }

        private void TBName_GotFocus(object sender, RoutedEventArgs e)
        {
            txSearch = true;

            if (TBName.Text == "Ваше имя")
            {
                if (txSearch == true)
                {
                    TBName.Text = "";
                }
            }
        }

        private void TBName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TBName.Text == "")  // here you can also use txtSearch.Text != "Poduct Name", but it could affect your search code possibly 
            {
                TBName.Text = "Ваше имя";
            }
        }

        private void TBSurname_GotFocus(object sender, RoutedEventArgs e)
        {
            txSearch = true;

            if (TBSurname.Text == "Ваша фамилия")
            {
                if (txSearch == true)
                {
                    TBSurname.Text = "";
                }
            }
        }

        private void TBSurname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TBSurname.Text == "")  // here you can also use txtSearch.Text != "Poduct Name", but it could affect your search code possibly 
            {
                TBSurname.Text = "Ваша фамилия";
            }
        }
    }
}
