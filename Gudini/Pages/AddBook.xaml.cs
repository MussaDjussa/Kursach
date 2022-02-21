using BuckApp.Model;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using Image = System.Drawing.Image;

namespace BuckApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        private static OpenFileDialog dialogCover = new OpenFileDialog();
        private static OpenFileDialog dialogContent = new OpenFileDialog();
        private static String textBook;
        private static byte[] bytes;
        public AddBook()
        {
            
            InitializeComponent();
            AuthorBox.ItemsSource = MainWindow.model.Author.ToList();
            GenreBox.ItemsSource = MainWindow.model.Genre.ToList();
            InitializeComponent();
        }


        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void addCover_Click(object sender, RoutedEventArgs e)
        {
            dialogCover.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialogCover.ShowDialog()== true)
            {
                CoverImage.Source = new BitmapImage(new Uri(dialogCover.FileName));
            }
        }

        private void removeCover_Click(object sender, RoutedEventArgs e)
        {
            CoverImage.Source = null;
        }

        private void fileAdd_Click(object sender, RoutedEventArgs e)
        {

            dialogContent.Title = "text selection";
            dialogContent.Filter = "TXT(.txt)|*.txt|DOCX(.docx)|*.docx";
            if (dialogContent.ShowDialog() == true)
            {
                if (dialogContent.FileName.EndsWith(".txt"))
                {
                    bytes = System.IO.File.ReadAllBytes(dialogContent.FileName);
                    casefiletext.Content = "Файл выбран";
                }
                else
                {
                    using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(dialogContent.FileName, true))
                    {
                        Body text = wordDoc.MainDocumentPart.Document.Body;
                        textBook = text.InnerText.ToString();
                        bytes = Encoding.Unicode.GetBytes(textBook);
                        casefiletext.Content = "Файл выбран";
                    }
                }
            }
            
        }

        private void removefile_Click(object sender, RoutedEventArgs e)
        {
            bytes = null;
            casefiletext.Content = "Файл не выбран";
        }

        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            Author author = AuthorBox.SelectedItem as Author;
            Genre genre = GenreBox.SelectedItem as Genre;
            Image image = new Bitmap(dialogCover.FileName);


            if (author == null || genre == null || bytes == null || image == null)
            {
                MessageBox.Show("Недостаточно данных для добавления книги");
            }
            else
            {
                MainWindow.model.Book.Add(new Book()
                {

                    Name = NameText.Text,
                    Description = DescriptText.Text,
                    Id_Genre = genre.Id,
                    Id_Author = author.Id,
                    ContentText = bytes,
                    Cover = ImageToByte(image),
                    Cost = Convert.ToInt32(CostText),
                    Discount = Convert.ToInt32(DiscText),
                    Year = Convert.ToInt32(YearText)

                });
                MainWindow.model.SaveChanges();
            }
        }

        private static string costtext = "0";
        private void CostText_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            //textBox.Text = textBox.Text.Trim('0');
            if (textBox.Text == "")
            {
                textBox.Text = costtext;
                return;
            }

            if (!Regex.IsMatch(textBox.Text, "[^0-9 ]+$") == true)
            {
                try
                {
                    if (Convert.ToInt32(textBox.Text) > 0)
                    {
                        costtext = textBox.Text;
                    }
                }
                catch
                {
                    textBox.Text = costtext;
                }
            }
            else
            {
                textBox.Text = costtext;
            }
           
        }
        private static string yearstr = "0";
        private void YearText_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            //textBox.Text = textBox.Text.Trim('0');
            if (textBox.Text == "")
            {
                textBox.Text = yearstr;
                return;
            }

            if (!Regex.IsMatch(CostText.Text, "[^0 - 9]") == true)
            {
                try
                {
                    if (Convert.ToInt32(textBox.Text) >= 0 && Convert.ToInt32(textBox.Text) <= 2022)
                    {
                        yearstr = textBox.Text;
                    }
                    else
                    {
                        textBox.Text = yearstr;
                    }
                }
                catch
                {
                    textBox.Text = yearstr;
                }
                //CostText.SelectionStart = CostText.Text.Length;
            }
            else
            {
                textBox.Text = yearstr;
            }
        }


        private static string disctext = "0";
        private void DiscText_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            TextBox textBox = sender as TextBox;
            //textBox.Text = textBox.Text.Trim('0');
            if (textBox.Text == "")
            {
                textBox.Text = disctext;
                return;
            }
            
            try
            {
                if (Convert.ToUInt32(textBox.Text) > 100 || textBox.Text.Length > 3)
                {
                    textBox.Text = disctext;
                }
                else
                {
                    disctext = textBox.Text;
                }
            }
            catch
            {
                textBox.Text = disctext;
                textBox.Text.Trim('0');
            }
        }
    }
}
