using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(teacherdata))]
    public partial class teacher
    {
        public string teacherconfirmpassword { get; set; }
    }

    public class teacherdata
    {
        public int id { get; set; }

        [Display(Name = "Teacher ID")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Admin ID is required")]
        public string teacherid { get; set; }

        [Display(Name = "Teacher Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Admin Name is required")]
        public string teachername { get; set; }

        [Display(Name = "Teacher Password")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Teacher Password is required")]
        [MinLength(8, ErrorMessage = "Atleast 8 characters required")]
        public string teacherpassword { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("teacherpassword", ErrorMessage = "Passwords do not match!")]
        public string teacherconfirmpassword { get; set; }

        [Display(Name = "Blood Group")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Blood Group is required")]
        [MaxLength(3, ErrorMessage = "Atmost 3 characters required")]
        public string teacherbloodgroup { get; set; }

        [Display(Name = "Email Adddress")]
        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Address is required")]
        public string teacheremail { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone Number is required")]
        public int teacherphone { get; set; }

        [Display(Name = "Class Id")]
        public int classid { get; set; }

        [Display(Name = "Section Id")]
        public int sectionid { get; set; }

        [Display(Name = "Subject Id")]
        public int subjectid { get; set; }

        [Display(Name = "Salary")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Salary is required")]
        public int teachersalary { get; set; }
    }
}