//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineTechnicalHiring.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTechnician
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTechnician()
        {
            this.tblPosts = new HashSet<tblPost>();
            this.tblReviews = new HashSet<tblReview>();
        }
    
        public int TID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Nullable<int> TType { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public int WorkCount { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public string Password { get; set; }
        public byte[] Photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPost> tblPosts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReview> tblReviews { get; set; }
    }
}
