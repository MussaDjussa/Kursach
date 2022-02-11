//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuckApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Genre_Book = new HashSet<Genre_Book>();
            this.User_Book = new HashSet<User_Book>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Id_Author { get; set; }
        public string Description { get; set; }
        public byte[] ContentText { get; set; }
        public Nullable<int> Year { get; set; }
        public byte[] Cover { get; set; }
        public Nullable<int> Id_Genre { get; set; }
    
        public virtual Author Author { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Genre_Book> Genre_Book { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Book> User_Book { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
