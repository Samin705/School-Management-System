using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(admindata))]
    public partial class admin
    {
        public string adminconfirmpassword { get; set; }
    }

    public class admindata
    {
        public int id { get; set; }

        [Display(Name = "Admin ID")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Admin ID is required")]
        public string adminid { get; set; }

        [Display(Name = "Admin Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Admin Name is required")]
        public string adminname { get; set; }

        [Display(Name = "Admin Password")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Admin Password is required")]
        [MinLength(8, ErrorMessage = "Atleast 8 characters required")]
        public string adminpassword { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("adminpassword", ErrorMessage = "Passwords do not match!")]
        public string adminconfirmpassword { get; set; }
    }
}