using BookMaster.AppData;
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
        List<Book> books = App.context.Book.ToList();

        PaginationService<Cover> coverPagination;
        PaginationService<Book> bookPagination;
        public BrowseCatalogPage()
        {
            InitializeComponent();

            bookPagination = new PaginationService<Book>(books, 50);
            BookAuthorLv.ItemsSource = bookPagination.CurrentPageOfItems;
            bookPagination.UpdateNavigationButtons(NextPageBtn, Previo)
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

        private void BookAuthorLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Book selectedBook = BookAuthorLv.SelectedItem as Book;
            List<Cover> covers = App.context.Cover.Where(c => c.IdBook == selectedBook.Id).ToList();
            BookDetailsGrid.DataContext = selectedBook;

            coverPagination = new PaginationService<Cover>(covers, 1);
            CoverLb.ItemsSource = coverPagination.CurrentPageOfItems;
            coverPagination.UpdateNavigationButtons(PreviousCoverBtn, NextCoverBtn);
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }

 
    }
}
