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
                Book book = MainWindow.login.adminViewModel.Books.Single(q => q.Id == (MainWindow.dataGridAdminPanel.grid.SelectedItem as Book).Id);

                Genre genre = MainWindow.model.Genre.Single(q=>q.Id == MainWindow.genreContainer.SelectedItemGenre.Id);
                
                book.Genre = genre;

                book.Name = name.Text;
                book.Description = description.Text;
                book.Year = int.Parse(year.Text);
                book.Cost = int.Parse(price.Text);
                book.Discount = int.Parse(discount.Text);
                book.Cover= ImageToByte(image);
                book.ContentText = bytes;


                Author author = MainWindow.model.Author.Single(q => q.Id == MainWindow.authorContainer.SelectedItemAuthor.Id);

                book.Author = author;

                MainWindow.model.SaveChanges();





                MessageBox.Show("Обновление успешно завершено!");
            }
            else if (MainWindow.authorContainer.EmptyFields() == true && MainWindow.genreContainer.EmptyFields() == true)
            {
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
