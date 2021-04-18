﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SymphonyDBEntities : DbContext
    {
        public SymphonyDBEntities()
            : base("name=SymphonyDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblAboutU> tblAboutUs { get; set; }
        public virtual DbSet<tblApplication> tblApplications { get; set; }
        public virtual DbSet<tblBranch> tblBranches { get; set; }
        public virtual DbSet<tblCertificate> tblCertificates { get; set; }
        public virtual DbSet<tblCertificateType> tblCertificateTypes { get; set; }
        public virtual DbSet<tblCity> tblCities { get; set; }
        public virtual DbSet<tblClassType> tblClassTypes { get; set; }
        public virtual DbSet<tblContactU> tblContactUs { get; set; }
        public virtual DbSet<tblCountry> tblCountries { get; set; }
        public virtual DbSet<tblCourse> tblCourses { get; set; }
        public virtual DbSet<tblCourseCategory> tblCourseCategories { get; set; }
        public virtual DbSet<tblCourseFeature> tblCourseFeatures { get; set; }
        public virtual DbSet<tblCourseTopicsMapping> tblCourseTopicsMappings { get; set; }
        public virtual DbSet<tblEnrollment> tblEnrollments { get; set; }
        public virtual DbSet<tblExam> tblExams { get; set; }
        public virtual DbSet<tblExamStudentMapping> tblExamStudentMappings { get; set; }
        public virtual DbSet<tblExamType> tblExamTypes { get; set; }
        public virtual DbSet<tblFAQ> tblFAQs { get; set; }
        public virtual DbSet<tblFAQType> tblFAQTypes { get; set; }
        public virtual DbSet<tblFee> tblFees { get; set; }
        public virtual DbSet<tblFeesType> tblFeesTypes { get; set; }
        public virtual DbSet<tblHomePageBox> tblHomePageBoxes { get; set; }
        public virtual DbSet<tblNewsItem> tblNewsItems { get; set; }
        public virtual DbSet<tblPartner> tblPartners { get; set; }
        public virtual DbSet<tblResult> tblResults { get; set; }
        public virtual DbSet<tblRole> tblRoles { get; set; }
        public virtual DbSet<tblState> tblStates { get; set; }
        public virtual DbSet<tblTeacher> tblTeachers { get; set; }
        public virtual DbSet<tblTopic> tblTopics { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    }
}
