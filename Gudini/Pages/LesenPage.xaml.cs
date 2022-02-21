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
using BuckApp.Model;

namespace BuckApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для LesenPage.xaml
    /// </summary>
    public partial class LesenPage : Page
    {
        public static Book newBook;
        static System.Windows.Documents.Paragraph paragraph = new System.Windows.Documents.Paragraph();
        public LesenPage(Book book)
        {
            try
            {
                newBook = book;
                InitializeComponent();
            }
            catch
            {
                MessageBox.Show("не удалось погрузить книгу");
            }
        }

        private void FlowDocumentReader_Initialized(object sender, EventArgs e)
        {
            try
            {
                FlowDocumentReader flowDocument = sender as FlowDocumentReader;
                paragraph.Inlines.Clear();
                String s = Encoding.Unicode.GetString(newBook.ContentText);
                paragraph.Inlines.Add(s);
                FlowDocument document = new FlowDocument(paragraph);
                document.ColumnWidth = 2000;
                document.Background = Brushes.White;
                flowDocument.Document = document;
            }
            catch
            {
                MessageBox.Show("Содержимое книги пусто");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
