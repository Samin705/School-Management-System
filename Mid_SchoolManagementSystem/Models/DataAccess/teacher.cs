//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class teacher
    {
        public int id { get; set; }
        public string teacherid { get; set; }
        public string teachername { get; set; }
        public string teacherpassword { get; set; }
        public string teacherbloodgroup { get; set; }
        public string teacheremail { get; set; }
        public int teacherphone { get; set; }
        public int classid { get; set; }
        public int sectionid { get; set; }
        public int subjectid { get; set; }
        public int teachersalary { get; set; }
    }
}
