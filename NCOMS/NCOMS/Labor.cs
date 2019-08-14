//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCOMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Labor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Labor()
        {
            this.Labor_advance = new HashSet<Labor_advance>();
            this.Labor_Attendance = new HashSet<Labor_Attendance>();
            this.Labor_OT = new HashSet<Labor_OT>();
            this.Labor_Mobile = new HashSet<Labor_Mobile>();
        }
    
        public int labor_id { get; set; }
        public int site_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> date_of_birth { get; set; }
        public string designation { get; set; }
        public string nic { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> join_on { get; set; }
        public string civil_status { get; set; }
        public Nullable<float> hourly_rate { get; set; }
        public Nullable<float> ot_rate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Labor_advance> Labor_advance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Labor_Attendance> Labor_Attendance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Labor_OT> Labor_OT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Labor_Mobile> Labor_Mobile { get; set; }
        public virtual Site Site { get; set; }
    }
}
