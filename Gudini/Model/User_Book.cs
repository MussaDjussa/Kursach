//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuckApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Book
    {
        public int Id { get; set; }
        public Nullable<int> Id_User { get; set; }
        public Nullable<int> Id_Book { get; set; }
        public Nullable<int> Id_Status { get; set; }
        public Nullable<float> Rating { get; set; }
        public Nullable<System.DateTime> Date_Buy { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}
