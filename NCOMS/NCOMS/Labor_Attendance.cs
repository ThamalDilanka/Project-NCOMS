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
    
    public partial class Labor_Attendance
    {
        public int labor_id { get; set; }
        public int site_id { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<System.TimeSpan> in_time { get; set; }
        public Nullable<System.TimeSpan> out_time { get; set; }
    
        public virtual Labor Labor { get; set; }
    }
}
