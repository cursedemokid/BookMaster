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
        List<Employee> employees = new List<Employee>();
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (employees.FirstOrDefault(em => em.Login == LoginTb.Text && em.Password == PasswordPb.Password) != null)
            {
                App.currentEmployee = employees.FirstOrDefault(em => em.Login == LoginTb.Text && em.Password == PasswordPb.Password);
                MessageBox.Show($"Добро пожаловать, {App.currentEmployee}!");
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
