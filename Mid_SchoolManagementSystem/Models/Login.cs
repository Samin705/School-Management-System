using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mid_SchoolManagementSystem.Models
{
    public class Login
    {
        [Display(Name = "User ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "User ID Required!")]
        public string Userid { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Required!")]
        public string Password { get; set; }
    }
}