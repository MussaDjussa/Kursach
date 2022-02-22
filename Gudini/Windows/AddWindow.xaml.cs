using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;

namespace BuckApp.Windows
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {

        private static OpenFileDialog dialogCover = new OpenFileDialog();
        private static OpenFileDialog dialogContent = new OpenFileDialog();
        private static String textBook;
        private static byte[] bytes;



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
            MainWindow.addAuthor.Show();
        }
        private void genre_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.addGenre.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dialogCover.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialogCover.ShowDialog() == true)
            {
                image.Source = new BitmapImage(new Uri(dialogCover.FileName));
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            image.Source = null;
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
