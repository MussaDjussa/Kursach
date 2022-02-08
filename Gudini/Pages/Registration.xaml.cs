using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;


namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Registrate Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Хотите перейти к странице с авторизацией?","Пользователь успешно зарегистрирован!!!",MessageBoxButton.OKCancel);

            if(result == MessageBoxResult.OK)
            {
                NavigationService.Navigate(MainWindow.login);
            }
        }
        /// <summary>
        /// Application Shutdown Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        /// <summary>
        /// Navigation to StartUp page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(MainWindow.startUp);
        }
    }
}
