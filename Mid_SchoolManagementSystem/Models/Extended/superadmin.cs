using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(superadmindata))]
    public partial class superadmin
    {
        public string superadminconfirmpassword { get; set; }
    }

    public class superadmindata
    {
        public int id { get; set; }

        [Display(Name = "Super Admin ID")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Super Admin ID is required")]
        public string superadminid { get; set; }

        [Display(Name = "Super Admin Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Super Admin Name is required")]
        public string superadminname { get; set; }

        [Display(Name = "Super Admin Password")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Super Admin Password is required")]
        [MinLength(8, ErrorMessage = "Atleast 8 characters required")]
        public string superadminpassword { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("superadminpassword", ErrorMessage = "Passwords do not match!")]
        public string superadminconfirmpassword { get; set; }

        
    }

}