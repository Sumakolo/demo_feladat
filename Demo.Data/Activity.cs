//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        public string ActID { get; set; }
        public Nullable<System.DateTime> ActDate { get; set; }
        public string EmpName { get; set; }
        public string TaskName { get; set; }
        public Nullable<int> ActTimeHours { get; set; }
        public Nullable<int> ActTimeMinutes { get; set; }
        public string ActDescription { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Task Task { get; set; }
    }
}
