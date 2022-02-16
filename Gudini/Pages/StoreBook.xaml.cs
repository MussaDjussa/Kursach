using BuckApp.Model;
using BuckApp.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for StoreBook.xaml
    /// </summary>
    public partial class StoreBook : Page
    {
        private static FilterBook filter = new FilterBook("", "", "");
        /// <summary>
        /// Создаем ViewModel свойство и инициализируем конструктор
        /// </summary>
        public StoreBook_ViewModel ViewModel { get; set; } = new StoreBook_ViewModel();

        public StoreBook()
        {
            InitializeComponent();

            LoadBook();
            //DataContext = ViewModel;
        }

        public void LoadBook()
        {
            List<Book> books = new List<Book>();
            books = MainWindow.model.Book.ToList().Where(c => Regex.IsMatch(c.Name, filter.Name)
            || Regex.IsMatch(c.Author.LName, filter.Author) || Regex.IsMatch(c.Genre.Name, filter.Genre)).ToList();
            ListBook.ItemsSource = books;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new MoreDetails_StoreBook(ListBook.SelectedItem as Book));

        }

        private void filterBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            filter.Name = filterBox.Text;
            filter.Author = filterBox.Text;
            filter.Genre = filterBox.Text;
            LoadBook();
        }

        //private void TextBox_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    filterBox.Text = string.Empty;
        //}

        //private void TextBox_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    if(string.IsNullOrWhiteSpace(filterBox.Text))
        //    {
        //        filterBox.Text = "искать автора, жанр, издательство";
        //    }

        //}
    }
}
