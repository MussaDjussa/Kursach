using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuckApp
{
    public class FilterBook
    {
        public string Name;
        public string Author;
        public string Genre;
        public FilterBook(string Name, string Author, string Genre)
        { 
            this.Name = Name;
            this.Author = Author;   
            this.Genre = Genre;
        }
    }
}
