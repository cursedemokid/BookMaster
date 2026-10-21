using ProjectSecurity;
using BookMaster.Model;
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

namespace BookMaster.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {

        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            var employee = App.context.Employee.FirstOrDefault(em => em.Login == LoginTb.Text);
            if (employee != null && PasswordSecurity.Verify(PasswordPb.Password, employee.Password))
            {
                App.currentEmployee = employee;
                MessageBox.Show($"Добро пожаловать, {App.currentEmployee.Login}!");
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show($"Неправильный логин и пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
