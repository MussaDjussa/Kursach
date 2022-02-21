using BuckApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace BuckApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для MyBookStorage.xaml
    /// </summary>
    public partial class MyBookStorage : Page
    {
        private static FilterBook filter2 = new FilterBook("", "", "");
        public MyBookStorage()
        {
            InitializeComponent();
            LoadBook();
        }

        public void LoadBook()
        {
          

            List<User_Book> user_Books = new List<User_Book>();
            user_Books = MainWindow.model.User_Book.ToList().Where(c=> c.Id_User == Pages.Login.user.Id).ToList().Where(c => Regex.IsMatch(c.Book.Name, filter2.Name)
            || Regex.IsMatch(c.Book.Author.LName, filter2.Author) || Regex.IsMatch(c.Book.Genre.Name, filter2.Genre)).ToList();
            ListBook.ItemsSource = user_Books;

           
        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new MoreDetails_StoreBook(ListBook.SelectedItem as Book));

        }

        private void filterBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            filter2.Name = filterBox.Text;
            filter2.Author = filterBox.Text;
            filter2.Genre = filterBox.Text;
            LoadBook();
        }

        private void addbook_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new StoreBook());
        }

        private void statistic_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Statistic());
        }
    }
}
