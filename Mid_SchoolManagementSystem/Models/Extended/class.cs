using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{

    [MetadataType(typeof(classdata))]
    public partial class @class
    {

    }
    public class @classdata
    {
        [Display(Name = "Class ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Class ID is required")]
        public int classid { get; set; }

        [Display(Name = "Class Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Class Name is required")]
        public string classname { get; set; }
    }


}
