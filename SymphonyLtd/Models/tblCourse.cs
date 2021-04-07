//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SymphonyLtd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCourse
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public Nullable<int> CourseCategory_FK { get; set; }
        public string CourseDuration { get; set; }
        public Nullable<decimal> CourseFees { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Term { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    
        public virtual tblCourseCategory tblCourseCategory { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
