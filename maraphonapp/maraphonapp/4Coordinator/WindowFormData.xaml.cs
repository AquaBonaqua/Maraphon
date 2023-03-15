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
using System.Windows.Shapes;
using maraphonapp.Class;

namespace maraphonapp._4Coordinator
{
    /// <summary>
    /// Логика взаимодействия для WindowFormData.xaml
    /// </summary>
    public partial class WindowFormData : Window
    {

        RegistrationEvent EditRegistrationEvent;
        public WindowFormData(RegistrationEvent registrationEvent)
        {
            InitializeComponent();
            Status.ItemsSource = AppData.Ent.RegistrationStatus.ToList();
            Status.SelectedValuePath = "RegistrationStatusId";
            Status.DisplayMemberPath = "RegistrationStatus";
            Name.Text = registrationEvent.Registration.Runner.User.FirstName;
            LastName.Text = registrationEvent.Registration.Runner.User.LastName;
            Email.Text = registrationEvent.Registration.Runner.User.Email;
            Status.SelectedValue = registrationEvent.Registration.RegistrationStatusId;
            EditRegistrationEvent = registrationEvent;
        }


        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            EditRegistrationEvent.Registration.Runner.User.FirstName = Name.Text;
            EditRegistrationEvent.Registration.Runner.User.LastName = LastName.Text;
            EditRegistrationEvent.Registration.Runner.User.Email = Email.Text;
            EditRegistrationEvent.Registration.RegistrationStatusId = (byte)Status.SelectedValue;
            AppData.Ent.SaveChanges();
            MessageBox.Show("Saved!");
        }
    }
}
