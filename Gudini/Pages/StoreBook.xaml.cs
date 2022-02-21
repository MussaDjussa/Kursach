using BuckApp.Model;
using BuckApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
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
            List<Book> user_Books = new List<Book>();
            user_Books = MainWindow.model.Book.ToList().Where(c => Regex.IsMatch(c.Name, filter.Name)
            || Regex.IsMatch(c.Author.LName, filter.Author) || Regex.IsMatch(c.Genre.Name, filter.Genre)).ToList();
            ListBook.ItemsSource = user_Books;

            //List<User_Book> user_Books = new List<User_Book>();
            //user_Books = MainWindow.model.Book.ToList().Where(c => Regex.IsMatch(c.Book.Name, filter.Name)
            //|| Regex.IsMatch(c.Book.Author.LName, filter.Author) || Regex.IsMatch(c.Book.Genre.Name, filter.Genre)).ToList();
            //ListBook.ItemsSource = user_Books;

            //List<Book> books = new List<Book>();
            //books = MainWindow.model.Book.ToList().Where(c => Regex.IsMatch(c.Name, filter.Name)
            //|| Regex.IsMatch(c.Author.LName, filter.Author) || Regex.IsMatch(c.Genre.Name, filter.Genre)).ToList();
            //ListBook.ItemsSource = books;
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

        private void addbook_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
        }

   
        private void CostText_Initialized(object sender, System.EventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
           

            Book user_Book = (sender as TextBlock).DataContext as Book;
            Book book = user_Book;
            
            if (book.Discount > 0)
            {
                textBlock.TextDecorations = TextDecorations.Strikethrough;
               
                textBlock.Text = $"{book.Cost}";
            }
            else
            {
                textBlock.Text = $"{book.Cost} руб";
            }
            if (book.Cost == 0)
            {
                textBlock.Text = $"Бесплатно";
            }
        }

        private void DiscText_Initialized(object sender, System.EventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            Book user_Book = (sender as TextBlock).DataContext as Book;
            Book book = user_Book;

            if (book.Discount > 0)
            {
                textBlock.Text = $" -{book.Discount}% {book.TotalCost} руб";
            }
            else if(book.Cost == 0)
            {
                textBlock.Text = $"";
            }

        }

        private void buyBook_Initialized(object sender, System.EventArgs e)
        {
            Button button = sender as Button;


            Book user_Book = (sender as Button).DataContext as Book;
            Book book = user_Book;
            
            User_Book user_Book1 = MainWindow.model.User_Book.ToList().Find(c => c.Id_User == Pages.Login.user.Id && c.Id_Book == book.Id);
            if (user_Book1 == null && Pages.Login.user.Balance> book.TotalCost)
            {
                button.IsEnabled = true;
                button.Content = "Купить";
            }
            else if(Pages.Login.user.Balance > book.TotalCost && user_Book1 != null)
            {
                button.IsEnabled = false;
                button.Content = "Приобретено";
            }
            else if (Pages.Login.user.Balance < book.TotalCost && user_Book1 == null)
            {
                button.IsEnabled = false;
                button.Content = "Не хватает";
            }
            else if (Pages.Login.user.Balance < book.TotalCost && user_Book1 != null)
            {
                button.IsEnabled = false;
                button.Content = "Приобретено";
            }

        }

        private void buyBook_Click(object sender, RoutedEventArgs e)
        {
            var delete = MessageBox.Show("Вы действительно хотите купить книгу?", "Предупреждение", MessageBoxButton.YesNo);
            if (delete == MessageBoxResult.Yes)
            {
                Book book = (sender as Button).DataContext as Book;
                Pages.Login.user.Balance -= book.TotalCost;
                MainWindow.model.User_Book.Add(new User_Book()
                {
                    Id_Book = book.Id,
                    Id_User = Pages.Login.user.Id,
                    Date_Buy = DateTime.Now,
                    Id_Status = 1

                });
                MainWindow.model.SaveChanges();
                LoadBook();
            }
        }

        private void myBookTab_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new MyBookStorage());
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
