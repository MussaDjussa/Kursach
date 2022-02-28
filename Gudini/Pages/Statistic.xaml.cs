using BuckApp.Model;
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
    /// Логика взаимодействия для Statistic.xaml
    /// </summary>
    public partial class Statistic : Page
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void ProgressBook_Initialized(object sender, EventArgs e)
        {
            ProgressBar progress = sender as ProgressBar;
            Book book = (sender as ProgressBar).DataContext as Book;
            int maxcount = MainWindow.model.Database.SqlQuery<int>($"With t as ( Select Count(*) as 'countBook' from Book join User_Book on Book.Id = User_Book.Id_Book group by Book.Id ) Select MAX(countBook) from t").ToList().FirstOrDefault();
            int count = MainWindow.model.Database.SqlQuery<int>($"Select Count(*) from Book join User_Book on Book.Id = User_Book.Id_Book where Id_Book= {book.Id} group by Book.Id order by Count(*) desc").ToList().FirstOrDefault();
            progress.Maximum = maxcount;
            progress.Minimum = 0;
            progress.Value = count;
            progress.Background = new SolidColorBrush(Colors.Green);
        }

       

        private void ProgressGenre_Initialized(object sender, EventArgs e)
        {
            ProgressBar progress = sender as ProgressBar;
            Genre genre = (sender as ProgressBar).DataContext as Genre;
            int maxcount = MainWindow.model.Database.SqlQuery<int>($"with t as (Select Count(*) as 'countGenre' from Book join User_Book on Book.Id = User_Book.Id_Book join Genre on Book.Id_Genre = Genre.Id group by Genre.Name ) Select MAX(countGenre) from t").ToList().FirstOrDefault();
            int count = MainWindow.model.Database.SqlQuery<int>($"Select  Count(*) as 'countGenre' from Book join User_Book on Book.Id = User_Book.Id_Book join Genre on Book.Id_Genre = Genre.Id where Genre.Id = {genre.Id}  group by Genre.Id, Genre.Name order by Count(*) desc").ToList().FirstOrDefault();
            progress.Maximum = maxcount;
            progress.Minimum = 0;
            progress.Value = count;
            progress.Background = new SolidColorBrush(Colors.Green);
        }

        private void GenreCount_Initialized(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            listView.ItemsSource = MainWindow.model.Genre.ToList();
        }

        private void BookCount_Initialized(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            listView.ItemsSource = MainWindow.model.Book.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
