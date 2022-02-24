using BuckApp.Model;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;

namespace BuckApp.Windows
{
    /// <summary>
    /// Interaction logic for AddGenre.xaml
    /// </summary>
    public partial class AddGenre : Window
    {

        public AddGenre()
        {
            InitializeComponent();
            oldgenre.ItemsSource = MainWindow.model.Genre.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(newgenre.Text))
            {
                MainWindow.genreContainer.NameGenre = newgenre.Text;
                MessageBox.Show("Жанр был добавлен!");
            }

            if(oldgenre.SelectedItem != null)
            {
                MainWindow.genreContainer.SelectedItemGenre = oldgenre.SelectedItem as Genre;
                MessageBox.Show("Жанр был добавлен!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();

            newgenre.Text = string.Empty;
            oldgenre.SelectedItem = null;
        }

        private void newgenre_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(newgenre.Text, "[^А-я]"))
            {
                MessageBox.Show("Можно вводить только русские заглавные или строчные символы!!!", "Ошибка!!!");
                newgenre.Text = newgenre.Text.Remove(newgenre.Text.Length - 1);
                newgenre.SelectionStart = newgenre.Text.Length;
            }
        }
    }
}
