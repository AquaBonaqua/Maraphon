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
    /// Interaction logic for PageMarathonLength.xaml
    /// </summary>
    public partial class PageMarathonLength : Page
    {
        public PageMarathonLength()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageInformation());
        }

        private void StackPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "F1 Car";
            var uriSource = new Uri(@"/Resource/HowLong/f1-car.jpg", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Скорость - 345km/h";
            SelectedInfo2.Text = "Время для преодоления - 7 минут 18 секунд";
          
        }

        private void StackPanel_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "Slug";
            var uriSource = new Uri(@"/Resource/HowLong/slug.jpg", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Скорость - 0.01km/h";
            SelectedInfo2.Text = "Время для преодоления - 4200 часов";

        }

        private void StackPanel_PreviewMouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "Horse";
            var uriSource = new Uri(@"/Resource/HowLong/horse.png", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Скорость - 15km/h";
            SelectedInfo2.Text = "Время для преодоления - 2 часа 48 минут";
        }

        private void StackPanel_PreviewMouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "Sloth";
            var uriSource = new Uri(@"/Resource/HowLong/sloth.jpg", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Скорость - 0.12km/h";
            SelectedInfo2.Text = "Время для преодоления - 350 часов";
        }

        private void StackPanel_PreviewMouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "Capybara";
            var uriSource = new Uri(@"/Resource/HowLong/Capybara.jpg", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Скорость - 35km/h";
            SelectedInfo2.Text = "Время для преодоления - 1 час 12 минут";
        }

        private void StackPanel_PreviewMouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "Jaguar";
            var uriSource = new Uri(@"/Resource/HowLong/jaguar.jpg", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Скорость - 80km/h";
            SelectedInfo2.Text = "Время для преодоления - 31 минута 30 секунд";
        }

        private void StackPanel_PreviewMouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "Worm";
            var uriSource = new Uri(@"/Resource/HowLong/worm.jpg", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Скорость - 0.03km/h";
            SelectedInfo2.Text = "Время для преодоления - 1400 часов";
        }

        private void StackPanel_PreviewMouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "Bus";
            var uriSource = new Uri(@"/Resource/HowLong/bus.jpg", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Длина - 10m";
            SelectedInfo2.Text = "4200 - количество элементов  для преодоления.";
        }

        private void StackPanel_PreviewMouseLeftButtonDown_8(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "Pair of Havaianas";
            var uriSource = new Uri(@"/Resource/HowLong/pair-of-havaianas.jpg", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Длина - 0.245m";
            SelectedInfo2.Text = "171 428 - количество элементов  для преодоления.";
        }

        private void StackPanel_PreviewMouseLeftButtonDown_9(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "Airbus A380";
            var uriSource = new Uri(@"/Resource/HowLong/airbus-a380.jpg", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Длина - 73m";
            SelectedInfo2.Text = "575 - количество элементов для преодоления.";
        }

        private void StackPanel_PreviewMouseLeftButtonDown_10(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "Football Field";
            var uriSource = new Uri(@"/Resource/HowLong/football-field.jpg", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Длина - 105m";
            SelectedInfo2.Text = "400 - количество элементов для преодоления.";
        }

        private void StackPanel_PreviewMouseLeftButtonDown_11(object sender, MouseButtonEventArgs e)
        {
            Selected.Text = "Ronaldinho";
            var uriSource = new Uri(@"/Resource/HowLong/ronaldinho.jpg", UriKind.Relative);
            imgSelected.Source = new BitmapImage(uriSource);
            SelectedInfo.Text = "Длина - 1.81m";
            SelectedInfo2.Text = "23 204 - количество элементов для преодоления.";
        }
    }

}
