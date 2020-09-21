using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(studentdata))]
    public partial class student
    {
        [Display(Name = "Student Confirm Password")]
        [DataType(DataType.Password)]
        public string studentconfirmpassword { get; set; }
    }
    public class studentdata
    {
        public int id { get; set; }

        [Display(Name = "Student ID")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Super Admin ID is required")]
        public string studentid { get; set; }

        //stname
        [Display(Name = "Student Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Student Name is required")]
        public string studentname { get; set; }

        //stpass
        [Display(Name = "Student Password")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Student Password is required")]
        [MinLength(8, ErrorMessage = "Atleast 8 characters required")]
        public string studentpassword { get; set; }

        //stdob
        [Display(Name = "Student Date Of Birth")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Birth Date is required")]
        [DataType(DataType.Date)]
        public System.DateTime studentdob { get; set; }

        //stphone
        [Display(Name = "Student Phone")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone Number is required")]
        public int studentphone { get; set; }

        //staddress
        [Display(Name = "Student Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Student Address is required")]
        public string studentaddress { get; set; }

        //stemail
        [Display(Name = "Student Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Student Email is required")]
        [DataType(DataType.EmailAddress)]
        public string studentemail { get; set; }

        //stbloodgroup
        [Display(Name = "Student Blood Group")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Blood group need to be mentioned")]
        public string studentbloodgroup { get; set; }

        //stfees
        [Display(Name = "Student Fees")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Fees amount required")]
        public int studentfees { get; set; }

        //classid
        [Display(Name = "Class ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "class id required")]
        public int classid { get; set; }

        //sectionid
        [Display(Name = "Section ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "section id required")]
        public int sectionid { get; set; }
    }
}