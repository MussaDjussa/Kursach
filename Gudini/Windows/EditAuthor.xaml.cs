using BuckApp.Model;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;

namespace BuckApp.Windows
{
    /// <summary>
    /// Interaction logic for EditAuthor.xaml
    /// </summary>
    public partial class EditAuthor : Window
    {
        public EditAuthor()
        {
            InitializeComponent();
            author.ItemsSource = MainWindow.model.Author.ToList();
        } 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (author.SelectedItem != null)
            {
                MainWindow.authorContainer.SelectedItemAuthor = author.SelectedItem as Author;
                MessageBox.Show("Автор был добавлен!");

            }
            if (!string.IsNullOrWhiteSpace(fname.Text) && !string.IsNullOrWhiteSpace(lname.Text) && !string.IsNullOrWhiteSpace(mname.Text))
            {
                MainWindow.authorContainer.FName = fname.Text;
                MainWindow.authorContainer.LName = lname.Text;
                MainWindow.authorContainer.MName = mname.Text;
                MessageBox.Show("Автор был добавлен!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();

            fname.IsReadOnly = false;
            lname.IsReadOnly = false;
            mname.IsReadOnly = false;

            author.SelectedItem = null;

            fname.Text = string.Empty;
            lname.Text = string.Empty;
            mname.Text = string.Empty;

        }

        private void lname_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(lname.Text, "[^А-Я-а-я]"))
            {
                MessageBox.Show("Можно вводить только русские заглавные или строчные символы!!!", "Ошибка!!!");
                lname.Text = lname.Text.Remove(lname.Text.Length - 1);
                lname.SelectionStart = lname.Text.Length;
            }
        }

        private void fname_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(fname.Text, "[^А-Я-а-я]"))
            {
                MessageBox.Show("Можно вводить только русские заглавные или строчные символы!!!", "Ошибка!!!");
                fname.Text = fname.Text.Remove(fname.Text.Length - 1);
                fname.SelectionStart = fname.Text.Length;
            }
        }

        private void mname_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(mname.Text, "[^А-Я-а-я]"))
            {
                MessageBox.Show("Можно вводить только русские заглавные или строчные символы!!!", "Ошибка!!!");
                mname.Text = mname.Text.Remove(mname.Text.Length - 1);
                mname.SelectionStart = mname.Text.Length;
            }
        }
    }
}
