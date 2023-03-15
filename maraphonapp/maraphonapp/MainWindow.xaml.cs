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

namespace maraphonapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public MainWindow()
        {
            InitializeComponent();
            TxtDate.Text = DateTime.Now.ToLongDateString();
            AppData.frame = MainFrame;

            AppData.Ent = new user16Entities();

            MainFrame.Navigate(new PageUnUserMain());
            DateTime otherDate = new DateTime(2019,01,01);
            TimeSpan remaining = otherDate.Subtract(DateTime.Now);
            int daysLeft = Convert.ToInt32(remaining.TotalDays);
            double HoursLeft = remaining.Hours;
            double minutesLeft = remaining.Minutes;
            TB1.Text = "До конца мероприятия осталось " + daysLeft + " дней " + HoursLeft + " часов " + minutesLeft + " минут.";
        }

        
    }
}
