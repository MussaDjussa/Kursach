using BuckApp.ViewModel;
using System.Windows;
using System.Windows.Controls;
using BuckApp.Model;
using System.ComponentModel;
using BuckApp.Windows;

namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for LoginAdmin.xaml
    /// </summary>
    public partial class LoginAdmin : Page
    {
        public LoginAdmin()
        {
            InitializeComponent();
            DataContext = MainWindow.login.adminViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.model.Book.Remove(MainWindow.login.adminViewModel.SelectedItem);
            MainWindow.model.SaveChanges();
            MainWindow.login.adminViewModel.Books.Remove(MainWindow.login.adminViewModel.SelectedItem);                   
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new AddWindow().Show();
        }
    }
}
