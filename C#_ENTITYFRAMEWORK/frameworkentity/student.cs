//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace frameworkentity
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        public int StdID { get; set; }
        public string name { get; set; }
        public long Rollno { get; set; }
        public int DeptID { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
