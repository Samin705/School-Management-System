using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(subjectdata))]
    public partial class subject
    {

    }
    public class subjectdata
    {
        [Display(Name = "Subject ID")]
        public int subjectid { get; set; }
        [Display(Name = "Subject Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Subject Name is required")]
        public string subjectname { get; set; }

        [Display(Name = "Class Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Class id required")]
        public int classid { get; set; }
    }
}