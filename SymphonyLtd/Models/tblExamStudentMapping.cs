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
    
    public partial class tblExamStudentMapping
    {
        public int ExamStudentMappingID { get; set; }
        public Nullable<int> ExamID { get; set; }
        public Nullable<int> StudentID { get; set; }
    
        public virtual tblExam tblExam { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
