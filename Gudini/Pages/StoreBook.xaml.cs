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
    }
}
