using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(livedata))]
    public partial class live
    {
        
    }
    public class livedata
    {
        [Display(Name = "Live ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Live ID is required")]
        public int liveid { get; set; }

        [Display(Name = "Section ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Section ID is required")]
        public int sectionid { get; set; }

        [Display(Name = "Subject ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Subject ID is required")]
        public int subjectid { get; set; }

        [Display(Name = "Live URL")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Live URL is required")]
        public string liveurl { get; set; }
    }
}