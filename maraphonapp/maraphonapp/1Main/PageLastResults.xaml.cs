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
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace maraphonapp._1Main
{
    /// <summary>
    /// Логика взаимодействия для PageLastResults.xaml
    /// </summary>
    public partial class PageLastResults : Page
    {

        public PageLastResults()
        {

            InitializeComponent();
            

            Marathon.ItemsSource = AppData.Ent.Events.ToList();
            Marathon.SelectedValuePath = "EventId";
            Marathon.DisplayMemberPath = "EventName";
            Marathon.SelectedIndex = 0;
            Distance.ItemsSource = AppData.Ent.EventTypes.ToList();
            Distance.SelectedValuePath = "EventTypeId";
            Distance.DisplayMemberPath = "EventTypeName";
            Distance.SelectedIndex = 0;

            CBGender.ItemsSource = AppData.Ent.Genders.ToList();
            CBGender.SelectedValuePath = "GenderHuman";
            CBGender.DisplayMemberPath = "GenderHuman";
            CBGender.SelectedIndex = 0;

            CBAge.SelectedIndex = 0;
           
           

        }
        
        private void Update()
        { // сортировка по комбобоксам
            {
                DateTime now = DateTime.Today;
                if (CBAge.SelectedIndex == 0)
                {
                    grid.ItemsSource = null;
                    grid.ItemsSource = AppData.Ent.RegistrationEvents.Where(x => x.EventId == Marathon.SelectedValue.ToString() && x.Event.EventType.EventTypeId == Distance.SelectedValue.ToString() && x.Registration.Runner.Gender == (string)CBGender.SelectedValue && now.Year - x.Registration.Runner.DateOfBirth.Value.Year < 18).ToList();
                }

                if (CBAge.SelectedIndex == 1)
                {
                    grid.ItemsSource = null;
                    grid.ItemsSource = AppData.Ent.RegistrationEvents.Where(x => x.EventId == Marathon.SelectedValue.ToString() && x.Event.EventType.EventTypeId == Distance.SelectedValue.ToString() && x.Registration.Runner.Gender == (string)CBGender.SelectedValue && now.Year - x.Registration.Runner.DateOfBirth.Value.Year > 18 && now.Year - x.Registration.Runner.DateOfBirth.Value.Year < 29).ToList();
                }

                if (CBAge.SelectedIndex == 2)
                {
                    grid.ItemsSource = null;
                    grid.ItemsSource = AppData.Ent.RegistrationEvents.Where(x => x.EventId == Marathon.SelectedValue.ToString() && x.Event.EventType.EventTypeId == Distance.SelectedValue.ToString() && x.Registration.Runner.Gender == (string)CBGender.SelectedValue && now.Year - x.Registration.Runner.DateOfBirth.Value.Year > 30 && now.Year - x.Registration.Runner.DateOfBirth.Value.Year < 39).ToList();
                }

                if (CBAge.SelectedIndex == 3)
                {
                    grid.ItemsSource = null;
                    grid.ItemsSource = AppData.Ent.RegistrationEvents.Where(x => x.EventId == Marathon.SelectedValue.ToString() && x.Event.EventType.EventTypeId == Distance.SelectedValue.ToString() && x.Registration.Runner.Gender == (string)CBGender.SelectedValue && now.Year - x.Registration.Runner.DateOfBirth.Value.Year > 40 && now.Year - x.Registration.Runner.DateOfBirth.Value.Year < 55).ToList();
                }

                if (CBAge.SelectedIndex == 4)
                {
                    grid.ItemsSource = null;
                    grid.ItemsSource = AppData.Ent.RegistrationEvents.Where(x => x.EventId == Marathon.SelectedValue.ToString() && x.Event.EventType.EventTypeId == Distance.SelectedValue.ToString() && x.Registration.Runner.Gender == (string)CBGender.SelectedValue && now.Year - x.Registration.Runner.DateOfBirth.Value.Year > 56 && now.Year - x.Registration.Runner.DateOfBirth.Value.Year < 70).ToList();
                }

                if (CBAge.SelectedIndex == 5)
                {
                    grid.ItemsSource = null;
                    grid.ItemsSource = AppData.Ent.RegistrationEvents.Where(x => x.EventId == Marathon.SelectedValue.ToString() && x.Event.EventType.EventTypeId == Distance.SelectedValue.ToString() && x.Registration.Runner.Gender == (string)CBGender.SelectedValue && now.Year - x.Registration.Runner.DateOfBirth.Value.Year > 70).ToList();
                }

            }

        }



        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageInformation());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

    
    }
}
