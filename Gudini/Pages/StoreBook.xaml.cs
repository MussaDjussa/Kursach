using BuckApp.Model;
using BuckApp.ViewModel;
using BuckApp.Windows;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System.Windows.Media;
using System;

namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for StoreBook.xaml
    /// </summary>
    public partial class StoreBook : Page
    {   
        public StoreBook_ViewModel ViewModel = new StoreBook_ViewModel();

        public StoreBook()
        {
            InitializeComponent();
            DataContext = ViewModel;
            //LoadList();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new MoreDetails_StoreBook());

        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new MoreDetails_StoreBook_User());
        }

        private void discount_Initialized(object sender, System.EventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            Book user_Book = (sender as TextBlock).DataContext as Book;
            Book book = user_Book;

            if (book.Discount > 0)
            {
                textBlock.Text = $" -{book.Discount}% {book.TotalCost} ₽";
            }
            else if (book.Cost == 0)
            {
                textBlock.Text = $"";
            }

        }

        private void price_Initialized(object sender, System.EventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;


            Book user_Book = (sender as TextBlock).DataContext as Book;
            Book book = user_Book;

            if (book.Discount > 0)
            {
                textBlock.TextDecorations = TextDecorations.Strikethrough;

                textBlock.Text = $"{book.Cost} ₽";
            }
            else
            {
                textBlock.Text = $"{book.Cost} ₽";
            }
            if (book.Cost == 0)
            {
                textBlock.Text = $"Бесплатно";
            }
        }

        private void TabItem_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Statistic());
        }

       

        private void buyButton_Initialized(object sender, System.EventArgs e)
        {
            Button button = sender as Button;

            Book user_Book = (sender as Button).DataContext as Book;
            Book book = user_Book;

            User_Book user_Book1 = MainWindow.model.User_Book.ToList().Find(c => c.Id_User == Pages.Login.user.Id && c.Id_Book == book.Id);
            if (user_Book1 != null)
            {
                button.Visibility = Visibility.Hidden;
                
            }
            else
            {
                if (Pages.Login.user.Balance > book.TotalCost)
                {
                    button.Visibility = Visibility.Visible;
                    button.Content = "Купить";
                }
                else
                {
                    button.Visibility = Visibility.Hidden;
                    button.Content = "Не хватает";
                }
            }
            //button.Background = new SolidColorBrush(Colors.Red);
            //button.Foreground = new SolidColorBrush(Colors.Black);



            //if (user_Book1 == null && Pages.Login.user.Balance > book.TotalCost)
            //{
            //    button.IsEnabled = true;
            //    button.Content = "Купить";
            //}
            //else if (Pages.Login.user.Balance > book.TotalCost && user_Book1 != null)
            //{
            //    button.IsEnabled = false;
            //    button.Content = "Приобретено";
            //}
            //else if (Pages.Login.user.Balance < book.TotalCost && user_Book1 == null)
            //{
            //    button.IsEnabled = false;
            //    button.Content = "Не хватает";
            //}
            //else if (Pages.Login.user.Balance < book.TotalCost && user_Book1 != null)
            //{
            //    button.IsEnabled = false;
            //    button.Content = "Приобретено";
            //}
        }

        private void buyButton_Click(object sender, RoutedEventArgs e)
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
                //ViewModel.BookUser.Add(new User_Book()
                //{
                //    Id_Book = book.Id,
                //    Id_User = Pages.Login.user.Id,
                //    Date_Buy = DateTime.Now,
                //    Id_Status = 1

                //});
                MainWindow.model.SaveChanges();
                LoadList();
            }
           
        } 
        public void LoadList()
        { 
            //BookLIst.ItemsSource = MainWindow.model.Book.ToList();
            UserBookLIst.ItemsSource = MainWindow.model.User_Book.ToList().Where(c => c.Id_User == Pages.Login.user.Id);
        }

        //private void TabItem_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    LoadList();
        //}

        //private void TabItem_MouseDoubleClick_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    LoadList();
        //}
    }
}
