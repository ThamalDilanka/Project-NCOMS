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
    
    public partial class GO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GO()
        {
            this.GOS_Material = new HashSet<GOS_Material>();
            this.GOS_Money_Status = new HashSet<GOS_Money_Status>();
        }
    
        public int gos_id { get; set; }
        public Nullable<int> order_id { get; set; }
        public Nullable<int> driver_id { get; set; }
        public Nullable<int> vehicle_id { get; set; }
        public string shop { get; set; }
        public Nullable<int> bill_no { get; set; }
        public Nullable<float> total_amount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GOS_Material> GOS_Material { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GOS_Money_Status> GOS_Money_Status { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Order Order { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
