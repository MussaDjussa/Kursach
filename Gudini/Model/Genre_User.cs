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
    
    public partial class Genre_User
    {
        public int Id { get; set; }
        public Nullable<int> Id_Genre { get; set; }
        public Nullable<int> Id_Book { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
