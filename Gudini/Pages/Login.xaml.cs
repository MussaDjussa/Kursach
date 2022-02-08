using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using BuckApp.Model;
namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Навигация к стартовой странице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(MainWindow.startUp);
        }
        /// <summary>
        /// Закрытие приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        /// <summary>
        /// Кнопка войти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Проверка для пустые поля
            if(string.IsNullOrWhiteSpace(login.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Остались пустые поля!!!", "Ошибка!!!");
            }
            else
            {
                if(UserLogin() != null)
                {
                    NavigationService.Navigate(MainWindow.startUp);
                }
                else
                {
                    MessageBox.Show("Пользователь не найден!!!","Ошибка!!!");
                }
            }
        }
        /// <summary>
        /// Проверка поля на латинские заглавные или строчные символы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(login.Text, "[^A-z]"))
            {
                MessageBox.Show("Можно вводить только латинские заглавные или строчные символы!!!", "Ошибка!!!");
                login.Text = login.Text.Remove(login.Text.Length - 1);
                login.SelectionStart = login.Text.Length;
            }
        }
        /// <summary>
        /// Проверка поля на латинские заглавные и строчные символы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(password.Text, "[^0-9]"))
            {
                MessageBox.Show("Можно вводить только латинские заглавные или строчные символы!!!", "Ошибка!!!");
                password.Text = password.Text.Remove(password.Text.Length - 1);
                password.SelectionStart = password.Text.Length;
            }
        }
        /// <summary>
        /// Поиск пользователя по введеным полям
        /// </summary>
        /// <returns>user</returns>
        private User UserLogin()
        {
            User findUser = MainWindow.model.User.ToList().Find(q=>q.Login == login.Text && q.Password == password.Text);
            return findUser;
        }
        
    }
}
