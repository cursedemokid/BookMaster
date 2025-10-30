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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookMaster.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для BrowseCatalogPage.xaml
    /// </summary>
    public partial class BrowseCatalogPage : Page
    {
        List<BookAuthor> bookAuthors = App.context.BookAuthor.ToList();
        public BrowseCatalogPage()
        {
            InitializeComponent();

            BookAuthorLv.ItemsSource = bookAuthors;
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PreviousPageBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextPageBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PageNumberTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PreviousCoverBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextCoverBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
