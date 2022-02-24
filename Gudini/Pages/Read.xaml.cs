using BuckApp.Model;
using System;
using System.Text;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for Read.xaml
    /// </summary>
    public partial class Read : Page
    {
        public static Book newBook;
        static System.Windows.Documents.Paragraph paragraph = new System.Windows.Documents.Paragraph();
        public Read()
        {
            InitializeComponent();
            DataContext = MainWindow.book.ViewModel.SelectedItem;

            newBook = MainWindow.book.ViewModel.SelectedItem;


            paragraph.Inlines.Clear();
            String s = Encoding.Unicode.GetString(newBook.ContentText);
            paragraph.Inlines.Add(s);
            FlowDocument document = new FlowDocument(paragraph);
            document.ColumnWidth = 2000;
            document.Background = Brushes.Beige;
            reader.Document = document;
        }
    }
}
