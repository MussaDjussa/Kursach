using System.Windows;
using System.Windows.Controls;
using BuckApp.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using DocumentFormat.OpenXml.Packaging;
using System.Windows.Forms;
using System.Text;
using System;
using System.Drawing;
using System.Activities.Statements;
using DocumentFormat.OpenXml.Wordprocessing;
using Aspose.Words;
using Document = Aspose.Words.Document;
using Body = DocumentFormat.OpenXml.Wordprocessing.Body;

namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for MoreDetails_StoreBook.xaml
    /// </summary>
    public partial class MoreDetails_StoreBook : Page
    {
        Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
       
        public static Book newbook;
        public static String textBook;
        public MoreDetails_StoreBook(Book book)
        {
            InitializeComponent();
            if (Login.user.Id_Role == 2)
            { 
                LesenButton.Visibility = Visibility.Collapsed;
            }
            newbook = book;
            try
            {
                DataContext = newbook;
            }
            catch
            {
                System.Windows.MessageBox.Show("Не удалось подгрузить книгу");
            }
        }


       
        /// <summary>
        /// закрытие приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        /// <summary>
        /// Навигация к предыдущей странице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void LesenButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LesenPage(DataContext as Book));
        }

      

        private void Add_Click_1(object sender, RoutedEventArgs e)
        {
            
            dlg.Title = "text selection";
            dlg.Filter = "TXT(.txt)|*.txt|DOCX(.docx)|*.docx";
            if (dlg.ShowDialog() == true)
            {
                if (dlg.FileName.EndsWith(".txt"))
                {
                    byte[] bytes = System.IO.File.ReadAllBytes(dlg.FileName);
                    newbook.ContentText = bytes;
                }
                else
                {
                    //Document doc = new Document(dlg.FileName);
                    //MemoryStream outStream = new MemoryStream();
                    //doc.Save(outStream, SaveFormat.Docx);
                    //byte[] docBytes = Encoding.Unicode.GetBytes();

                    //newbook.ContentText = docBytes;

                    using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(dlg.FileName, true))
                    {
                        Body text = wordDoc.MainDocumentPart.Document.Body;
                        textBook = text.InnerText.ToString();
                        byte[] docBytes = Encoding.Unicode.GetBytes(textBook);
                        newbook.ContentText = docBytes;
                    }
                }
            }
            MainWindow.model.SaveChanges();
        }
    }
}
