using System.Windows;
using System.Windows.Controls;
using BuckApp.Model;
namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for MoreDetails_StoreBook.xaml
    /// </summary>
    public partial class MoreDetails_StoreBook : Page
    {
        public MoreDetails_StoreBook()

        {
            InitializeComponent();
            DataContext = MainWindow.book.ViewModel.SelectedItem;
        }
        /// <summary>
        /// закрытие приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        /// <summary>
        /// Навигация к предыдущей странице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
