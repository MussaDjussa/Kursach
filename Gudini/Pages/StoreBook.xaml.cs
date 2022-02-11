using BuckApp.ViewModel;
using System.Windows.Controls;

namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for StoreBook.xaml
    /// </summary>
    public partial class StoreBook : Page
    {

        /// <summary>
        /// Создаем ViewModel свойство и инициализируем конструктор
        /// </summary>
        public StoreBook_ViewModel ViewModel { get; set; } = new StoreBook_ViewModel();

        public StoreBook()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new MoreDetails_StoreBook());

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
