//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ForTesting
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Borrow = new HashSet<Borrow>();
        }
    
        public int id { get; set; }
        public string rfid { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string category { get; set; }
        public Nullable<System.DateTime> recordDate { get; set; }
        public string shelf { get; set; }
        public Nullable<int> stock { get; set; }
        public Nullable<int> activeStock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Borrow> Borrow { get; set; }
    }
}
