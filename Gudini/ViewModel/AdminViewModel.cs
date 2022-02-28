using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using BuckApp.Model;
namespace BuckApp.ViewModel
{
    public class AdminViewModel : INotifyPropertyChanged
    {
        private Book _selectedItem = null;

        public ICollectionView _collectionView;

        private string _filteredText;

        private Book _deletedItem = null;
        public Book DeletedItem {
            get
            {
                return _deletedItem;
            }
            set
            {
                _deletedItem = value;
                DeletedItem = SelectedItem;
                OnPropertyChanged("DeletedItem");
            }
        }
        public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();

        public AdminViewModel()
        {

            foreach (var book in MainWindow.model.Book.ToList())
            {
                Books.Add(book);
            }

            _collectionView = CollectionViewSource.GetDefaultView(Books);
            _collectionView.Filter = FilterCollectionBook;
        }

        private bool FilterCollectionBook(object obj)
        {
            Book book = obj as Book;

            if (string.IsNullOrWhiteSpace(FilterText))
            {
                return true;
            }
            else if (book.Name.Contains(FilterText))
            {
                return true;
            }
            else if (book.Author.FName.Contains((FilterText)))
            {
                return true;
            }
            else if (book.Author.LName.Contains((FilterText)))
            {
                return true;
            }
            else if (book.Author.MName.Contains((FilterText)))
            {
                return true;
            }
            else if (book.Genre.Name.Contains((FilterText)))
            {
                return true;
            }
            else if (book.Author.LName.Contains((FilterText)) && book.Author.FName.Contains(FilterText) && book.Author.MName.Contains(FilterText))
            {
                return true;
            }
            else if (book.Author.LName.Contains((FilterText)) && book.Author.FName.Contains(FilterText))
            {
                return true;
            }
            else if (book.Year.ToString().Contains(FilterText))
            {
                return true;
            }
            return false;
        }

        public Book SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged("SelectedItem");
                }
            }
        }

        public string FilterText
        {
            get => _filteredText;
            set
            {
                if (value != null)
                {
                    _filteredText = value;
                    _collectionView.Refresh();
                    OnPropertyChanged(nameof(FilterText));
                }

            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public void OnPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
