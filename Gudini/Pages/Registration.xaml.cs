using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using BuckApp.Model;

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
        /// Кнопка регистрации...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // проверка на пустые поля
            if (string.IsNullOrWhiteSpace(surname.Text) || string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(login.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Остались пустые поля!!!", "Ошибка!!!");
            }
            else
            {
                // добавление пользователя в БД, в таблицу User
                MainWindow.model.User.Add(UserCreating());
                // сохраняем изменения
                MainWindow.model.SaveChanges();

                // вывод окна с сообщением
                if (MessageBox.Show("Хотите перейти к странице с авторизацией?", "Пользователь успешно зарегистрирован!!!", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    NavigationService.Navigate(MainWindow.login);
                }
            }



        }
        /// <summary>
        /// Кнопка выхода из приложения...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        /// <summary>
        /// Навигация к стартовой странице...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(MainWindow.startUp);
        }
        /// <summary>
        /// Создаём нового пользователя...
        /// </summary>
        /// <returns>user</returns>
        private User UserCreating()
        {
            User user = new User()
            {
                FName = name.Text,
                LName = surname.Text,
                Id_Role = 2,
                Login = login.Text,
                Password = password.Text,
            };
            return user;
        }
        /// <summary>
        /// Проверка поля на  русские заглавные или строчные символы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void surname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(surname.Text, "[^А-я]"))
            {
                MessageBox.Show("Можно вводить только русские заглавные или строчные символы!!!", "Ошибка!!!");
                surname.Text = surname.Text.Remove(surname.Text.Length - 1);
                surname.SelectionStart = surname.Text.Length;
            }
        }
        /// <summary>
        /// Проверка поля на  русские заглавные или строчные символы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(name.Text, "[^А-Я-а-я]"))
            {
                MessageBox.Show("Можно вводить только русские заглавные или строчные символы!!!", "Ошибка!!!");
                name.Text = name.Text.Remove(name.Text.Length - 1);
                name.SelectionStart = name.Text.Length;
            }
        }
        /// <summary>
        /// Проверка поля на латинские или строчные символы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(login.Text, "[^A-Z-a-z]"))
            {
                MessageBox.Show("Можно вводить только латинские заглавные или строчные символы!!!", "Ошибка!!!");
                login.Text = login.Text.Remove(login.Text.Length - 1);
                login.SelectionStart = login.Text.Length;
            }
        }
        /// <summary>
        /// Проверка поля на числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(password.Text, "[^0-9]"))
            {
                MessageBox.Show("Можно вводить только числа!!!", "Ошибка!!!");
                password.Text = password.Text.Remove(password.Text.Length - 1);
                password.SelectionStart = password.Text.Length;
            }
        }
    }
}
