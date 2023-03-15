using maraphonapp.Class;
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
using maraphonapp._5UnregUser;
using maraphonapp._4Coordinator;
using maraphonapp._3Admin;
using maraphonapp._2Runner;
using maraphonapp._1Main;
using System.IO;
using Microsoft.Win32;


using System.Data;

namespace maraphonapp._4Coordinator
{
    /// <summary>
    /// Interaction logic for PageRunners.xaml
    /// </summary>
    public partial class PageRunners : Page
    {
        


        public PageRunners()
        {
            InitializeComponent();
            
            CmbStatus.ItemsSource = AppData.Ent.RegistrationStatus.ToList();
            CmbStatus.SelectedValuePath = "RegistrationStatusId";
            CmbStatus.DisplayMemberPath = "RegistrationStatus";
            CmbDistance.ItemsSource = AppData.Ent.EventTypes.ToList();
            CmbDistance.SelectedValuePath = "EventTypeId";
            CmbDistance.DisplayMemberPath = "EventTypeName";
            grid.ItemsSource = AppData.Ent.RegistrationEvents.ToList();
            Update();

        }

        public void UpdateTable()
        {
            grid.ItemsSource = AppData.Ent.Runners.ToList();
        }

        private void Update()
        {
            grid.ItemsSource = null;
            grid.ItemsSource = AppData.Ent.RegistrationEvents.Where(x => x.Registration.RegistrationStatusId == (byte)CmbStatus.SelectedValue && x.Event.EventType.EventTypeId == CmbDistance.SelectedValue.ToString()).ToList();
          
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowFormData editform = new WindowFormData((sender as Button).DataContext as RegistrationEvent);
            
            editform.Show();   
        }

        private void Email_Click(object sender, RoutedEventArgs e)


        {

            string[] stroki = AppData.Ent.RegistrationEvents.Where(x => x.Registration.RegistrationStatusId == (byte)CmbStatus.SelectedValue && x.Event.EventType.EventTypeId == CmbDistance.SelectedValue.ToString());









        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppData.frame.Navigate(new PageCoordinator());
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            AppData.User = null;
            AppData.frame.Navigate(new PageLogin());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                grid.Columns[4].Visibility = Visibility.Visible;
                grid.Columns[5].Visibility = Visibility.Visible;
                grid.Columns[6].Visibility = Visibility.Visible;
                grid.Columns[7].Visibility = Visibility.Visible;
                grid.Columns[8].Visibility = Visibility.Visible;
                LoadLbl.Visibility = Visibility.Visible;

                SaveFileDialog File = new SaveFileDialog();
                File.Filter = "CSV(*.CSV)|*.CSV";

                Nullable<bool> result = File.ShowDialog();

                if (result == true)
                {

                    // Open document 
                    string filename = File.FileName;
                    grid.SelectAllCells();
                    grid.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
                    ApplicationCommands.Copy.Execute(null, grid);
                    grid.UnselectAllCells();
                    System.IO.File.WriteAllText(filename, (string)System.Windows.Clipboard.GetData(System.Windows.DataFormats.CommaSeparatedValue), UnicodeEncoding.UTF8);

                }
                LoadLbl.Visibility = Visibility.Collapsed;
                grid.Columns[4].Visibility = Visibility.Collapsed;
                grid.Columns[5].Visibility = Visibility.Collapsed;
                grid.Columns[6].Visibility = Visibility.Collapsed;
                grid.Columns[7].Visibility = Visibility.Collapsed;
                grid.Columns[8].Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString());
            }

            finally {
                LoadLbl.Visibility = Visibility.Collapsed;
                grid.Columns[4].Visibility = Visibility.Collapsed;
                grid.Columns[5].Visibility = Visibility.Collapsed;
                grid.Columns[6].Visibility = Visibility.Collapsed;
                grid.Columns[7].Visibility = Visibility.Collapsed;
                grid.Columns[8].Visibility = Visibility.Collapsed;
            }

        }
    }
}
