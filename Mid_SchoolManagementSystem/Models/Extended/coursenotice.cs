using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(coursenoticedata))]
    public partial class coursenotice
    {
    }

    public class coursenoticedata
    {
        [Display(Name = "Notice ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Notice ID is required")]
        public int noticeid { get; set; }

        [Display(Name = "Notice Subject")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Notice Subject is required")]
        public string noticesubject { get; set; }

        [Display(Name = "Notice Description")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Notice Description is required")]
        public string noticedescription { get; set; }

        [Display(Name = "Section ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Section ID is required")]
        public int sectionid { get; set; }

        [Display(Name = "Subject ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Subject ID is required")]
        public int subjectid { get; set; }
    }
}