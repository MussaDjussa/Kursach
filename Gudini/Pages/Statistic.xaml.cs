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

        public void LoadList()
        { 
        
        }

       

        private void ListCount_Initialized(object sender, EventArgs e)
        {
            //var countbook = (from book in MainWindow.model.Book
            //                 join user_book in MainWindow.model.User_Book on
            //                    book.Id equals user_book.Id_Book
            //                 group book by book.Id into g
            //                 select new
            //                 {
            //                     Name = g.Key,
            //                     Count = g.Count()
            //                 }).ToList();
            ListCount.ItemsSource = MainWindow.model.Book.ToList();
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
    }
}
