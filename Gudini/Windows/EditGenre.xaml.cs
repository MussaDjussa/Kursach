using BuckApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for EditGenre.xaml
    /// </summary>
    public partial class EditGenre : Window
    {
        public EditGenre()
        {
            InitializeComponent();
            oldgenre.ItemsSource = MainWindow.model.Genre.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newgenre.Text))
            {
                MainWindow.genreContainer.NameGenre = newgenre.Text;
                MessageBox.Show("Жанр был добавлен!");
            }

            if (oldgenre.SelectedItem != null)
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
