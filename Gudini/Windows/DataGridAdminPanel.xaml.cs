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
using System.Windows.Shapes;

namespace BuckApp.Windows
{
    /// <summary>
    /// Interaction logic for DataGridAdminPanel.xaml
    /// </summary>
    public partial class DataGridAdminPanel : Window
    {
        public DataGridAdminPanel()
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.editWindow = new EditWindow();
            MainWindow.editWindow.Show();
        }
    }
}
