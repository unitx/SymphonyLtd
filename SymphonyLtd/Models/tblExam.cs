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
    
    public partial class tblExam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblExam()
        {
            this.tblResults = new HashSet<tblResult>();
        }
    
        public int ExamID { get; set; }
        public string ExamName { get; set; }
        public Nullable<int> Studen_FK { get; set; }
        public Nullable<int> Course_FK { get; set; }
        public Nullable<int> CurrentSemister { get; set; }
        public Nullable<System.TimeSpan> ExamDuration { get; set; }
        public Nullable<System.DateTime> ExamScheduleFrom { get; set; }
        public Nullable<System.DateTime> ExamScheduleTo { get; set; }
        public Nullable<int> ExamType_FK { get; set; }
        public Nullable<decimal> TotalMarks { get; set; }
        public Nullable<decimal> PassingMarks { get; set; }
        public bool IsValid { get; set; }
        public bool IsCancled { get; set; }
        public string IsCancledReason { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.DateTime> DeleteOn { get; set; }
        public Nullable<int> DeletedBy { get; set; }
    
        public virtual tblExamType tblExamType { get; set; }
        public virtual tblUser tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblResult> tblResults { get; set; }
    }
}
