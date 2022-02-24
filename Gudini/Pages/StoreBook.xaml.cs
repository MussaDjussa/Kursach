using BuckApp.Model;
using BuckApp.ViewModel;
using BuckApp.Windows;
using System.Windows;
using System.Windows.Controls;

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
    }
}
