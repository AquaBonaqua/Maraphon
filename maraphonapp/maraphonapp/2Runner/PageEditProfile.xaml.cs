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
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace maraphonapp._2Runner
{
    /// <summary>
    /// Логика взаимодействия для PageEditProfile.xaml
    /// </summary>
    public partial class PageEditProfile : Page
    {
        byte[] image;
        Runner runner = AppData.Ent.Runners.FirstOrDefault(x => x.Email == AppData.User.Email);
        public PageEditProfile()
        {
            InitializeComponent();

            Email.Text = AppData.User.Email;

            CountryBox.SelectedValuePath = "CountryCode";
            CountryBox.DisplayMemberPath = "CountryName";
            CountryBox.SelectedIndex = 0;
            CountryBox.ItemsSource = AppData.Ent.Countries.ToList();
            if (runner.Photo != null)
            {
                BitmapImage biImg = new BitmapImage();
                MemoryStream ms2 = new MemoryStream(runner.Photo);
                biImg.BeginInit();
                biImg.StreamSource = ms2;
                biImg.EndInit();
                ImageSource imgSrc = biImg as ImageSource;
                ImagePhoto.Source = imgSrc;
            }
            else
            { }


        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageRunner());
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageLogin());
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            AppData.User.FirstName = TBName.Text;
            AppData.User.LastName = TBLastName.Text;


            runner.Gender = CBGender.SelectedValue.ToString();
            runner.DateOfBirth = Birthdate.SelectedDate;
            runner.CountryCode = CountryBox.SelectedValue.ToString();
            runner.Photo = image;
            string Pass = TBPass.Password;
            string sym = "!@#$%^";

            

            char[] Array = Pass.ToCharArray();
            if (Array.Length < 6)
            {
                MessageBox.Show("Ошибка! Вы ввели меньше 6 символов!");
                return;
            }
            Regex regex1 = new Regex("[0-9][A-Z]");
            MatchCollection matches = regex1.Matches(Pass);
            if (matches.Count == 0)
            {
                MessageBox.Show("Ошибка! Минимум 1 цифра и 1 прописная буква!");
                return;
            }


            if (Pass.IndexOfAny(sym.ToCharArray()) == -1)
            {
                MessageBox.Show("Ошибка! По крайней мере один из следующих символов: ! @ # $ % ^");
                return;
            }

            if (TBPass2.Password != Pass)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            AppData.User.Password = Pass;
            AppData.Ent.SaveChanges();
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

                using (MemoryStream ms1 = new MemoryStream())
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
    }
}
