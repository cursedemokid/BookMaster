using BookMaster.View.Pages;
using BookMaster.View.Windows;
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

namespace BookMaster
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if(App.currentEmployee == null)
            {
                LoginMI.Visibility = Visibility.Collapsed;
            }
            else
            {
                LogoutMI.Visibility = Visibility.Collapsed;
                LibraryMenu.Visibility = Visibility.Collapsed;
            }

        }

        private void LoginMI_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            if (authorizationWindow.ShowDialog() == true)
            {
                LoginMI.Visibility = Visibility.Collapsed;
                LogoutMI.Visibility = Visibility.Visible;
                LibraryMenu.Visibility = Visibility.Visible;
                MainFrame.Navigate(new BrowseCatalogPage());
            }
        }

        private void LogoutMI_Click(object sender, RoutedEventArgs e)
        {
            App.currentEmployee = null;
            LogoutMI.Visibility = Visibility.Collapsed;
            LibraryMenu.Visibility = Visibility.Collapsed;
            LoginMI.Visibility = Visibility.Visible;
            MainFrame.Navigate(null);
        }

        private void CloseMI_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ManageCustomersMI_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CirculationMI_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReportsMI_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BrowseCatalogMI_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
