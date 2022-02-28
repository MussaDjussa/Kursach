using System.Collections.ObjectModel;
using System.ComponentModel;
using BuckApp.Model;
using System.Windows.Data;
using System.Linq;
using System.Text;
using System;
using System.IO;
using System.Windows;

namespace BuckApp.ViewModel
{
    public class StoreBook_ViewModel : INotifyPropertyChanged
    {
       

        private Book _selectedItem;

        private string _filtertext;
        
        private ICollectionView _collectionView;

        /// <summary>
        /// Основная коллекция книг 
        /// </summary>
        public  ObservableCollection<Book> Book { get; set; } = new ObservableCollection<Book>();

        /// <summary>
        /// Коллекция книг пользователя
        /// </summary>
        public ObservableCollection<User_Book> BookUser { get; set; } = new ObservableCollection<User_Book>();

        public event PropertyChangedEventHandler PropertyChanged;
        public Book SelectedItem
        {
            get { return _selectedItem;  }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        private User_Book _selecteditemUserBook;
        public User_Book SelectedItem_UserBook
        {
            get { return _selecteditemUserBook;  }
            set
            {
                _selecteditemUserBook = value;
                OnPropertyChanged("SelectedItem_UserBook");
            }
        }

        public string FilterText
        {
            get { return _filtertext; }
            set
            {
                if (value != null)
                {
                    _filtertext = value;
                    _collectionView.Refresh();
                    OnPropertyChanged("FilterText");

                }
            }
        }

        /// <summary>
        /// определение объектов с модели к UserBook свойству(необходимо переделать)
        /// </summary>
        public StoreBook_ViewModel()
        {
            foreach (var item in MainWindow.model.Book.ToList())
            {
                Book.Add(item);
            }
            // переделать, нужно подхватить ID пользователя
            if (Pages.Login.user != null)
            {
                foreach (var item in MainWindow.model.User_Book.ToList().Where(q => q.Id_User == Pages.Login.user.Id))
                {
                    BookUser.Add(item);
                }
            }

            _collectionView = CollectionViewSource.GetDefaultView(Book);
            _collectionView.Filter = Filter;
        }

        private bool Filter(object obj)
        {
            Book book = (Book)obj;


            if (string.IsNullOrWhiteSpace(FilterText))
            {
                return true;
            }
            else if (book.Name.Contains(FilterText))
            {
                return true;
            }
            else if (book.Author.LName.Contains(FilterText))
            {
                return true;
            }
            else if(book.Genre.Name.Contains(FilterText))
            {
                return true;
            }    
            return false;
        }


        public void OnPropertyChanged(string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
