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
    
    public partial class tblApplication
    {
        public int ApplicationID { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string ApplyStatus { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Nullable<bool> GetInTouch { get; set; }
    }
}
