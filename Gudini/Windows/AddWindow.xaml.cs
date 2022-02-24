using BuckApp.Model;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media.Imaging;

namespace BuckApp.Windows
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public static OpenFileDialog dialogCover = new OpenFileDialog();
        public static OpenFileDialog dialogContent = new OpenFileDialog();
        public static String textBook;
        public static byte[] bytes;

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public AddWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            switch (MessageBox.Show("Хотите добавить нового автора?", "Выберите", MessageBoxButton.YesNoCancel, MessageBoxImage.Question))
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Авторы не будут доступны из выпадающего списка!!!");
                    MainWindow.addAuthor.author.Visibility = Visibility.Hidden;
                    MainWindow.addAuthor.fname.Visibility = Visibility.Visible;
                    MainWindow.addAuthor.lname.Visibility = Visibility.Visible;
                    MainWindow.addAuthor.mname.Visibility = Visibility.Visible;
                    MainWindow.addAuthor.Show();
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Доступны только авторы из выпадающего списка!!!");
                    MainWindow.addAuthor.author.Visibility = Visibility.Visible;
                    MainWindow.addAuthor.fname.Visibility = Visibility.Hidden;
                    MainWindow.addAuthor.lname.Visibility = Visibility.Hidden;
                    MainWindow.addAuthor.mname.Visibility = Visibility.Hidden;
                    MainWindow.addAuthor.Show();
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }
        private void genre_Click(object sender, RoutedEventArgs e)
        {
            switch (MessageBox.Show("Хотите добавить новый(-ые) жанр(-ы)?", "Выберите", MessageBoxButton.YesNoCancel, MessageBoxImage.Question))
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Жанры не будут доступны из выпадающего списка!!!");
                    MainWindow.addGenre.newgenre.Visibility = Visibility.Visible;
                    MainWindow.addGenre.oldgenre.Visibility = Visibility.Hidden;
                    MainWindow.addGenre.Show();
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Доступны только жанры из выпадающего списка!!!");
                    MainWindow.addGenre.newgenre.Visibility = Visibility.Hidden;
                    MainWindow.addGenre.oldgenre.Visibility = Visibility.Visible;
                    MainWindow.addGenre.Show();
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }

        public Author AuthorCreating()
        {
            Author author = new Author()
            {
                FName = MainWindow.authorContainer.FName,
                LName = MainWindow.authorContainer.LName,
                MName = MainWindow.authorContainer.MName
            };

            MainWindow.model.Author.Add(author);

            return author;
        }
        public Genre GenreCreating()
        {
            Genre genre = new Genre()
            {
                Name = MainWindow.genreContainer.NameGenre
            };

            MainWindow.model.Genre.Add(genre);

            return genre;

        }
        public void AddGenreAndAuthorWithoutComboBox()
        {
            Image image = new Bitmap(dialogCover.FileName);
            Book book;

            MainWindow.model.Book.Add(book = new Book()
            {
                Name = name.Text,
                Description = description.Text,
                Id_Genre = GenreCreating().Id,
                Id_Author = AuthorCreating().Id,
                ContentText = bytes,
                Cover = ImageToByte(image),
                Cost = int.Parse(price.Text),
                Discount = int.Parse(discount.Text),
                Year = int.Parse(year.Text)
            });

            MainWindow.model.SaveChanges();

            // добавляем книги во ViewModel
            MainWindow.login.adminViewModel.Books.Add(book);
            MainWindow.book.ViewModel.Book.Add(book);
            MessageBox.Show("Добавлено!");
        }
        public void AddGenreAndAuthorWithComboBox()
        {
            Image image = new Bitmap(dialogCover.FileName);

            Book book;

            MainWindow.model.Book.Add(book = new Book()
            {

                Name = name.Text,
                Description = description.Text,
                Id_Genre = MainWindow.genreContainer.SelectedItemGenre.Id,
                Id_Author = MainWindow.authorContainer.SelectedItemAuthor.Id,
                ContentText = bytes,
                Cover = ImageToByte(image),
                Cost = int.Parse(price.Text),
                Discount = int.Parse(discount.Text),
                Year = int.Parse(year.Text)
            });
            MainWindow.model.SaveChanges();

            // добавляем книги во ViewModel
            MainWindow.login.adminViewModel.Books.Add(book);
            MainWindow.book.ViewModel.Book.Add(book);

            MessageBox.Show("Добавлено!");
        }

        public void AddAuthorSelectedItem()
        {
            Image image = new Bitmap(dialogCover.FileName);
            Book book;

            MainWindow.model.Book.Add(book = new Book()
            {
                Name = name.Text,
                Description = description.Text,
                Id_Genre = GenreCreating().Id,
                Id_Author = MainWindow.authorContainer.SelectedItemAuthor.Id,
                ContentText = bytes,
                Cover = ImageToByte(image),
                Cost = int.Parse(price.Text),
                Discount = int.Parse(discount.Text),
                Year = int.Parse(year.Text)
            });

            MainWindow.model.SaveChanges();

            // добавляем книги во ViewModel
            MainWindow.login.adminViewModel.Books.Add(book);
            MainWindow.book.ViewModel.Book.Add(book);
            MessageBox.Show("Добавлено!");
        }
        
        public void AddGenreSelectedItem()
        {
            Image image = new Bitmap(dialogCover.FileName);
            Book book;

            MainWindow.model.Book.Add(book = new Book()
            {
                Name = name.Text,
                Description = description.Text,
                Id_Genre = MainWindow.genreContainer.SelectedItemGenre.Id,
                Id_Author = AuthorCreating().Id,
                ContentText = bytes,
                Cover = ImageToByte(image),
                Cost = int.Parse(price.Text),
                Discount = int.Parse(discount.Text),
                Year = int.Parse(year.Text)
            });

            MainWindow.model.SaveChanges();

            // добавляем книги во ViewModel
            MainWindow.login.adminViewModel.Books.Add(book);
            MainWindow.book.ViewModel.Book.Add(book);
            MessageBox.Show("Добавлено!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MainWindow.authorContainer.EmptyFields() == true && MainWindow.authorContainer.SelectedItemAuthor != null
                    && MainWindow.genreContainer.EmptyFields() == true && MainWindow.genreContainer.SelectedItemGenre != null)
                {
                    AddGenreAndAuthorWithComboBox();
                }

                if (MainWindow.authorContainer.EmptyFields() == false && MainWindow.genreContainer.EmptyFields() == false)
                {
                    AddGenreAndAuthorWithoutComboBox();
                }
                if(MainWindow.authorContainer.EmptyFields() == false && MainWindow.genreContainer.SelectedItemGenre != null)
                {
                    AddGenreSelectedItem();
                }
                if(MainWindow.authorContainer.SelectedItemAuthor != null && !string.IsNullOrWhiteSpace(MainWindow.genreContainer.NameGenre))
                {
                    AddAuthorSelectedItem();
                }
            }

            catch (ArgumentException) { MessageBox.Show("Не выбрана обложка(картинка)!"); }
        }

        /// <summary>
        /// Проверка на пустые поля
        /// </summary>
        /// <returns>true - пусто</returns>
        private bool VerifyEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(year.Text) || string.IsNullOrWhiteSpace(price.Text))
            {
                MessageBox.Show("Поля: Цена, Год, Цена - остались пустыми!", "Заполните пожалуйста!");
                return true;
            }
            return false;
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
                    try { 
                    using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(dialogContent.FileName, true))
                    {
                        Body text = wordDoc.MainDocumentPart.Document.Body;
                        textBook = text.InnerText.ToString();
                        bytes = Encoding.Unicode.GetBytes(textBook);
                        MessageBox.Show("Файл выбран!!!");
                    }}
                    catch(FileFormatException)
                    {
                        MessageBox.Show("Файл не может быть размером 0 байт");
                    }
                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            bytes = null;
            MessageBox.Show("Прикрепленный файл удалён!!!");
        }

        private void name_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(name.Text, "[^А-Я-а-я]"))
            {
                MessageBox.Show("Можно вводить только строковые заглавные или строчные символы!!!", "Ошибка!!!");
                name.Text = name.Text.Remove(name.Text.Length - 1);
                name.SelectionStart = name.Text.Length;
            }
        }

        private void year_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(year.Text, "[^0-9]"))
            {
                MessageBox.Show("Можно вводить только числовые символы!!!", "Ошибка!!!");
                year.Text = year.Text.Remove(year.Text.Length - 1);
                year.SelectionStart = year.Text.Length;
            }
        }

        private void price_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(price.Text, "[^0-9]"))
            {
                MessageBox.Show("Можно вводить только числовые символы!!!", "Ошибка!!!");
                price.Text = price.Text.Remove(price.Text.Length - 1);
                price.SelectionStart = price.Text.Length;
            }
        }

        private void discount_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(price.Text, "[^0-9]"))
            {
                MessageBox.Show("Можно вводить только числовые символы!!!", "Ошибка!!!");
                price.Text = price.Text.Remove(price.Text.Length - 1);
                price.SelectionStart = price.Text.Length;
            }
        }
    }
}
