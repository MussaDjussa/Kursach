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

namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for MoreDetails_StoreBook_User.xaml
    /// </summary>
    public partial class MoreDetails_StoreBook_User : Page
    {
        public MoreDetails_StoreBook_User()
        {
            InitializeComponent();
            DataContext = MainWindow.book.ViewModel.SelectedItem_UserBook;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Read());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
