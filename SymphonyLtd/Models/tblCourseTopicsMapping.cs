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
    
    public partial class tblCourseTopicsMapping
    {
        public int CourseTopicID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> TopicID { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    
        public virtual tblCourse tblCourse { get; set; }
        public virtual tblTopic tblTopic { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
