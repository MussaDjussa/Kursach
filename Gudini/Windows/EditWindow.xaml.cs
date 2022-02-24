using BuckApp.Model;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;

namespace BuckApp.Windows
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private static OpenFileDialog dialogCover = new OpenFileDialog();
        private static OpenFileDialog dialogContent = new OpenFileDialog();
        private static String textBook;
        private static byte[] bytes;



        public static byte[] ImageToByte(System.Drawing.Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public EditWindow()
        {
            InitializeComponent();
            DataContext = MainWindow.dataGridAdminPanel.grid.SelectedItem as Book;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (MessageBox.Show("Выбрать автора из выпадающего списка?", "Выберите", MessageBoxButton.YesNoCancel, MessageBoxImage.Question))
            {
                case MessageBoxResult.Yes:
                    MainWindow.addAuthor.author.Visibility = Visibility.Visible;
                    MainWindow.addAuthor.fname.IsReadOnly = true;
                    MainWindow.addAuthor.lname.IsReadOnly = true;
                    MainWindow.addAuthor.mname.IsReadOnly = true;
                    MainWindow.addAuthor.Show();
                    break;
                case MessageBoxResult.No:
                    MainWindow.addAuthor.author.Visibility = Visibility.Hidden;
                    MainWindow.addAuthor.fname.IsReadOnly = false;
                    MainWindow.addAuthor.lname.IsReadOnly = false;
                    MainWindow.addAuthor.mname.IsReadOnly = false;
                    MainWindow.addAuthor.Show();
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }
        private void genre_Click(object sender, RoutedEventArgs e)
        {
            switch (MessageBox.Show("Выбрать жанр(-ы) из выпадающего списка?", "Выберите", MessageBoxButton.YesNoCancel, MessageBoxImage.Question))
            {
                case MessageBoxResult.Yes:
                    MainWindow.addGenre.newgenre.Visibility = Visibility.Hidden;
                    MainWindow.addGenre.oldgenre.Visibility = Visibility.Visible;
                    MainWindow.addGenre.Show();
                    break;
                case MessageBoxResult.No:
                    MainWindow.addGenre.newgenre.Visibility = Visibility.Visible;
                    MainWindow.addGenre.oldgenre.Visibility = Visibility.Hidden;
                    MainWindow.addGenre.Show();
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Drawing.Image image = new Bitmap(dialogCover.FileName);

            if (MainWindow.authorContainer.SelectedItemAuthor != null && MainWindow.genreContainer.SelectedItemGenre != null)
            {
                int book_id = (MainWindow.dataGridAdminPanel.grid.SelectedItem as Book).Id;
                int genre_id = (MainWindow.dataGridAdminPanel.grid.SelectedItem as Book).Genre.Id;
                int author_id = (MainWindow.dataGridAdminPanel.grid.SelectedItem as Book).Author.Id;
                var book = MainWindow.model.Book.Where(q => q.Id == book_id).ToList();
                var genre = MainWindow.model.Genre.Where(q => q.Id == genre_id).ToList();
                var author = MainWindow.model.Author.Where(q => q.Id == author_id).ToList();

 
                genre[0].Name = MainWindow.genreContainer.SelectedItemGenre.Name;
                author[0].FName = MainWindow.authorContainer.SelectedItemAuthor.FName;
                author[0].LName = MainWindow.authorContainer.SelectedItemAuthor.LName;
                author[0].MName = MainWindow.authorContainer.SelectedItemAuthor.MName;

                book[0].Name = name.Text;
                book[0].Description = description.Text;
                book[0].ContentText = bytes;
                book[0].Cover = ImageToByte(image);
                book[0].Cost = int.Parse(price.Text);
                book[0].Discount = int.Parse(discount.Text);
                book[0].Year = int.Parse(year.Text);

                MainWindow.model.Entry(book[0]).State = System.Data.Entity.EntityState.Modified;
                MainWindow.model.Entry(genre[0]).State = System.Data.Entity.EntityState.Modified;
                MainWindow.model.Entry(author[0]).State = System.Data.Entity.EntityState.Modified;
                MainWindow.model.SaveChanges();

                foreach (var item in MainWindow.book.ViewModel.Book.Where(q=>q.Id == book_id).ToList())
                {
                    item.Cover = ImageToByte(image);
                }

                // перевызываем конструкторы классов

                MainWindow.login.adminViewModel = new ViewModel.AdminViewModel();
                MainWindow.book.ViewModel = new ViewModel.StoreBook_ViewModel();

                MessageBox.Show("Обновление успешно завершено!");
            }
            else if (MainWindow.authorContainer.EmptyFields() == true && MainWindow.genreContainer.EmptyFields() == true)
            {
                int book_id = (MainWindow.dataGridAdminPanel.grid.SelectedItem as Book).Id;
                int genre_id = (MainWindow.dataGridAdminPanel.grid.SelectedItem as Book).Genre.Id;
                int author_id = (MainWindow.dataGridAdminPanel.grid.SelectedItem as Book).Author.Id;
                var book = MainWindow.model.Book.Where(q => q.Id == book_id).ToList();
                var genre = MainWindow.model.Genre.Where(q => q.Id == genre_id).ToList();
                var author = MainWindow.model.Author.Where(q => q.Id == author_id).ToList();

                book[0].Name = name.Text;
                book[0].Description = description.Text;
                genre[0].Name = MainWindow.genreContainer.NameGenre;
                author[0].FName = MainWindow.authorContainer.FName;
                author[0].LName = MainWindow.authorContainer.LName;
                author[0].MName = MainWindow.authorContainer.MName;
                book[0].ContentText = bytes;
                book[0].Cover = ImageToByte(image);
                book[0].Cost = int.Parse(price.Text);
                book[0].Discount = int.Parse(discount.Text);
                book[0].Year = int.Parse(year.Text);

                MainWindow.model.Entry(book[0]).State = System.Data.Entity.EntityState.Modified;
                MainWindow.model.Entry(genre[0]).State = System.Data.Entity.EntityState.Modified;
                MainWindow.model.Entry(author[0]).State = System.Data.Entity.EntityState.Modified;
                MainWindow.model.SaveChanges();

                // перевызываем конструкторы классов

                MainWindow.login.adminViewModel = new ViewModel.AdminViewModel();
                MainWindow.book.ViewModel = new ViewModel.StoreBook_ViewModel();

                MessageBox.Show("Обновление успешно завершено!");
            }
            else if (MainWindow.authorContainer.EmptyFields() == false && MainWindow.authorContainer.SelectedItemAuthor != null)
            {
                MessageBox.Show("Ошибка!");
            }
            else if (MainWindow.genreContainer.EmptyFields() == false && MainWindow.genreContainer.SelectedItemGenre != null)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dialogCover.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialogCover.ShowDialog() == true)
            {
                image.Source = new BitmapImage(new Uri(dialogCover.FileName));
                MessageBox.Show("Файл был добавлен");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            image.Source = null;
            MessageBox.Show("Файл удалён");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            dialogContent.Title = "text selection";
            dialogContent.Filter = "TXT(.txt)|*.txt|DOCX(.docx)|*.docx";
            if (dialogContent.ShowDialog() == true)
            {
                if (dialogContent.FileName.EndsWith(".txt"))
                {
                    bytes = System.IO.File.ReadAllBytes(dialogContent.FileName);
                    MessageBox.Show("Файл выбран!!!");
                }
                else
                {
                    using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(dialogContent.FileName, true))
                    {
                        Body text = wordDoc.MainDocumentPart.Document.Body;
                        textBook = text.InnerText.ToString();
                        bytes = Encoding.Unicode.GetBytes(textBook);
                        MessageBox.Show("Файл выбран!!!");
                    }
                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            bytes = null;
            MessageBox.Show("Прикрепленный файл удалён!!!");
        }
    }
}
